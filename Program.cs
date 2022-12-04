
string[] FilterArray(string[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) n++;  
    }
    Console.WriteLine(n);
    string[] newArray = new string[n];
    for(int i = 0;  i < n; i ++)
    {
        int j = 0;
        if(array[i].Length <= 3) 
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
    int N = Convert.ToInt32(Console.ReadLine());
    string[] customArray = new string[N];
    for(int i = 0; i < N; i++)
    {
        Console.WriteLine("Please, item # " + i + " of array:");
        customArray[i] = Console.ReadLine();
    }
    return customArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
}

string[] custArray = InputArray();
ShowArray(custArray);
string[] newArray = FilterArray(custArray);
Console.WriteLine();
ShowArray(newArray);
