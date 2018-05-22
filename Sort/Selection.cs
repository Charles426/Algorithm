using System;
namespace Sort
{
    public class Selection
    {
        public static void Sort(IComparable[] a)
        {
            int length = a.Length;
            for (int i = 0; i < length;i++)
            {
                int min = i;
                for (int j = i+1; j < length;j++)
                {
                    if (a[min].CompareTo(a[j]) > 0)
                        min = j;
                }
                Exch(a, i, min);
            }
        }

        public static void Exch(IComparable[] a,int i,int j)
        {
            IComparable t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        public static void Show(IComparable[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine($"{a[i]} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            IComparable[] a = new string[]{ "1", "3", "2", "5", "4", "8", "7", "6", "9" };
            Selection.Show(a);
            Selection.Sort((IComparable[])a);
            Selection.Show(a);
        }

    }
}
