using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Ekle(0, "Samet");
            myDictionary.Ekle(1, "Nuriye");
        }
    }
}
