string [] array = new string[5] {"Hello","55", "2", "54", "Print"};
string [] second_array = new string[array.Length];

void NewArrayLess4Char(string[] array, string[] array2)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArrayLess4Char(array, second_array);
PrintArray(second_array);

