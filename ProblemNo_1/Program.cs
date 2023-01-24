
int[] nums = new int[100];
int val;

Console.Write("Input nums array value: ");

nums = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

Console.Write("Input val: ");
val = Convert.ToInt32(Console.ReadLine());

var count = 0;
for (var i = 0; i < nums.Length; i++)
{
    if (nums[i] != val)
    {
        count++;
        for (int j = 0; j < i; j++)
        {
            if (nums[j] == val)
            {                
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;

            }
        }
    }

}

Console.WriteLine(count);
Console.WriteLine(String.Join(", ", nums));




