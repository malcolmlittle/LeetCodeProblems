public class Solution {
    public int[] RunningSum(int[] nums) {
        
        // initialize new array with size equal to nums length
        int[] resultArr = new int[nums.Length];

        // initialize running sum variable
        int runningSum = 0;

        // loop thru array elements
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                // update running sum to be value at first position (idx 0)
                runningSum = nums[i];
            }
            else
            {
                // update running sum to add value at position i
                runningSum = runningSum + nums[i];
            }

            // assign running sum values to result array
            resultArr[i] = runningSum;
        }

        // return result array
        return resultArr;
    }
}