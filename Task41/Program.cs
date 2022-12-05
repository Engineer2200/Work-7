
Console.WriteLine("Введите количество чисел, которые хотите ввести:");
            int len =  int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Введите числа через (Пробел):");
            string[] arrayNumber =  Console.ReadLine().Split(' ');
 
            for (int i =0; i < arrayNumber.Length; i++)
            {
                arr[i] = int.Parse(arrayNumber[i]);
            }
int count = 0;
 
for (int i = 0; i < len; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
} 
Console.WriteLine($"Кол-во элементов больше нуля: {count}");