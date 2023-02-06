// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int CountPositive(int[] array)
{
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive = sumPositive + 1;
        }

    }
    
    return sumPositive;
}


System.Console.WriteLine("Введите количество элементов:\t ");

int elementAmount = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elementAmount];

for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите элемент массива номер {i}:\t");
    myArray[i] = Convert.ToInt32(Console.ReadLine());  //int.TryParse

}

int positive = CountPositive(myArray);
System.Console.WriteLine($"Количество полоительных значений равно: {positive}");















