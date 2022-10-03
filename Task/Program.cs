string[] CreateStringArray()
{
again:
    Console.Write("Input size of array: ");
    string sizeStr = Console.ReadLine();
    if (sizeStr.All(char.IsDigit))
    {
        int size = Convert.ToInt32(sizeStr);
        if (size > 0)
        {
            string[] arr = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Input {i + 1} element of array: ");
                arr[i] = Console.ReadLine();
            }
            return arr;
        }
        else
        {
            Console.WriteLine("Input integer more than zero. Try again");
            goto again;
        }
    }
    else
    {
        Console.WriteLine("Input integer for size of array. Try again");
        goto again;
    }
}

string[] CreateArrayOfNLength(string[] arr, int n)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length < n + 1)
            count++;

    string[] resultArray = new string[count];

    for (int i = 0, j = 0; i < arr.Length; i++)
        if (arr[i].Length < n + 1)
        {
            resultArray[j] = arr[i];
            j++;
        }
    return resultArray;
}

void StringArrayOutput(string[] arr, string delimetr)
{
    Console.Write("Your result array: ");
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + delimetr);
}

string[] array = CreateArrayOfNLength(CreateStringArray(), 3);

if (array.Length != 0)
    StringArrayOutput(array, " ");
else Console.WriteLine("Array is empty.");

