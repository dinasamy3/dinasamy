
class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());

        int[] array1 = ReadArray(size, "first");
        int[] array2 = ReadArray(size, "second");

        int[] mergedArray = MergeSortedArrays(array1, array2);

        Console.WriteLine("Merged sorted array: " + string.Join(" ", mergedArray));
    }

    static int[] ReadArray(int size, string arrayName)
    {
        int[] array = new int[size];
        Console.WriteLine($"Enter elements for the {arrayName} array (sorted):");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            result[k++] = arr1[i] <= arr2[j] ? arr1[i++] : arr2[j++];
        }

        while (i < arr1.Length) result[k++] = arr1[i++];
        while (j < arr2.Length) result[k++] = arr2[j++];

        return result;
    }
}
