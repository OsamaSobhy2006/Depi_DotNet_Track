#region Q147
//var result147 = from e in Repository.Employees where e.IsActive select e;
//Print(result147);
#endregion

#region Q148
//var result148 = from e in Repository.Employees where e.Salary > 15000 select e;
//Print(result148);
#endregion

#region Q149
//var result149 = from e in Repository.Employees select e.Name;
//Print(result149);
#endregion

#region Q150
//var result150 = from e in Repository.Employees where e.IsActive
//    orderby e.Salary descending select e;
//Print(result150);
#endregion

#region Q151
//var result151 = from e in Repository.Employees join d in Repository.Departments
//    on e.DepartmentId equals d.Id
//    select new { EmployeeName = e.Name, DepartmentName = d.Name};
//Print(result151);
#endregion

#region Q152
//var result152 = from d in Repository.Departments join e in Repository.Employees
//    on d.ManagerId equals e.Id
//    select new { DepartmentName = d.Name, ManagerName = e.Name};
//Print(result152);
#endregion