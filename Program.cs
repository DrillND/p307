using System;

namespace ConsoleApp2
{
    //class Fibo
    //{
    //    public long Get(int i)
    //    {
    //        if (i < 0) { return 0; }
    //        if (i == 1) { return 1; }
    //        return Get(i - 2) + Get(i - 1);

    //    }
    //}
    class Program
    {

        static void Main(string[] args)
        {
            //    int i;
            //    Fibo fi = new Fibo();
            //    for (i = 1; i < 10; i++)
            //    {
            //        Console.WriteLine(fi.Get(i));
            //    }
            //}


            int a = 0;
            int b = 1;
            int c;
       

            for(int i = 0;i<10; i++)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }


        }
    }
}
