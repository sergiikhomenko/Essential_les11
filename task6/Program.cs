using System.Collections;

namespace task6;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * У колекцію ArrayList, через виклик методу Add додайте елементи структурного
 * та посилального типу, переберіть цю колекцію за допомогою циклу for.
 * З якою проблемою ви зіткнулися?
 */
public struct MyStruct
{
    public MyStruct()
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Test");
        MyStruct myStruct = new MyStruct();
        arrayList.Add(myStruct);
        for (int i =0;i<arrayList.Count;i++) 
        {
            Console.WriteLine($"{arrayList[i]}");
        }
    }
}