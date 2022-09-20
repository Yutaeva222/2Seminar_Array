int CreateNumber() //задали тип переменной и название метода.
{
   int number = new Random().Next(100,1000); // создается рандомное число
   return number; // возвращается число 
}
int MaxDigit(int number) // метод нахождения максим цифры из числа.
{
    int Sot = number / 100;
    int Decimal = number / 10;  // находим сколько десятков в числе
    int Ed = number % 10; // нашли остаток после деления на 10.
    return Sot * 10 + Ed; // возвращаем в результат десяток
}


int a = CreateNumber(); // положили результат метода в переменную а.
Console.WriteLine(a); // вывод самого числа
int maxDigit = MaxDigit(a); // в переменную максдигит положили результат метода - тот что с большой буквы.
Console.WriteLine(maxDigit);
