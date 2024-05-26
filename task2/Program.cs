using System.Runtime.InteropServices;

namespace task2;
/*
 * Створіть клас CarCollection. Реалізуйте у найпростішому наближенні можливість
 * використання екземпляра для створення парку машин. Мінімально необхідний інтерфейс
 * взаємодії з екземпляром повинен включати метод додавання машин з назвою машини і року
 * її випуску, індексатор для отримання значення елемента за вказаним індексом і властивість
 * тільки для читання для отримання загальної кількості елементів. Створіть спосіб видалення
 * всіх машин автопарку.
 * 
 */
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("dodge", 2020);
        CarCollection<Car> carCollection = new CarCollection<Car>();
        Car car1 = new Car("audi", 2021);
        carCollection.AddCarsToCollection(car);
        carCollection.AddCarsToCollection(car1);
        Console.WriteLine($"Назва {carCollection[0].Title}  Рік {carCollection[0].Year}");
        Console.WriteLine($"Назва {carCollection[1].Title}  Рік {carCollection[1].Year}");
        carCollection.DelateColection();
    }
}