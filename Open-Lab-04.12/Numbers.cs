using System;
using System.Linq;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int mN = 0;
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;

            }
            if (sum < 55)
                mN = 55 - sum;
            return mN;

        }
    }
}
