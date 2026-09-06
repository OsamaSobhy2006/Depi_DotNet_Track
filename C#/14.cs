Console.Write("Etner the first string: ");
string s = Console.ReadLine();

Console.Write("Etner the second string: ");
string t = Console.ReadLine();

if(s.Length != t.Length) Console.WriteLine(false);
else{
   int[] freq = new int[26];

   for (int i = 0; i < s.Length; i++)
       freq[s[i] - 'a']++;

   for (int i = 0; i < t.Length; i++)
       freq[t[i] - 'a']--;

   bool isAnagram = true;
   for(int i = 0; i< freq.Length; i++){
       if (freq[i] != 0){
           isAnagram = false;
           break;
       }
   }
   Console.WriteLine(isAnagram);
}
