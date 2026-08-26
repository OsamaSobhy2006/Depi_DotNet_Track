Console.Write("Enter the size or Array: ");
int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
Console.WriteLine("Enter the elements of array");
for (int i = 0; i < n; i++)
   nums[i] = int.Parse(Console.ReadLine());

int even = 0;
int odd = 0;

for (int i = 0; i < n; i++){
   if (nums[i] % 2 == 0)
       even++;
   else
       odd++;
}

int difference = Math.Abs(even - odd);
Console.WriteLine($"The Difference Between Even and Odd number is: {difference}");