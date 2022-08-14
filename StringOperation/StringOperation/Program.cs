
Console.WriteLine("------------------------------ Welcome to Am_Stubborn Coding-----------------------------");
Console.WriteLine("----------- The number of vowels and consonants in a String--------------");
Console.WriteLine("Enter Your input");
string userInput = "";
userInput=Console.ReadLine();
Dictionary<string, int> Count = new Dictionary<string, int>();

Count.Add("vowels", 0);
Count.Add("consonants", 0);

if (String.IsNullOrWhiteSpace(userInput))
{
    Console.WriteLine("Entered input is empty");
}
else
{
   foreach(var character in userInput.ToLower())
    {
        if (character == 'a'|| character == 'e'|| character == 'i'|| character == 'o'|| character == 'u')
        {
            Count["vowels"]++;
        }
        else
        {
            Count["consonants"]++;
        }
    }

    Console.WriteLine("Total number of vowels in User input =" + Count["vowels"]);
    Console.WriteLine("Total number of consonants in User input =" + Count["consonants"]);

}