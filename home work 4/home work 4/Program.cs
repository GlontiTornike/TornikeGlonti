//task2


char[] arrayOfChars = BuildArray();

char[] BuildArray()
{

    Console.Write("Enter the size of the array: ");
    int size = int.Parse(Console.ReadLine());

    char[] charArr = new char[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter a Symbol: ");
        charArr[i] = Console.ReadLine()[0];
    }


    return charArr;
}




Console.Write("Array of Symbols:");

int index = 0;
foreach (char c in arrayOfChars)
{
    index++;
    if (index == arrayOfChars.Length)
    {
        Console.WriteLine(c + " ");
    }
    else
    {
        Console.Write(c + " ");
    }
}

Console.Write("Enter symbol to count:");

char symbolToCount = Console.ReadLine()[0];

int count = CountSpecificSymbol(arrayOfChars, symbolToCount);

Console.WriteLine(symbolToCount + " Shegvxvda " + count + "-jer");

int CountSpecificSymbol(char[] array, char symbol)
{
    int count = 0;

    foreach (char c in array)
    {
        if (c == symbol)
        {
            count++;
        }
    }

    return count;
}

//task1

//int[] arr = { 123, 234, 345 };
//int index = int.Parse(Console.ReadLine());

//if (sumDigits(arr, index)==-1)
//{
//Console.WriteLine("Invalid Input");
//}
//else
//{
//Console.WriteLine(sumDigits(arr,index));
//}

//int sumDigits(int[] arr, int index)
//{
//    if (index <=arr.Length && index >= 0)
//    {
//        int num = arr[index];
//        int count = 0;

//        for (int i = 0; i < arr.Length; i++)
//        {
//            count += num %10;
//            num/=10;
//        }
//        return count;

//    }
//    else
//    {
//        return -1;
//    }
//}



