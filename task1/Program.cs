// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int Numbers(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int n1 = Numbers("Введите размер массива");
int n2 = Numbers("Введите левую границу значений");
int n3 = Numbers("Введите правую границу значений");

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(leftRange, rightRange + 1);
}
return arr;
}

int[] arr = FillArrayWithRandomNumbers(n1, n2, n3);
Console.WriteLine("[" + string.Join(",", arr) + "]");


int sumPositive = 0;


for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] > 0)
    {
        sumPositive = sumPositive + 1;
    }

}
System.Console.WriteLine($"Количество чисел больше 0 = {sumPositive}");

