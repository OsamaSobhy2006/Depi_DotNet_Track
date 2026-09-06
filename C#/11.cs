Console.Write("Enter the size or Array: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
for(int i = 0; i < n; i++){
   for (int j = 0; j < n; j++)
   {
       matrix[i, j] = int.Parse(Console.ReadLine());
   }
}
// transpose the matrix
for(int i = 0; i < n; i++){
   for(int j = i + 1; j < n; j++){
       int temp = matrix[i, j];
       matrix[i, j] = matrix[j, i];
       matrix[j, i] = temp;
   }
}
// reverse the matrix after get the transpose to arrive to final asnwer
for(int i = 0; i < n; i++){
   int left = 0;
   int right = n - 1;
   while(left < right){
       int temp = matrix[i, left];
       matrix[i, left] = matrix[i, right];
       matrix[i, right] = temp;
       left++;
       right--;
   }
}
for(int i = 0; i < n; i++){
   for(int j = 0; j < n; j++){
       Console.Write(matrix[i, j] + " ");
   }
   Console.WriteLine();
}