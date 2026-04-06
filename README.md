### Check .NET version : 

`dotnet --version`

### Run .cs file : 

`dotnet filename.cs`

## Explicit version : 

`dotnet run --file filename.cs`

### Create a new .NET project : 

`dotnet new console -n projectname`

### Run .NET : 

`cd projectname`
`dotnet run`

### In Linux : 

`#!/usr/bin/env dotnet`
`Console.WriteLine("Example Code");`

## Run :

`chmod +x filename.cs`
`./filenme.cs`

### C# File Structure : 

# Main Class :

`using System;`
` `
`public class Program {`
`    public static void Main(string[] args) {`
`        // Code`
`    }`
`}`

# - *Main Class name has to be "Program"*
# - *Main method name must be capitalized*

# - You *can* omit arguments :

`public static void Main()`

# - Another version : 

`public static void Main(String[] args)`

# Interpreter :

`Console.WriteLine("Example Code")';`