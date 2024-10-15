
Console.WriteLine("Task1");
Console.WriteLine();

Console.WriteLine("chacere texti");
String inptext = Console.ReadLine();
Console.WriteLine(inptext);
inptext = inptext.ToUpper();
Console.WriteLine(inptext);
int cnt = 0;

foreach (char c in inptext)
{
    if (c == 'A' || c == 'O' || c == 'I' || c == 'E' || c == 'U') cnt++;
}

Console.WriteLine(cnt);

//---------------------------------------------------

Console.WriteLine("--------------");
Console.WriteLine();
Console.WriteLine("Task2");


Console.WriteLine("Beetwin 1 to 10");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Multilication Table of: " + number);
string[] MultilicationTable = new string[10];


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Console " + number + " * " + (i + 1) + " = " + number * (i + 1));
    MultilicationTable[i] = number + " * " + (i + 1) + " = " + number * (i + 1);
    Console.WriteLine("Array   " + MultilicationTable[i]);
};



Console.WriteLine("--------------");


Console.WriteLine("Task3");

int[,] firstMtrx = new int[3, 3];
int[,] secondMtrx = new int[3, 3];
int[,] matrixSum = new int[3, 3];


//First Matrix Input

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("Element " + i + ":" + j + " ");
        firstMtrx[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("");


for (int i = 0; i < firstMtrx.GetLength(0); i++)
{
    for (int j = 0; j < firstMtrx.GetLength(1); j++)
    {
        Console.Write(firstMtrx[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("");

//Secod Matrix Input
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("Element " + i + ":" + j + " ");
        secondMtrx[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("");


for (int i = 0; i < secondMtrx.GetLength(0); i++)
{
    for (int j = 0; j < secondMtrx.GetLength(1); j++)
    {
        Console.Write(secondMtrx[i, j] + "\t");
    }
    Console.WriteLine();
}



Console.WriteLine("------------------------");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrixSum[i, j] = firstMtrx[i, j] + secondMtrx[i, j];
    }
}

Console.WriteLine("");
Console.WriteLine("Finatl Matrix");

for (int i = 0; i < matrixSum.GetLength(0); i++)
{
    for (int j = 0; j < matrixSum.GetLength(1); j++)
    {
        Console.Write(matrixSum[i, j] + "\t");
    }
    Console.WriteLine();
}



Console.WriteLine("");
Console.WriteLine("--------------");








Console.WriteLine("--------------");
Console.WriteLine();
Console.WriteLine("Task4");


Console.WriteLine("(1)Addition");
Console.WriteLine("(2)Subtraction");
Console.WriteLine("(3)Multiplication");
Console.WriteLine("(4)Division");
Console.WriteLine("(5)Exit");


int option = 0;

while (option != 5)
{

    Console.WriteLine("Choose an option:");
    option = Convert.ToInt32(Console.ReadLine());

    if (option == 5) break;

    Console.WriteLine("Enter first number:");
    int firstnum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second number:");
    int secnum = Convert.ToInt32(Console.ReadLine());

    decimal result;

    if (option == 1)
    {
        result = firstnum + secnum;
        Console.WriteLine("Result: " + result);
    }
    else if (option == 2)
    {
        result = firstnum - secnum;
        Console.WriteLine("Result: " + result);
    }
    else if (option == 3)
    {
        result = firstnum * secnum;
        Console.WriteLine("Result: " + result);
    }
    else if (option == 4 & secnum == 0)
    {
        Console.WriteLine("Divison on Zero! Try Again!");
    }
    else if (option == 4)
    {
        result = firstnum / secnum;
        Console.WriteLine("Result: " + result);
    }

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
};

Console.WriteLine("");
Console.WriteLine("By By!");



