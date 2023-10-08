namespace sortingArray;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = new int[] { 9, -5, 8, -1, 34, 0, 2, 1, -3, 1, -2, 0 };
        ArrayOutput(myArray);
        Console.Write("\n");

        int returnSumMethod = ReturnSumNegativeNums(myArray);
        Console.WriteLine($"Sum between first and second negative elements = {returnSumMethod}");

        Console.Write("\n");
        Console.WriteLine("***************************************\n");
        int[] compressedArray = ReturnCompressedArray(myArray);
        ArrayOutput(compressedArray);
        Console.ReadKey();
    }
    static void ArrayOutput(int[] anyArray)
    {
        foreach (var item in anyArray)
        {
            Console.Write(item + "\t");
        }
    }
    static int ReturnSumOddNum(int[] anyArray)
    {
        int sum = 0;
        for (int i = 0; i < anyArray.Length; i++)
        {
            if (i % 2 != 0) { sum += anyArray[i]; }
        }
        return sum;
    }

    // Сума елементів масиву між першим і останнім відєм елементами 
    static int ReturnSumNegativeNums(int[] anyArray)
    {
        int indexFN = -1;
        int indexLN = -1;

        for (int i = 0; i < anyArray.Length; i++)
        {
            if (anyArray[i] < 0)
            {
                indexFN = i;
                break;
            }
        }
        for (int i = anyArray.Length - 1; i > indexFN; i--)
        {
            if (anyArray[i] < 0)
            {
                indexLN = i;
                break;
            }
        }
        Console.WriteLine($"First negative element index = {indexFN}");
        Console.WriteLine($"Second negative element index = {indexLN}");

        Console.Write("\n\n");
        int sum = 0;
        if (indexFN != -1 && indexLN != -1)
        {
            for (int i = indexFN + 1; i < indexLN; i++)
            {
                sum += anyArray[i];
            }
        }
        else if (indexFN == -1 || indexLN == -1)
        {
            Console.WriteLine("There are less than 2 negative elements");
            sum = Convert.ToInt32(null);
        }

        return sum;
    }

    // Стиснення масиву 
    static int[] ReturnCompressedArray(int[] anyArray)
    {
        int[] compressedArray = new int[anyArray.Length];
        int compressedIndex = 0;
        for (int i = 0; i < anyArray.Length; i++)
        {
            if (Math.Abs(anyArray[i]) > 1)
            {
                compressedArray[compressedIndex] = anyArray[i];
                compressedIndex++;
            }
        }
        for (int i = compressedIndex; i < compressedArray.Length; i++)
        {
            compressedArray[i] = 0;
        }
        return compressedArray;
    }
}

