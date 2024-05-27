namespace task7;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть узагальнений клас MyClass, що містить статичний фабричний метод –
 * T FacrotyMethod(), який породжуватиме екземпляри типу, вказаного як параметр
 * типу (покажчика місця заповнення типом – Т). Яким має бути тип, що підставляється під T?
 */
class Program
{
    static void Main(string[] args)
    {
        ExtClass instance = MyClass<ExtClass>.FacrotyMethod();
        instance.Test();
    }
}