Console.Write("Enter the Temprature: ");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
double kelvin = celsius + 273.15;

string status;

if (celsius < 0)
   status = "Freezing";
else if (celsius <= 30)
   status = "Moderate";
else
   status = "Hot";

Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
Console.WriteLine($"Kelvin: {kelvin:F2}");
Console.WriteLine($"Status: {status}");