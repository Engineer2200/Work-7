
Console.WriteLine("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");
