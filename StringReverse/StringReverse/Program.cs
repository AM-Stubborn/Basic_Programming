

Console.WriteLine("-----------------------------String Reverse Program-------------------------------");
Console.WriteLine("Please Enter a string");
string word= Console.ReadLine();
char character=Convert.ToChar(Console.ReadLine());
if (String.IsNullOrEmpty(word))
{
    Console.WriteLine("Please enter a non empty String");
}
else
{
    
    char[] chars = word.ToCharArray();
    char[] charsreverse = new char[chars.Length];
    Dictionary<char, int> charcount = new Dictionary<char, int>();

    for (int i = 0; i <chars.Length; i++)
    {
        charsreverse[i] = chars[chars.Length - i-1];
        if (charcount.ContainsKey(chars[i]))
        {
            charcount[chars[i]]++;
        }
        else
        {
            charcount.Add(chars[i], 1);
        }
    }
    var result = String.Concat(charsreverse);
    var result2 = String.Join("",charsreverse);


    Console.WriteLine(result);
    Console.WriteLine(result2);

    if (result == word)
    {
        Console.WriteLine("Given String is palindrom");
    }

    int occurance = charcount[character];

    Console.WriteLine("Total occurance of word =" + occurance);

}


