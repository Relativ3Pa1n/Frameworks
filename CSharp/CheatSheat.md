# C# - New Project in VS Code with Git Bash in 5 lines
How our console and directory will look after this. 
![](https://i.imgur.com/KLc9Yp3.png) ![](https://i.imgur.com/2vpX7f0.png)




```d
//# Line by line, this builds a C# skeleton that VSCode will repair and give us a basic console and debugger. Credit to @IAmTimCorey 
dotnet new sln -n "NameOfSolution"
dotnet new console -n "NameOfConsole"
dotnet new classlib -n "NameOfClassLibrary"
dotnet sln NameOfSolution.sln add **/*.csproj
dotnet add NameOfConsole/NameOfConsole.csproj reference NameOfClassLibrary/NameOfClassLibrary.csproj
cd NameOfConsole; Code .
```

The last line should open Code in the NameOfConsole application directory. We used the console template. ``dotnet new --list`` will list more templates options.

Once Code is open, it will ask to add debugging and do some general repairs for itself. 

![](https://i.imgur.com/fEZvlgT.png)

Exit Code and go back to the command line. If you are still in the same directory, just ``cd ..`` and run `` code .`` again to repair the parent folder of the console application. 
![](https://i.imgur.com/6nb9gcE.png)

Agree to the prompt again.

![](https://i.imgur.com/cPaSEL0.png)

# Debugging

We have debugging inside Code, and we have our Template built.  ``dotnet run`` on the command line will run the program.

![](https://i.imgur.com/38BY2KD.png)

# F5 
Will run the application in Code. 

We can put breakpoints anywhere we would like in the files and step through execution. The debugger also has seperate windows for more information.

![](https://i.imgur.com/WkF28Az.png)

