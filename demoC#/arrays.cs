// Console.WriteLine("How many users do you want?");
// int numberOfUsers = int.Parse(Console.ReadLine());

// string[] names = new string[numberOfUsers];

// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine("Enter username:");
//     names[i] = Console.ReadLine();
// }

// Console.WriteLine("Users : ");
// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine($"User{i} : {names[i]}");
// }

int[] arr = {1, 2, 3};
int[] arr2 = new int[arr.Length];
arr.CopyTo(arr2);

arr[0] = 2;
Console.WriteLine(arr2[0]);