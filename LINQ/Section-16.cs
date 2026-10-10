#region Q106
//var result106 = Repository.Employees.Where(e => e.Skills.Contains("C#"));
//Print(result106);
#endregion

#region Q107
//var result107 = Repository.Employees.Where(e => e.Skills.Contains("SQL"));
//Print(result107);
#endregion

#region Q108
//var result108 = Repository.Employees.Any(e => e.Skills.Contains("Docker"));
//Console.WriteLine(result108);
#endregion

#region Q109
//var result109 = Repository.Employees.Where(e => e.Skills.Contains("C#") && e.Skills.Contains("SQL"));
//Print(result109);
#endregion

#region Q110
//var result110 = Repository.Employees.Where(e => e.Skills.Contains("C#") || e.Skills.Contains("Python"));
//Print(result110);
#endregion

#region Q111
//var result111 = Repository.Employees.Where(e => e.Skills.Contains("Docker")).Select(e => e.Name);
//Print(result111);
#endregion

#region Q112
//var result112 = Repository.Employees.Where(e => e.Skills.Count > 3);
//Print(result112);
#endregion

#region Q113
//var result113 = Repository.Employees.Where(e => e.IsActive && e.Skills.Contains("Excel"));
//Print(result113);
#endregion

#region Q114
//var result114 = Repository.Employees.Where(e => e.DepartmentId == 10 && e.Skills.Contains("C#"));
//Print(result114);
#endregion