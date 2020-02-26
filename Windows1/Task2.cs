using System;
using Munkhzul;
using Task2;

namespace Windows1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Munkhzul.Lab1.Class1 class1 = new Munkhzul.Lab1.Class1();
            class1.readFromNamespaceLab1();
            Task2.Class2 class2 = new Task2.Class2();
            class2.setPrivateAge(20);
            class2.setPublicName("Zulaa");
            class2.printPrivateAge();
            class2.printPublicName();

        }
    }
}
