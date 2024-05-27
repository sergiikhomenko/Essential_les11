using System.Collections;

namespace test4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть клас ArrayList. Реалізуйте у найпростішому наближенні можливість
 * використання його екземпляра аналогічно екземпляру класу ArrayList із простору
 * імен System.Collections. 
 */
class Program
{
    static void Main(string[] args)
    {
        ArreyList myArreyList = new ArreyList();
        myArreyList.Add("Test");
        myArreyList.Add(1);
        myArreyList.Add(true);
        for (int i = 0; i < myArreyList.Size;i++)
        {
            Console.WriteLine($"{myArreyList[i]}");
        }
    }
}