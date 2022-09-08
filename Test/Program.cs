// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

string [] array = new string [size];
for(int i = 0; i < array.Length; i ++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
    array[i] = Console.ReadLine();
}

int count = 0;

for(int i = 0; i < array.Length; i ++)
{
    if(array[i].Length < 3 || array[i].Length == 3)
    {
        count = count + 1;
    }
}

int newSize = count;
string [] newArray = new string[newSize];

int k = 0;
for(int i = 0; i < array.Length; i ++)
{
    if(array[i].Length < 3 || array[i].Length == 3)
    {
            newArray[k] = array[i];
            k ++;
            //Console.WriteLine(String.Join(' ',newArray));
            //Console.WriteLine(String.Join(' ',newArray[i]));
        
    }
}

Console.WriteLine("Вывод массива, состоящего из строк,содержащих 3 и меньше символов: ");
PrintMatrix(newArray);

void PrintMatrix(string[] newArray)
{
        for(int i = 0; i < newArray.Length; i ++)
        {
            Console.Write(String.Join(' ',newArray[i]));
        }
        Console.WriteLine();
}


// Console.WriteLine("Вывод массива, состоящего из строк,содержащих 3 и меньше символов: ");

// for(int i = 0; i < newArray.Length; i ++)
// {
//     Console.WriteLine(String.Join(' ', newArray));
// }


    



