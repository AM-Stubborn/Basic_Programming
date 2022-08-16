//Given an array of positive integers and a number ‘S,’ find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’. Return 0 if no such subarray exists.

Console.WriteLine("------------------------------ Welcome to Am_Stubborn Coding-----------------------------");
Console.WriteLine("----------- Smallest Subarray With a Greater Sum (easy) --------------");
Console.WriteLine("Please enter the Size of Array");
int sizeOfArray = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter element in array");

int[] arrayOfNumbers = new int[sizeOfArray];
//int[] arrayOfNumbers = new int[] { 3, 4, 1, 1, 6 };
for (int i = 0; i < sizeOfArray; i++)
{
    arrayOfNumbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Please Enter the Number");
int numberToCheck = int.Parse(Console.ReadLine());
int maxNumber = 0;
int sizeOfSumArray = 1;
bool IsArrayFound = false;

for(int i= 0; i< sizeOfArray; i++)
{
    for(int j = 0; j < sizeOfArray; j++)
    {
        maxNumber += arrayOfNumbers[j];
        if (j >=i)
        {
            if (maxNumber >= numberToCheck)
            {
                sizeOfSumArray = i + 1;
                IsArrayFound = true;
                break;
            }
            maxNumber -= arrayOfNumbers[j-i];
        }
    }
    if (IsArrayFound) break;

}
Console.WriteLine("Minimum Array Size is :" + sizeOfSumArray);