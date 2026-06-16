
using System.Reflection;

namespace изпит06
{
    internal class DynamicnodeArray
    {
        private static object array;

        static void Main(string[] args)
        {
            int[] array = {};
            array.Add(5);
            array.Add(2);
            array.Add(9);
            array.Add(1);
            array.Add(7);
        }
    }

    internal class DynamicNodeArray : DynamicnodeArray
    {
        public static DynamicNodeArray array { get; private set; }
        internal class array
        {
        }

        static void Main(string[] args)
        {
            QuickSortMethod(array, 0, array.Count() - 1);
        }

        private int Count()
        {
            return array.Count();
        }

        private void QuickSortMethod(DynamicNodeArray array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);

                QuickSortMethod(array, left, pivotIndex - 1);
                QuickSortMethod(array, pivotIndex + 1, right);
            }
        }
        

        private int Partition(DynamicNodeArray array, int left, int right)
        {
            int pivot = array.GetValue(right);
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array.GetValue(j) <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        private int GetValue(int right)
        {
            throw new NotImplementedException();
        }

        private void Swap(DynamicNodeArray array, int i, int j)
        {
            int temp = array.GetValue(i);
            array.SetValue(i, array.GetValue(j));
            array.SetValue(j, temp);
        }

        private void SetValue(int i, int v)
        {
            array[i].
        }
        public void Add(int i)
        {
            if (i == array.Length)
            {
                Resize();
            }
            array[]=new Array(i);
            array++;
        }
        private void Resize()
        {
            array[] newarray = new DynamicNodeArray[array.Length * 2];
            for(int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newarray;
        }

    }

    
}

