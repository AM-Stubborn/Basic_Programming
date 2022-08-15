
/*

Given an array, find the average of all subarrays of ‘K’ contiguous elements in it.

Let’s understand this problem with a real input:

Array: [1, 3, 2, 6, -1, 4, 1, 8, 2], K = 5
Here, we are asked to find the average of all subarrays of ‘5’ contiguous elements in the given array. Let’s solve this:

For the first 5 numbers (subarray from index 0-4), the average is: (1 + 3 + 2 + 6 - 1) / 5 => 2.2
(1 + 3 + 2 + 6−1) / 5=>2.2
The average of next 5 numbers (subarray from index 1-5) is: (3 + 2 + 6 - 1 + 4) / 5 => 2.8
(3 + 2 + 6−1 + 4) / 5=>2.8
For the next 5 numbers (subarray from index 2-6), the average is: (2 + 6 - 1 + 4 + 1) / 5 => 2.4
(2 + 6−1 + 4 + 1) / 5=>2.4

…
Here is the final output containing the averages of all subarrays of size 5:

Output: [2.2, 2.8, 2.4, 3.6, 2.8]

*/

Console.WriteLine("------------------------------ Welcome to Am_Stubborn Coding-----------------------------");
Console.WriteLine("-----------  find the average of all subarrays of ‘K’ --------------");
Console.WriteLine("Please enter the Size of Array");
int sizeOfArray = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter element in array");

int[] arrayOfNumbers = new int[sizeOfArray];
for (int i = 0; i < sizeOfArray; i++)
{
    arrayOfNumbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Please Enter the size of contuinous sub Array");
int sizeofSubArray= int.Parse(Console.ReadLine());


//------- Brute Force solution Begin
Console.WriteLine("------ Brute Force solution Begin");
decimal[] avgOfSubArray = new decimal[sizeofSubArray];
int avg=0;

for (int i = 0; i < sizeOfArray; i++)
{
    for(int j=i; j < i + sizeofSubArray; j++)
    {
        avg += arrayOfNumbers[j];
    }
    avgOfSubArray[i]= Decimal.Divide(avg, sizeofSubArray);
    if (i == sizeofSubArray-1) { break; }
    avg = 0;
}

foreach (var item in avgOfSubArray) {
    Console.WriteLine(item);
        }



//------- Brute Force solution End

//-------- Slideing Window approach
Console.WriteLine("-------- Slideing Window approach");
avg = 0;
for(int i =0; i < sizeOfArray; i++)
{
    
        avg += arrayOfNumbers[i];

    if (i >= sizeofSubArray-1)
    {
        avgOfSubArray[i+1-sizeofSubArray] = Decimal.Divide(avg, sizeofSubArray);
        avg -= arrayOfNumbers[i+1-sizeofSubArray];
    }
       

}

foreach (var item in avgOfSubArray)
{
    Console.WriteLine(item);
}