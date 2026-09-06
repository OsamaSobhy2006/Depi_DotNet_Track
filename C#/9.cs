Console.Write("Enter the size or Array: ");
int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
for(int i = 0; i < n; i++){
   nums[i] = int.Parse((Console.ReadLine()));
}
Console.Write("Enter K: ");
int k = int.Parse(Console.ReadLine());
int count = 0;
for(int i = 0; i < n; i++){
   for(int j = 0; j < n; j++){
       if (i != j && nums[i] - nums[j] == k) count++;
   }
}
Console.WriteLine(count);