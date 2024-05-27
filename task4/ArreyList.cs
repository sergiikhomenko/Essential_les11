using System.Collections;
using System.Drawing;

namespace test4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть клас ArrayList. Реалізуйте у найпростішому наближенні можливість
 * використання його екземпляра аналогічно екземпляру класу ArrayList із простору
 * імен System.Collections.
 */
public class ArreyList
{
    private object[] _items = new  object[0];
    private int _size;

    public ArreyList()
    {
        
    }

    public int Size
    {
        get
        {
            return _size;
        }
    }

    public void Add(object item)
    {
        object[] newList = new object[_items.Length +1];
        Array.Copy(_items,newList,_items.Length);
        newList[newList.Length-1] = item;
        _items = newList;
        _size = _items.Length;
    }

    public object this[int index]
    {
        get
        {
            return _items[index];
        }
    }

}