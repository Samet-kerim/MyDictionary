using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T, Y>
    {
        T[] tArray;
        Y[] yArray;
        T[] ttempArray;
        Y[] ytempArray;

        public MyDictionary()
        {
            tArray = new T[0];
            yArray = new Y[0];
        }

        public void Ekle(T t,Y y)
        {
            ttempArray = tArray;
            tArray = new T[tArray.Length + 1];
            ytempArray = yArray;
            yArray = new Y[yArray.Length + 1];
            for (int i = 0; i < ttempArray.Length; i++)
            {
                tArray[i] = ttempArray[i];
            }
            tArray[tArray.Length - 1] = t;

            for (int j = 0; j < ytempArray.Length; j++)
            {
                yArray[j] = ytempArray[j];
            }
            yArray[yArray.Length - 1] = y;

        }
    }
}
