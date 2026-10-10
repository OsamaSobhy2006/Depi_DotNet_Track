#region Q130
//var result130 = Repository.Employees.GroupBy(e => e.DepartmentId).Where(g => g.Count() > 4)
//    .Select(g => g.Key);
//Print(result130);
#endregion

#region Q131
//var result131 = Repository.Employees.GroupBy(e => e.DepartmentId).Where(g => g.Sum(e => e.Salary) > 60000)
//    .Select(g => g.Key);
//Print(result131);
#endregion

#region Q132
//var result132 = Repository.Employees.GroupBy(e => e.DepartmentId).Where(g => g.Average(e => e.Salary) > 15000)
//    .Select(g => g.Key);
//Print(result132);
#endregion