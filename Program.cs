string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "Russia", "Denmark", "Kazan" };
string[] newArray = new string[array.Length];

void NewArray(string[] array, string[] newArray)
{
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(newArray[j] = array[i] + " ");
            j++;
        }
    }
}

NewArray(array, newArray);