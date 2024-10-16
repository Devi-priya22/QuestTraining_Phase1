namespace Students
{
    class StudentData
    {
        public string Name;
        public string RegNo;
        public int Standard;
        public string SubjectOne;
        public string SubjectTwo;
        public string SubjectThree;
        public int MarkOne;
        public int MarkTwo;
        public int MarkThree;
        public int MaxMarks;


        public override string ToString()
        {
            return $"Name : {Name}, Registration Number : {RegNo}, Standard : {Standard}";
            return $"Subject : {SubjectOne}      Marks : {MarkOne}      Max Marks : {MaxMarks}";
            return $"Subject : {SubjectTwo}      Marks : {MarkTwo}      Max Marks : {MaxMarks}";
            return $"Subject : {SubjectThree}    Marks : {MarkThree}    Max Marks : {MaxMarks}";

        }
    }
}