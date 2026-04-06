Console.WriteLine("How many users do you want?");
int numberOfUsers = int.Parse(Console.ReadLine());

string[] names = new string[numberOfUsers];

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Enter username:");
    names[i] = Console.ReadLine();
}

Console.WriteLine("Users : ");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"User{i} : {names[i]}");
}