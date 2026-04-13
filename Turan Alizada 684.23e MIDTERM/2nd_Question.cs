// Second Question : 

Console.WriteLine("Enter the student score : ");
int score = Convert.ToInt32(Console.ReadLine());

if (score < 0 || score > 100)
{
    Console.WriteLine("Invalid Score, score can be inbetween 0-100");
} 
else
{
    string message = score >= 85 ? "Distinction" : score >= 70 ? "Merit" : score >= 50 ? "Pass" : "Fail";
    Console.WriteLine(message);
}