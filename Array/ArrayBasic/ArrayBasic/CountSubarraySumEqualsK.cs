namespace ArrayBasic
{
    class LongestSubArrayWithKSum
    {
        /// <summary>
        /// Given an array and a sum k, we need to print the length of the longest subarray that sums to k.
        ///</summary>

        /// Better -> using Hashing and storing prefix sum.
        /// Optimal for both positive and negative elements
        public int Run(int[] arr, int k)
        {
            int n = arr.Length;

            Dictionary<int, int> mp = new();
            int sum = 0;
            int ans = 0;
            
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];

                if (sum == k)
                    ans = int.Max(ans, i + 1);
                mp.GetValueOrDefault(sum);
                int rem = sum - k;

                if(mp.ContainsKey(rem))
                {
                    int remInd = mp[rem];
                    ans = int.Max(ans,i-remInd);
                }

                if (!mp.ContainsKey(sum))
                {
                    mp.Add(sum, i);
                }
                
            }


            return ans;
        }
        //optimal only for Postive.
        public int Run2(int[] arr, int k)
        {
            int l = 0, r = 0;
            int sum = arr[0];
            int n= arr.Length;

            int ans = 0;
            while (r < n) { 
            
                if(sum>k && l<=r)
                {
                    sum -= arr[l];
                    l++;
                }

                if (sum == k)
                {
                    ans = int.Max(ans, l);
                }

                r++;
                if(r<n)
                    sum += arr[r];
            
            }

            return ans;
        }
    }
}
