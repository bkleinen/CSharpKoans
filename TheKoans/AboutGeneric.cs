using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KoanHelpers;

namespace TheKoans
{

    public class AboutGeneric
    {
        public static void Run()
        {
            MyGeneric<int, string> gen = new MyGeneric<int, string>(1, "a");
            gen.write();

        }

    }
       public class MyGeneric<T, U>
    {
        private T myObjT;
        private U myObjU;

        public MyGeneric(T t, U u)
        {
            myObjT = t;
            myObjU = u;
        }

        public void write()
        {
            Console.WriteLine("Typ von t ist " + myObjT.GetType().ToString());
            Console.WriteLine("Typ von u ist " + myObjU.GetType().ToString());
        }
    }

}
