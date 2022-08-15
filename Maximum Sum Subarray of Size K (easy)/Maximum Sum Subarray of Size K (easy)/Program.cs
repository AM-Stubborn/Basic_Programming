Console.WriteLine("------------------------------ Welcome to Am_Stubborn Coding-----------------------------");
Console.WriteLine("----------- Maximum Sum Subarray of Size K (easy) --------------");
Console.WriteLine("Please enter the Size of Array");
int sizeOfArray = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter element in array");

//int[] arrayOfNumbers = new int[sizeOfArray];
int[] arrayOfNumbers = new int[] { 2, 3, 4, 1, 5 };
//for (int i = 0; i < sizeOfArray; i++)
//{
//    arrayOfNumbers[i] = int.Parse(Console.ReadLine());
//}
Console.WriteLine("Please Enter the size of contuinous sub Array");
int sizeofSubArray = int.Parse(Console.ReadLine());
int maxSumOfSubArray = 0;
int sumOfSubArray = 0;


//------- Brute Force solution Begin

for (int i = 0; i < sizeOfArray; i++)
{
    sumOfSubArray = 0;
    for(int j = i; j < i+sizeofSubArray; j++)
    {
        sumOfSubArray+= arrayOfNumbers[j];
    }
    if (maxSumOfSubArray < sumOfSubArray)
    {
        maxSumOfSubArray = sumOfSubArray;
    }

    if (i + sizeofSubArray + 1 == sizeOfArray)
    {
        break;
    }
}

Console.WriteLine("Maximum Sum of Subarray of Size " + sizeofSubArray + " is " + maxSumOfSubArray);


//------- Brute Force solution End

//--------sliding Window Approach ]
sumOfSubArray = 0;
maxSumOfSubArray = 0;
for (int i = 0; i < sizeOfArray; i++)
{
    sumOfSubArray += arrayOfNumbers[i] ;

    if (i + 1 >= sizeofSubArray)
    {
        if (maxSumOfSubArray < sumOfSubArray)
        {
            maxSumOfSubArray = sumOfSubArray;
        }
        sumOfSubArray-=arrayOfNumbers[i+1-sizeofSubArray];
    }
    
}

Console.WriteLine("Sliding Window Approach : Maximum Sum of Subarray of Size " + sizeofSubArray + " is " + maxSumOfSubArray);