Console.Write("Сколько элементов необходимо внести? ");//вводим количество элементов
int size = Convert.ToInt32(Console.ReadLine());// создаем переменную и приравниваем к введенному числу
string[] arrStrings = new string[size];// создаем новый массив в котором будет size элементов
int limit = 3;// задаем переменную которая будет указывать лимит символов в элементе
int position = 0;// переменная которая будет приравнена к позиции где элемент не превышает 3 символов
for (int i = 0; i < size; i++)// перебор элементов в массиве размером size
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");// просим пользователя внести элементы поочереди количество которых будет равно size
 string element = Convert.ToString(Console.ReadLine());// записываем введенные элементы в массив
 if (element.Length <= limit)// если i элемент введенный пользователем будет меньше либо равен лимитному количеству символов в элементе
    {
 arrStrings[position] = element;// записываем введенные элементы в массив arrStrings в случае выполнения условия
 position++;// переходим к следующему element в массиве arrStrings[position]
    }
}
Console.WriteLine();
PrintArr(arrStrings); // вывод на экран результата записанного в массив arrStrings

void PrintArr(string[] array) // метод выполняющий вывод на экран массива от итой позиции с пробелом между элементами
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
//Commit 
