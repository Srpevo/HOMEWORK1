//#1

DateTime CurrentTime = DateTime.Now;

Console.WriteLine("Hima jamy [{0}]e", CurrentTime.Hour);

//#2

//1-in dzevy

for (int i = 100; i > 0; i--)
{
    Console.Write("{0} ", i);
}

Console.WriteLine();

//2-rd dzevy

int Num = 100;

for (int i = 0; i < 100; i++)
{
    Console.Write("{0} ", Num);
    Num--;
}

Console.WriteLine();

//3-rd dzevy

Num = 100;

while(Num > 0)
{
    Console.Write("{0} ", Num);
    Num--;
}

Console.WriteLine();

//#3

string UserName = "";
string option = "";
int UserAge = 0;
bool log = false;


Console.WriteLine("------------------------------");
Console.WriteLine("Cragric Ogtveluc Araj Grancveq");
Console.WriteLine();
Console.WriteLine("    [0] exit  [any] continue");
Console.WriteLine();

do
{
    option = Console.ReadLine();

    if (option == "0"){
        break;
    }
    
    Console.Write("User Name: ");
    UserName = Console.ReadLine();
    Console.Write("Age: ");
    UserAge = Int32.Parse(Console.ReadLine());
    Console.WriteLine();

    
    if (UserAge >= 18)
    {
        Console.WriteLine($"Bari galust {UserName}, duq nsheciq vor dzer tariqy {UserAge}e");
        log = true;
    }
    else
    {
        Console.WriteLine($"{UserName}, Dzer tariqy chi hamapatasxanum");
        Console.WriteLine();
    }
}
while (!log);

