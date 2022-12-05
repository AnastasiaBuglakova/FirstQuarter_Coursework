string[] FilterArray(string[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <4) n++;  
    }
    string[] newArray = new string[n];
    int j = 0;
    for(int i = 0;  i < n; i ++)
    {
        
        if(array[i].Length <4) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] InputArray()
{
    Console.WriteLine("Please, enter size of array:");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] customArray = new string[n];
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine("Please, item # " + i + " of array:");
        customArray[i] = Console.ReadLine();
    }
    return customArray;
}

void ShowArray(string[] array)
{
    if(array.Length == 0)Console.WriteLine("[]");
    else
    {
        Console.Write("[");
        for(int i = 0; i< array.Length; i++)
            {
            Console.Write($"\"{array[i]}\"");
            if(i>=0 && i< array.Length - 1) Console.Write(", ");
            }   
        Console.Write("]");
    }
}

string[] custArray = InputArray();
ShowArray(custArray);
Console.WriteLine();

string[] newArray = FilterArray(custArray);
ShowArray(newArray);
