Console.Write("Enter the String: ");
string s = Console.ReadLine();
int maxLength = 0;
for(int i = 0; i < s.Length; i++){
   string current = "";
   for(int j = i; j < s.Length; j++){
       if (current.Contains(s[j])) break;

       current += s[j];

       if(current.Length > maxLength) maxLength = current.Length;
   }
}
Console.WriteLine(maxLength);