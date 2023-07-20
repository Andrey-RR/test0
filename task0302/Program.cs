// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве. 
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Coordinata (message)
{
    Console.WriteLine(message + " ");
    int num = int.Parse(Console.ReadLine());
    return num; 
}

int x1 = Coordinata("Введите x координату точки 1");
int y1 = Coordinata("Введите y координату точки 1");
int x2 = Coordinata("Введите x координату точки 2");
int y2 = Coordinata("Введите y координату точки 1");