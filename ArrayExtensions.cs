using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0 || accuracy < 0)
                throw new ArgumentException();
            double sum_left = 0;
            double sum_right = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum_right+= array[i];
            }
            int j = 0;
            for( ; j < array.Length; j++ )
            {
                sum_right -= array[j];
                if (Math.Abs(sum_left - sum_right) <= accuracy)
                    break;
                sum_left += array[j];
            }
            if (j == array.Length)
                return (null);
            return (j);
        }
    }
}
