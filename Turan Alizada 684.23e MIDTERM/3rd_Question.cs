// Third Question : 

Console.WriteLine("How many numbers do you want? : ");
int totalNumbers = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[totalNumbers];
Console.WriteLine("Inputting the Numbers into the array...");
for (int i = 0; i<totalNumbers; i++)
{
    Console.WriteLine("Enter a number : ");
    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num; 
}

Console.WriteLine("Printing only the unique elements :");
bool isUnique = true;
for (int i = 0; i<totalNumbers; i++)
{
    for (int j = 0; j<totalNumbers; j++)
    {
        if ((arr[i] == arr[j]) && (i != j))
        {
            isUnique = false;
        }
    }
    if (isUnique)
    {
        Console.Write(arr[i] + " ");
    }
    isUnique = true;
}
Console.WriteLine();