using System;
namespace Sort
{
    public class Sort
    {
        public static void SelectionSort(IComparable[] a)
        {
            Action<IComparable[], int, int> Switch = (arr, i, j) =>
            {
                IComparable t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            };
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i; j < n; j++)
                    if (a[min].CompareTo(a[j]) > 0)
                        min = j;
                Switch(a, i, min);
            }
        }

        public static void InsertionSort(IComparable[] a)
        {
            Action<IComparable[], int, int> Switch = (arr, i, j) =>
            {
                IComparable t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            };

            int n = a.Length;

            for (int i = 1; i < n; i++)
                for (int j = i; j > 0 && a[j].CompareTo(a[j - 1]) < 0; j--)
                    Switch(a, j, j - 1);

        }



        public static void Merge(IComparable[] a, int l, int r)
        {

            IComparable[] t = new IComparable[a.Length];
            for (int k = l; k <= r; k++)
                t[k] = a[k];

            int i = l;
            int mid = (l + r) / 2;
            int j = mid + 1;


            for (int k = l; k <= r; k++)
            {
                if (i > mid) a[k] = t[j++];
                else if (j > r) a[k] = t[i++];
                else if (t[i].CompareTo(t[j]) > 0) a[k] = t[j++];
                else a[k] = t[i++];
            }
        }

        public static void MergeSort(IComparable[] a,int l,int r)
        {
            if (l >= r)
                return;
            int mid = (l + r) / 2;
            MergeSort(a, l, mid);
            MergeSort(a, mid + 1, r);
            Merge(a, l, r);
        }


        public static void QuickSort(IComparable[] a,int l,int r)
        {
            if (l >= r)
                return;
            int p = Partition(a, l, r);
            QuickSort(a, l, p - 1);
            QuickSort(a, p + 1, r);
        }


        public static int Partition(IComparable[] a,int l,int r)
        {
            Action<IComparable[], int, int> Switch = (arr, i2, j2) =>
              {
                  IComparable t = arr[i2];
                  arr[i2] = arr[j2];
                  arr[j2] = t;
              };

            IComparable mid = a[l];
            int i = l;
            int j = r + 1;
            while(true)
            {
                while(mid.CompareTo(a[++i])>0) 
                    if (i == r)
                        break;
                while (mid.CompareTo(a[--j]) < 0)
                    if (j == l)
                        break;
                if (i >= j)
                    break;
                Switch(a, i, j);
            }

            Switch(a,l,j);
            return j;
        }


        public static void Main(string[] args)
        {
            IComparable[] a = new IComparable[] { 1, 3, 2, 5, 4, 8, 7, 6, 9 };
            //SelectionSort(a);
            //InsertionSort(a);
            //MergeSort(a, 0, 8);
            QuickSort(a, 0, 8);
            foreach (IComparable element in a)
            {
                Console.WriteLine($"{element}");
            }
        }

    }
}
