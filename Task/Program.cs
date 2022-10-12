/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный масссив можно ввести с клавиатуры, либо задать на старте выполнение алгоритма.
При решении не рекомендуется пользоваnься коллекциями, лучше обойтись исключетительно массивами.
["hello", "2", "world", ";-)"] -> ["2",";-)"}
*/
Console.Clear();
Console.WriteLine("Введите длину вашего массива:");
int lenArr = Convert.ToInt32(Console.ReadLine());
string[] firstArr = new string[lenArr];
string[] newArr = new string[firstArr.Length];

// Пишем метод на заполнение первичного массива
void FillArray(string[] arr)
{
    Console.WriteLine("Введите элементы массива:");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}


