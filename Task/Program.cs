string [] arr = new string [6] {"yes", "ni", "754", "nene", "qwerty", "done" };
string [] arr2 = new string [arr.Length];
void FillArr (string[] arr)
{
    int j=0;
    for (int i=0; i<arr.Length; i++)
    {
        //int j=0;
        if (arr[i].Length<=3)
        {
            arr2[j] = arr[i];
            j++;
        }
    }

}

void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
FillArr(arr);
PrintArr(arr2);