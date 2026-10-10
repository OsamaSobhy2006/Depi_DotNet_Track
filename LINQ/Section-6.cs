#region Q43
//var employee = Repository.Employees.Select(e => new { e.Name, AnnualSalary = e.Salary * 12 });
//Print(employee);
#endregion

#region Q44
//var employee = Repository.Employees.Select(e => new { e.Name, e.Salary, SalaryAfterRaise = (double)e.Salary * 1.10 });
//Print(employee);
#endregion

#region Q45
//var employee = Repository.Employees.Select(e => new { e.Name, e.Age, AgeIn5Years = e.Age + 5 });
//Print(employee);
#endregion

#region Q46
//var employee = Repository.Employees.Select(e => new { e.Name, e.HireDate, YearsOfService = DateTime.Now.Year - e.HireDate.Year });
//Print(employee);
#endregion