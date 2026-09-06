Console.Write("Enter the Sentence to check if it's a Palindrome: ");
string s = Console.ReadLine();
string clean = "";

for(int i = 0; i < s.Length; i++){
   if (char.IsLetterOrDigit(s[i]))
       clean += char.ToLower(s[i]);
}
bool isPalin = true;
for(int i = 0; i < clean.Length; i++){
   if (clean[i] != clean[clean.Length - 1 - i]){
       isPalin = false;
       break;
   }
}
Console.WriteLine(isPalin);