Console.Write("Etner the String: ");
string s = Console.ReadLine();
string c = "";
int count = 1;
for(int i = 0; i < s.Length; i++){
   if(i + 1 < s.Length && s[i] == s[i + 1])
       count++;
   else{
       c += s[i] + count.ToString();
       count = 1;
   }
}
if(c.Length < s.Length) Console.WriteLine(c);
else Console.WriteLine(s);