string [] array = {"hello", ":)", "yes", "not", "1234455"};
void Massiv (string [] arr)
{
    Console.Write("[");
    for (int i= 0; i < arr.Length; i++)
    {
        int count = arr[i].Count();
        if (count <= 3)
        {   
            Console.Write($" \"{arr[i]}\" ");
        }  
    }
    Console.Write("]");
}
Massiv(array);