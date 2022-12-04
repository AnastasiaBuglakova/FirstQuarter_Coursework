string[] FilterArray(string[] array)
{

}



string[] InputArray(int N)
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
