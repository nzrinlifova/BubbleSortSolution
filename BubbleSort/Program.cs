int [] nums = {800,11,50,771,649,770,240,9};
int temp = 0;
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length-i-1; j++)
    {
        if (nums[j] > nums[j+1])
        {
            temp = nums[j + 1];
            nums[j + 1] = nums[j];
            nums[j] = temp;
        }
    }
}
for (int k = 0; k < nums.Length; k++)
{
    Console.Write(nums[k] +" "); 
}