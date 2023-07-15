//Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру этого числа. 
//456 -> 46 
//782 -> 72 
//918 -> 98

int GetRandomNumber()
{
 int number = new Random().Next(100,1000); 
  return number;
}

int GetFirstDigit(int number1)
{
        return number1/100;
}

int GetThirdDigit(int number3)
{
    return number3 % 10;
}

int random = GetRandomNumber();
int firstDigit = GetFirstDigit(random);
int thirdDigit = GetThirdDigit(random);


Console.WriteLine(random);
Console.WriteLine(thirdDigit);
Console.WriteLine(firstDigit);
//void PrintNumber(int num1)
//{
//Console.Write(num1 + " ");
//}

//void ShowLargestDigit(int digit1, int digit2)
//{
//    if (digit1 > digit2)
//    {
//        Console.WriteLine("->" + digit1);
//    }
//    else Console.Write("->" + digit2);
//}


//int num = GetRandomNumber();
//PrintNumber(num);
//int firstDigit = GetFirstDigit(num);
//PrintNumber(firstDigit);   не нужно так как дополнили "->"
// Console.WriteLine(firstDigit); не нужно, так как создали метод PrintNumber
// int lastDigit = GetLastDigit(num);
//PrintNumber(lastDigit);
//ShowLargestDigit(firstDigit, lastDigit);