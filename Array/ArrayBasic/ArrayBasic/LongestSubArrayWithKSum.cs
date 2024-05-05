namespace ArrayBasic
{
    class CountSubarraySumEqualsK
    {
        /// <summary>
        /// Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
        ///</summary>

        /// Optimal for both positive and negative elements
        public int Run(int[] arr, int k)
        {
            int n = arr.Length;
            Dictionary<int, int> mp = new();
            int sum = 0;
            int ans = 0;
            mp[0] = 1;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
                if (mp.ContainsKey(sum - k))
                    ans += mp[sum - k];

                mp[sum] = mp.GetValueOrDefault(sum, 0) + 1;

            }

            return ans;
        }
    }
}
