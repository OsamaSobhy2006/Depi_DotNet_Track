Console.Write("Enter the String: ");
string s = Console.ReadLine();
string reversed = "";
int vowelCount = 0;

for (int i = s.Length - 1; i >= 0; i--)
   reversed += s[i];

for (int i = 0; i < s.Length; i++){
   char c = char.ToLower(s[i]);

   if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
       vowelCount++;
}

Console.WriteLine($"Reversed: {reversed}");
Console.WriteLine($"Vowel Count: {vowelCount}");