// First Question : 

int totalNumbers = 3;
int[] arr = new int[3];

for (int i = 0; i<totalNumbers; i++)
{
    Console.WriteLine("Enter the Number : ");
    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num;
}

Console.WriteLine("Finding the largest number among them with the help of the Math Operator...");
int largestAmongFirstTwo = Math.Max(arr[0], arr[1]);
int max = Math.Max(largestAmongFirstTwo, arr[2]);
Console.WriteLine("The Largest Number : " + max);