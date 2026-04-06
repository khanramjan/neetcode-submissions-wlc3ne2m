public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> tp= new Dictionary<int, int>();
        foreach(int num in nums)
        {
            if(!tp.ContainsKey(num)){
                tp[num]=0;
            }
            tp[num]++;
        }
        int[] result=tp
        .OrderByDescending(x=>x.Value)
        .Take(k)
        .Select(x=>x.Key).ToArray();
        return result;
    }
}
