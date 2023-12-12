// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

 int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReverse(array, array.Length - 1);
    

   static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]); // Выводим элемент из массива на консоль
            PrintArrayReverse(array, index - 1); // Рекурсивно вызываем этот метод для следующего индекса
        }
    }