namespace task3;
/*
 * Створіть клас Dictionary.
 * Реалізуйте у найпростішому наближенні можливість
 * використання його екземпляра аналогічно екземпляру класу Dictionary із простору
 * імен System.Collections.Generic.
 * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати
 * метод додавання пар елементів,
 * індексатор для отримання значення елемента за вказаним індексом
 * і властивість тільки для читання для отримання загальної кількості пар елементів.
 */
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        myDictionary.AddItems("1","test");
        myDictionary.AddItems("2","Test 2");
        Console.WriteLine($"{myDictionary["2"]}");
    }
}