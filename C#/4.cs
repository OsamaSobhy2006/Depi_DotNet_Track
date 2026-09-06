Console.Write("Enter the Start Position: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Enter the End Position: ");
int end = int.Parse(Console.ReadLine());

int sum = 0;
int count = 0;

for (int i = start; i <= end; i++){
   if(i % 3 == 0 || i % 5 == 0){
       sum += i;
       count++;
   }
}

double avg = (double)sum / count;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {avg}");
