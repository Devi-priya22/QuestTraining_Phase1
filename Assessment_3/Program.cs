using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NoteTakingApp
{
    public class Note
    {
        public int NoteID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public class Logger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now} [INFO] {message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now} [ERROR] {message}");
        }
        public void LogDebug(string message)
        {
            Console.WriteLine($"{DateTime.Now} [DEBUG] {message}");
        }
    }
    public interface INoteRepository
    {
        void AddNote(Note note);
        List<Note> GetAllNotes();
        Note GetNoteById(int id);
        void UpdateNote(Note note);
        void DeleteNote(int id);
    }
    public class SqlNoteRepository : INoteRepository
    {
        private readonly string _connStr;
        private readonly Logger _logger;

        public SqlNoteRepository()
        {
            _connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\Documents\\NoteApp.mdf;Integrated Security=True;Connect Timeout=30";
            _logger = new Logger();
            CreateNotesTable();
        }
        private void CreateNotesTable()
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Notes' AND xtype='U')
            CREATE TABLE Notes (
                NoteID INT PRIMARY KEY IDENTITY(1,1),
                Title VARCHAR(100) NOT NULL,
                Content TEXT NOT NULL,
                CreatedAt DATETIME DEFAULT GETDATE(),
                UpdatedAt DATETIME
            );";

            ExecuteQuery(createTableQuery);
        }
        private void ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connStr))
                {
                    _logger.LogDebug("Executing query: " + query);
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    _logger.LogInfo("Query executed successfully.");
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError($"SQL Error: {ex.Message}");
            }
        }
        public void AddNote(Note note)
        {
            string query = "INSERT INTO Notes (Title, Content) VALUES (@Title, @Content)";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connStr))
                {
                    _logger.LogDebug($"Adding note with title: {note.Title}");
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    connection.Open();
                    command.ExecuteNonQuery();
                    _logger.LogInfo($"Note added successfully with title: {note.Title}");
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error adding note: {ex.Message}");
            }
        }
        public List<Note> GetAllNotes()
        {
            List<Note> notes = new List<Note>();
            string query = "SELECT * FROM Notes";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connStr))
                {
                    _logger.LogDebug("Fetching all notes.");
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notes.Add(new Note
                            {
                                NoteID = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Content = reader.GetString(2),
                                CreatedAt = reader.GetDateTime(3),
                                UpdatedAt = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4)
                            });
                        }
                    }
                    _logger.LogInfo("Fetched all notes successfully.");
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error fetching notes: {ex.Message}");
            }
            return notes;
        }
        public Note GetNoteById(int id)
        {
            string query = "SELECT * FROM Notes WHERE NoteID = @NoteID";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connStr))
                {
                    _logger.LogDebug($"Fetching note with ID: {id}");
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NoteID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _logger.LogInfo($"Fetched note with ID {id}.");
                            return new Note
                            {
                                NoteID = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Content = reader.GetString(2),
                                CreatedAt = reader.GetDateTime(3),
                                UpdatedAt = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4)
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error fetching note by ID: {ex.Message}");
            }
            return null;
        }
        public void UpdateNote(Note note)
        {
            string query = "UPDATE Notes SET Title = @Title, Content = @Content, UpdatedAt = GETDATE() WHERE NoteID = @NoteID";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connStr))
                {
                    _logger.LogDebug($"Updating note with ID: {note.NoteID}");
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.Parameters.AddWithValue("@NoteID", note.NoteID);
                    connection.Open();
                    command.ExecuteNonQuery();
                    _logger.LogInfo($"Note with ID {note.NoteID} updated.");
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error updating note: {ex.Message}");
            }
        }
        public void DeleteNote(int id)
        {
            string query = "DELETE FROM Notes WHERE NoteID = @NoteID";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connStr))
                {
                    _logger.LogDebug($"Deleting note with ID: {id}");
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NoteID", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    _logger.LogInfo($"Note with ID {id} deleted.");
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error deleting note: {ex.Message}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            INoteRepository noteRepository = new SqlNoteRepository();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Note Taking App");
                Console.WriteLine("1. Create a new note");
                Console.WriteLine("2. View all notes");
                Console.WriteLine("3. Update an existing note");
                Console.WriteLine("4. Delete a note");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CreateNote(noteRepository);
                        break;
                    case "2":
                        ViewAllNotes(noteRepository);
                        break;
                    case "3":
                        UpdateNote(noteRepository);
                        break;
                    case "4":
                        DeleteNote(noteRepository);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        static void CreateNote(INoteRepository noteRepository)
        {
            try
            {
                Console.Write("Enter title: ");
                string title = Console.ReadLine();
                Console.Write("Enter content: ");
                string content = Console.ReadLine();

                Note newNote = new Note { Title = title, Content = content };
                noteRepository.AddNote(newNote);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the note: " + ex.Message);
            }
        }
        static void ViewAllNotes(INoteRepository noteRepository)
        {
            try
            {
                List<Note> notes = noteRepository.GetAllNotes();
                if (notes.Count == 0)
                {
                    Console.WriteLine("No notes found.");
                }
                else
                {
                    foreach (var note in notes)
                    {
                        Console.WriteLine($"ID: {note.NoteID}, Title: {note.Title}, Created: {note.CreatedAt}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving notes: " + ex.Message);
            }
        }
        static void UpdateNote(INoteRepository noteRepository)
        {
            try
            {
                Console.Write("Enter note ID to update: ");
                int id = int.Parse(Console.ReadLine());
                Note note = noteRepository.GetNoteById(id);

                if (note == null)
                {
                    Console.WriteLine("Note not found.");
                    return;
                }

                Console.Write("Enter new title: ");
                note.Title = Console.ReadLine();
                Console.Write("Enter new content: ");
                note.Content = Console.ReadLine();

                noteRepository.UpdateNote(note);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the note: " + ex.Message);
            }
        }
        static void DeleteNote(INoteRepository noteRepository)
        {
            try
            {
                Console.Write("Enter note ID to delete: ");
                int id = int.Parse(Console.ReadLine());
                noteRepository.DeleteNote(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting the note: " + ex.Message);
            }
        }
    }
}
