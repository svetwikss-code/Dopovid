using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

/*
 * ДОПОВІДЬ: Вбудовані типи даних, арифметичні та логічні операції, умовні конструкції в C#
 *
 * 1. Вбудовані типи даних:
 *    - Цілі зі знаком і без: sbyte/byte (1 байт), short/ushort (2 байти), int/uint (4 байти), long/ulong (8 байт).
 *    - Дробові: float (4 байти, суфікс F), double (8 байт), decimal (16 байт, суфікс M — для точних розрахунків).
 *    - Текстові та логічні: char (2 байти, один символ у ' '), string (рядок у " "), bool (1 байт: true/false), object (базовий тип).
 *
 * 2. Арифметичні та складені операції:
 *    - Базові: +, -, *, /, % (остача від ділення), ++ (інкремент), -- (декремент).
 *    - Скорочене присвоєння: +=, -=, *=, /= (наприклад, a += b означає a = a + b).
 *
 * 3. Оператори порівняння, логічні та умови:
 *    - Порівняння: ==, !=, >, <, >=, <=.
 *    - Логічні: && (І — істинно, коли обидві умови істинні), || (АБО — істинно, коли хоча б одна умова істинна).
 *    - Розгалуження: if / else if / else, switch - case.
 */

// Приклад коду
short shortNum = 78;
ushort ushortNum = 34;
int intNum = 2;
sbyte sbyteNum = -4;
float floatNum = 23.6F;
double doubleNum = 45.7;
decimal decimalNum = 34.8M;
char symbol = 'o';
bool isReady = true;

intNum += shortNum; // скорочене присвоєння: 2 + 78 = 80
int remainder = intNum % 6; // остача від ділення 80 на 6 = 2

Console.WriteLine("Як вас звати?");
string name = Console.ReadLine() ?? "";
int len = name.Length;

if (len < 2)
{
    Console.WriteLine("Занадто коротке ім'я.");
}
else if (len >= 2 && len < 20)
{
    Console.WriteLine($"Вітаємо, {name}! Довжина імені: {len}, остача: {remainder}, sbyte: {sbyteNum}, bool: {isReady}.");
}
else
{
    Console.WriteLine("Довге ім'я.");
}

int age = 18;
if (age < 6 || age > 18)
{
    Console.WriteLine("Вік поза діапазоном 6..18.");
}
else
{
    Console.WriteLine("Вік у межах 6..18.");
}
