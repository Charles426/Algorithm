using System;
namespace BinarySearch
{
    public class BinarySearch
    {
        public static int BinarySearchIndex(int key,int[] a)
        {
            int l = 0;
            int r = a.Length - 1;
            while(r>=l)
            {
                int mid = (l + r) / 2;
                if (key == a[mid])
                    return mid;
                else if (key > a[mid])
                    l = mid+1;
                else
                    r = mid-1;
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = BinarySearchIndex(3, a);
            Console.WriteLine(index);
        }
    }
}
