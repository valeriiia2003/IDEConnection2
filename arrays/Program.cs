namespace arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = new int[] { -24, 0, -7, 0, 2, 34, 23, -11, 9, 5, 0, 2 };
        int returnSum = ReturnSumOfModules(myArray);

        Console.WriteLine($"Sum of the elements = {returnSum}");


        Console.WriteLine("******************\n");
        int[] compressedArray = ReturnCompressedArray(myArray);
        foreach (var item in compressedArray)
        {
            Console.Write(item + "\t");
        }
        Console.ReadKey();
    }
    static int ReturnProduct(int[] anyArray)
    {
        int product = 1;
        for (int i = 0; i < anyArray.Length; i++)
        {
            if (i % 2 == 0) { product = product * anyArray[i]; }
        }
        return product;
    }
    // Сума елементов массива, между первым и вторым нулевыми элементами
    static int ReturnSumOfModules(int[] anyArray)
    {
        int sum = 0;
        int firstZeroElement = anyArray[0];
        int indexFirstZeroE = 0;

        int secondZeroElement = anyArray[1];
        int indexSecondZeroE = 1;

        for (int i = 0; i < anyArray.Length; i++)
        {
            if (anyArray[i] == 0)
            {
                firstZeroElement = anyArray[i];
                indexFirstZeroE = i;
                break;
            }
        }

        int zeroIndex = 0;
        for (int i = 0; i < anyArray.Length; i++)
        {
            if (anyArray[i] == 0)
            {
                zeroIndex++;
                if (zeroIndex == 2)
                {
                    secondZeroElement = anyArray[i];
                    indexSecondZeroE = i;
                    break;
                }
            }
        }

        Console.WriteLine($"First zero element = {firstZeroElement}, index = {indexFirstZeroE}");
        Console.WriteLine($"Second zere element = {secondZeroElement}, index = {indexSecondZeroE}");
        Console.Write("\n");
        for (int i = indexFirstZeroE + 1; i < indexSecondZeroE; i++)
        {
            Console.Write(anyArray[i] + "\t");
            sum += anyArray[i];
        }
        Console.Write("\n");
        return sum;
    }

    // Перетворення масиву 
    static int[] ReturnCompressedArray(int[] anyArray)
    {
        int[] compressedArray = new int[anyArray.Length];
        int compressedIndex = 0;
        for (int i = 0; i < anyArray.Length; i++)
        {
            if (anyArray[i] >= 0)
            {
                compressedArray[compressedIndex] = anyArray[i];
                compressedIndex++;
            }
        }

        for (int i = 0; i < anyArray.Length; i++)
        {
            if (anyArray[i] < 0)
            {
                compressedArray[compressedIndex] = anyArray[i];
                compressedIndex++;
            }

        }
        return compressedArray;
    }
}

