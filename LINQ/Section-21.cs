#region Q133
//var result133 = Repository.Employees.Join(Repository.Departments, e => e.DepartmentId, d => d.Id,
//    (e, d) => new { EmployeeName = e.Name, DepartmentName = d.Name });
//Print(result133);
#endregion

#region Q134
//var result134 = Repository.Employees.Join(Repository.Departments, e => e.DepartmentId, d => d.Id,
//    (e, d) => new { EmployeeName = e.Name, DepartmentName = d.Name, e.Salary });
//Print(result134);
#endregion

#region Q135
//var result135 = Repository.Employees.Join(Repository.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new { e.Name, DepartmentName = d.Name })
//    .Where(x => x.DepartmentName == "Finance & Accounting")
//    .Select(x => x.Name);
//Print(result135);
#endregion

#region Q136
//var result136 = Repository.Employees.Join(Repository.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new { e.Name, DepartmentName = d.Name })
//    .Where(x => x.DepartmentName == "Sales & Marketing")
//    .Select(x => x.Name);
//Print(result136);
#endregion

#region Q137
//var result137 = Repository.Employees.Where(e => e.IsActive)
//    .Join(Repository.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new { EmployeeName = e.Name, DepartmentName = d.Name });
//Print(result137);
#endregion

#region Q138
//var result138 = Repository.Employees.Where(e => e.Salary > 15000)
//    .Join(Repository.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new { EmployeeName = e.Name, DepartmentName = d.Name });
//Print(result138);
#endregion