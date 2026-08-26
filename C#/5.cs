Console.Write("Enter the size of Array: ");
int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
Console.WriteLine("Enter the Elements of Array");
for (int i = 0; i < n; i++)
   nums[i] = int.Parse(Console.ReadLine());

int max = nums[0];
int min = nums[0];

for (int i = 0; i < n; i++){
   if (nums[i] >  max) max = nums[i];

   if (nums[i] < min) min = nums[i];
}
int product = max * min;
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Produt: {product}");