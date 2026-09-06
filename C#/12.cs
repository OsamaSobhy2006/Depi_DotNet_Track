Console.Write("Enter the size or Array: ");
int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
for(int i = 0; i < n; i++){
   nums[i] = int.Parse(Console.ReadLine());
}
Console.Write("Enter the target: ");
int target = int.Parse(Console.ReadLine());
int start = -1;
int end = -1;
for(int i = 0; i < n; i++){
   int sum = 0;
   for(int j = i; j < n; j++){
       sum += nums[j];
       if(sum == target){
           start = i;
           end = j;
           break;
       }
       if (sum > target) break;
       if (start != -1) break;
   }
}
Console.WriteLine($"[{start}, {end}]");