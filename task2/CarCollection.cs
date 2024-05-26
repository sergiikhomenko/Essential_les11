namespace task2;
/*
 * Створіть клас CarCollection. Реалізуйте у найпростішому наближенні можливість
 * використання екземпляра для створення парку машин. Мінімально необхідний інтерфейс
 * взаємодії з екземпляром повинен включати метод додавання машин з назвою машини і року
 * її випуску, індексатор для отримання значення елемента за вказаним індексом і властивість
 * тільки для читання для отримання загальної кількості елементів. Створіть спосіб видалення
 * всіх машин автопарку.
 */
public class Car
{
    private string _title;
    private int _year;

    public Car(string titleCar, int year)
    {
        _title = titleCar;
        _year = year;
    }

    public string Title
    {
        get { return _title; }
    }

    public int Year
   {
       get { return _year; }
   }

}

public class CarCollection <T> where T: Car
{
    private T[] _carsPark = new T[0];
    private int _count;

    public int Count
    {
        get { return _count; }
    }

    public CarCollection()
    {
       
    }

    public void AddCarsToCollection(T car)
    {
         T[] newPark = new T[_carsPark.Length +1];
        Array.Copy(_carsPark,newPark,_carsPark.Length);
        newPark[newPark.Length-1] = car;
        _carsPark = newPark;
        _count = _carsPark.Length;
    }

    public T  this[int index]
    {
        get
        {
            return _carsPark[index];
        }
    }

    public void DelateColection()
    {
      Array.Resize(ref _carsPark,0);
      _count = _carsPark.Length;
    }
}