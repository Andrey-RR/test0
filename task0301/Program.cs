// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//  в которой находится эта точка.

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int x = Prompt("Введите точку X: ");
int y = Prompt("Введите точку Y: ");
if(x!=0 && y!=0){
GetResult(x, y);
}
else{
    Console.WriteLine("Неверный формат ДАННЫХ");
}


void GetResult(int X, int Y)
{
if (X>0 && Y>0 )
{
    Console.WriteLine("I четверть");
}

if (X<0 && Y>0 )
{
    Console.WriteLine("II четверть");
}

if (X<0 && Y<0 )
{
    Console.WriteLine("III четверть");
}

if (X>0 && Y<0 )
{
    Console.WriteLine("IV четверть");
}
}