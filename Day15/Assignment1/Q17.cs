var employee = new List<Employee>()
    {
        new Employee{Name = "Alpha", DeptID = 1},
        new Employee{Name = "Beta", DeptID = 2},
        new Employee{Name = "Gamma", DeptID = 1},
        new Employee{Name = "Delta", DeptID = 3},
        new Employee{Name = "Epsilon", DeptID = 2}
    };

var department = new List<Departments>()
    {
        new Departments{ID = 1, Department = "Computer Science"},
        new Departments{ID = 2, Department = "Mechanical"},
        new Departments{ID = 3, Department = "Architecture"}
    };

var empWithDepts = employee
    .Join(
    department,
    e => e.DeptID,
    d => d.ID,
    (e, d) => new
    {
        EmployeeName = e.Name,
        DepartmentName = d.Department
    }
        );
    foreach(var i in empWithDepts)
    {
        System.Console.WriteLine(i.EmployeeName + " : " + i.DepartmentName);
    }