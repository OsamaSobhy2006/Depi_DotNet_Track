Console.WriteLine("Enter the sudoku board: ");
char[,] board = new char[9, 9];
for(int i = 0; i < 9; i++){
   string row = Console.ReadLine();
   for(int j = 0; j < 9; j++){
       board[i, j] = row[j];
   }
}
bool isValid = true;
for(int i = 0; i < 9; i++){
   for(int j = 0;j < 9; j++){
       if (board[i, j] == '.') continue;

       char current = board[i, j];

       // check rows
       for(int k = 0;  k < 9; k++){
           if(k != j && board[i, k] == current){
               isValid = false;
               break;
           }
       }

       // check columns
       for(int k = 0; k < 9; k++){
           if(k != i && board[k, j] == current){
               isValid = false;
               break;
           }
       }

       // check 3 * 3 boxes
       int startRow = (i / 3) * 3;
       int startCol = (j / 3) * 3;
       for(int r = startRow; r < startRow + 3; r++){
           for(int c = startCol;  c < startCol + 3; c++){
               if((r != i || c != j) && board[r, c] == current){
                   isValid=false; 
                   break;
               }
           }
           if (!isValid) break;
       }
       if(!isValid) break;
   }
   if (!isValid) break;
}
Console.WriteLine(isValid);