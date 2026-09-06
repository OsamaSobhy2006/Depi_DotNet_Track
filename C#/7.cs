Console.Write("Enter Size of Array: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
for(int i = 0; i < n; i++){
   for(int j = 0; j < n; j++){
       matrix[i, j] = int.Parse(Console.ReadLine());
   }
}
int sum = 0;

for(int i = 0; i < n; i++){
   for (int j = 0; j < n; j++) {
       if (j == i || j == n - 1 - i)
           sum+= matrix[i, j];
   }
}
Console.WriteLine($"Sum: {sum}");