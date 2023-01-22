
int[] nums = new int[100];
int val;

Console.Write("Input nums array value: ");

nums = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

Console.Write("Input val: ");
val = Convert.ToInt32(Console.ReadLine());

var count = -1;
for (var i = 0; i < nums.Length - 1; i++)
{
    if (nums[i] == val)
    {
        int temp = nums[i + 1];
        nums[i] = temp;
        nums[i + 1] = val;
        count++;
    }
}

Console.WriteLine(count);
Console.WriteLine(String.Join(", ", nums));




