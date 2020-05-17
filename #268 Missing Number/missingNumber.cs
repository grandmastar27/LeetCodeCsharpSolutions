var result = nums.Length;
for (int i = 0; i < nums.Length; i++)
{
    result ^= i;
    result ^= nums[i];
}
return result;