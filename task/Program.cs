string [] array = {"hello", ":)", "yes", "not", "1234455"};
int count = 0;
    for (int i= 0; i < array.Length; i++)
     if (array[i].Length <= 3)
        {  
            count++;
        }

string [] newarr = new string [count];
    for(int i= 0, j = 0; i < array.Length; i++)
        {   
            if (array[i].Length <= 3)
            {
                newarr[j] = array[i];
                j++;
            }
           
        }
        Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", newarr)}]");
