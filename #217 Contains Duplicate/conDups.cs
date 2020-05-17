if (nums.Length == 0)
    return false;
else if (nums.Length == 1)
    return false;
else
{
    SortedDictionary<int, int> sorted = new SortedDictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (sorted.ContainsKey(nums[i]))
            sorted[nums[i]]++;
        else
            sorted[nums[i]] = 1;
    }
    var countDups = sorted.Count(x => x.Value > 1);
    return (countDups >= 1) ? true : false;
}