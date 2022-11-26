void S (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        Console.Write (array[i] + " ");
    }
 Console.WriteLine (" ");
}
string [] array = {"123", "231", "hello","world", "32333", "333"};
S (array);