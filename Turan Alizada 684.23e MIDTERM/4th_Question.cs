// Fourth Question : 

int octalNumber = 254;
string octalString = Convert.ToString(octalNumber);

int decimalNumber = Convert.ToInt32(octalString, 8);
Console.WriteLine("254 in Octal is " + decimalNumber + " in Decimal");