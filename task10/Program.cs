System.Console.WriteLine("Введите число");
string a = Console.ReadLine();
int a1 = int.Parse(a);

int second = a1 / 10 % 10;

System.Console.WriteLine($"Вторая цифра числа {a} - это {second}.");