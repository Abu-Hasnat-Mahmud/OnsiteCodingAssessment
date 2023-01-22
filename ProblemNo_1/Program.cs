
int[] nums=new int[100];
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
        nums[i] = nums[i+1];
        count++;
    }
}

Console.WriteLine(count);
Console.WriteLine(String.Join(", ", nums));




