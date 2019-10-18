namespace FindMaxInd
{
   public class MaxInd
    {
        public int FindMax(int[] array)
        {
            int maxInd, midValue;

            if (array.Length == 0)
            {
                return 0;
            }

            if (array.Length == 1)
            {
                return 1;
            }

            if (array.Length == 2)
            {
                if (array[0] >= array[1])
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            midValue = array[0];
            maxInd = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > midValue)
                {
                    midValue = array[i];
                    maxInd = i + 1;
                }
            }
            return maxInd;
        }

        static void Main(string[] args)
        {
                        
        }
    }
}
