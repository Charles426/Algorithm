using System;
namespace Sort
{
    public class Example
    {
        public static void Sort(IComparable[] a)
        {
            
        }

        public static bool Less(IComparable v,IComparable w)
        {
            return v.CompareTo(w)<0;
        }

        public static void Exch(IComparable[] a,int i,int j)
        {
            IComparable t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        private static void Show(IComparable[] a)
        {
            for (int i = 0; i < a.Length;i++)
            {
                Console.WriteLine($"{a[i]} ");
            }
            Console.WriteLine();
        }

        private static bool IsSorted(IComparable[] a)
        {
            for (int i = 1; i < a.Length;i++)
                if (Less(a[i],a[i-1]))
                    return false;
            return true;
        }

    }
}
