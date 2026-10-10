#region Q36
//var employee = Repository.Employees.Where(e => e.IsActive).Select(e => e.Name);
//Print(employee);
#endregion

#region Q37
//var employee = Repository.Employees.Where(e => e.Age > 30).Select(e => e.Name);
//Print(employee);
#endregion

#region Q38
//var employee = Repository.Employees.Where(e => e.Salary > 15000).Select(e => e.Name);
//Print(employee);
#endregion

#region Q39
//var employee = Repository.Employees.Where(e => e.HireDate.Year > 2022).Select(e => e.Name);
//Print(employee);
#endregion

#region Q40
//var employee = Repository.Employees.Where(e => e.IsActive).Select(e => new { e.Name, e.Salary });
//Print(employee);
#endregion

#region Q41
//var employee = Repository.Employees.Where(e => e.Salary >= 10000 && e.Salary <= 20000).Select(e => new { e.Name, e.Age, e.Salary });
//Print(employee);
#endregion

#region Q42
//var employee = Repository.Employees.Where(e => e.IsActive && e.DepartmentId == 10).Select(e => e.Name);
//Print(employee);
#endregion