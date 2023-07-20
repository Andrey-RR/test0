// Напишите программу, которая по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти (x и y)

int Coordinata(string message) // пишем передаваемое сообщение - запрашиваем у пользователя число
{
    Console.WriteLine(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}


void FindQuarter(int a) // отправляем возможные координаты и выводим сообщением

{
    if (a < 1 || a > 4 )
        Console.WriteLine("неверный формат данных");
    if (a == 1)
        Console.WriteLine("X = (0; +n), Y = (0; +n)");

    if (a == 2)
        Console.WriteLine("X = (0; -n), Y = (0; +n)");

    if (a == 3)
        Console.WriteLine("X = (0; -n), Y = (0; -n)");

    if (a == 4)
        Console.WriteLine("X = (0; +n), Y = (0; -n)");
}

int quarter = Coordinata("Введите номер четвверти: ");
FindQuarter(quarter);

