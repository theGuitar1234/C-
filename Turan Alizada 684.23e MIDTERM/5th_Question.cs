// Fifth Question : 

string myName = "Turan";
char firstLetterOfMyName = myName[0];
Console.WriteLine("My Name : " + myName + " The first letter of my name : " + firstLetterOfMyName + "\n");

int width = 12;
int height = width / 2;
int padding = width / 2 - 1;
string space = " ";
string symbol = "*";

/*
    My Name is Turan, so the first letter is "T"
    I Need to print 2 lines -> first Horizontal, the other vertical
    The first for loop draws the horizontal line and the other draws the vertical line
*/

Console.WriteLine("Asteriks Representation : \n");

// First For Loop
for (int j = 0; j<width; j++)
{
    Console.Write(symbol);
}

// Second For Loop
for (int i = 0; i<height; i++)
{
    Console.WriteLine();
    for (int k = 0; k<padding; k++)
    {
        Console.Write(space);
    }
    Console.Write(symbol);
    for (int k = 0; k<padding; k++)
    {
        Console.Write(space);
    }
}