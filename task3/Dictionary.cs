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

public class Dictionary<K,T>
{
    private List<KeyValuePair<K, T>> _items;
    
    private int _сount = 0;
    
    private EqualityComparer<K> comparer;
    
    public Dictionary()
    {
        _items = new List<KeyValuePair<K, T>>();
        comparer = EqualityComparer<K>.Default;
    }
    
    public void AddItems(K key, T item)
    {
        _items.Add(new KeyValuePair<K, T>(key,item));
    }
    
    public T this[K key]
    {
        get
        {
            foreach (var item in _items)
            {
                if (EqualityComparer<K>.Default.Equals(item.Key, key))
                {
                    return item.Value;
                }
            }
            throw new KeyNotFoundException("Ключ не знайдено");
        }
    }
    
    public int Count
    {
        get
        {
            return _items.Count;
        }
    }
}