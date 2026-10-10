#region Q139
//var result139 = Repository.Employees.Join(Repository.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new { EmployeeName = e.Name, DepartmentName = d.Name, e.Salary })
//    .OrderByDescending(x => x.Salary);
//Print(result139);
#endregion

#region Q140
//var result140 = Repository.Employees.Where(e => e.IsActive)
//    .Join(Repository.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new { EmployeeName = e.Name, DepartmentName = d.Name, e.Salary })
//    .OrderBy(x => x.DepartmentName).ThenByDescending(x => x.Salary);
//Print(result140);
#endregion

#region Q141
//var result141 = Repository.Departments
//    .Join(Repository.Employees, d => d.ManagerId, e => e.Id, (d, e) => new { DepartmentName = d.Name, ManagerName = e.Name });
//Print(result141);
#endregion

#region Q142
//var result142 = Repository.Departments
//    .Join(Repository.Employees, d => d.ManagerId, e => e.Id, (d, e) => new { DepartmentName = d.Name, ManagerName = e.Name, ManagerSalary = e.Salary });
//Print(result142);
#endregion

#region Q143
//var result143 = Repository.Departments
//    .Join(Repository.Employees, d => d.ManagerId, e => e.Id, (d, e) => new { DepartmentName = d.Name, ManagerName = e.Name, ManagerHireDate = e.HireDate });
//Print(result143);
#endregion

#region Q144
//var result144 = Repository.Departments.Join(Repository.Employees, d => d.ManagerId, e => e.Id, (d, e) => new { DepartmentName = d.Name, IsActive = e.IsActive })
//    .Where(x => x.IsActive)
//    .Select(x => x.DepartmentName);
//Print(result144);
#endregion

#region Q145
//var result145 = Repository.Departments.Join(Repository.Employees, d => d.ManagerId, e => e.Id, (d, e) => new { DepartmentName = d.Name, ManagerSalary = e.Salary })
//    .Where(x => x.ManagerSalary > 20000)
//    .Select(x => x.DepartmentName);
//Print(result145);
#endregion

#region Q146
//var result146 = Repository.Departments.Join(Repository.Employees,
//d => d.ManagerId, e => e.Id,
//(d, manager) => new
//{
//DepartmentName = d.Name,
//ManagerName = manager.Name,
//EmployeeCount = Repository.Employees.Count(e => e.DepartmentId == d.Id)
//});
//Print(result146);
#endregion

