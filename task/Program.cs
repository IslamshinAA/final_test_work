string [] array = {"hello", "23", "yes", "war", "1234455"};
void Massiv (string [] arr)
{
    for (int i= 0; i < arr.Length; i++)
    {
        int count = arr[i].Count();
        if (count <= 3)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
Massiv(array);