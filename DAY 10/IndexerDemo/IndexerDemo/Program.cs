using System;


namespace IndexerDemo
{
    public class array
    {


        float[] arr = new float[] { 12.2f, 32.4f, 6.78f, 55.9f, 33.4f, 3.9f, 44.2f };
        public float this[int index]
        {
            get
            {
                return arr[index];
            }

            set

            {
                arr[index] = value;
            }
        }
    }


    class class1
    {
        static void Main(String[] args)
        {
            array a;
            a = new array();
            a[3] = 42.9f;
            Console.WriteLine(a[3]);
        }
    }
}
    
