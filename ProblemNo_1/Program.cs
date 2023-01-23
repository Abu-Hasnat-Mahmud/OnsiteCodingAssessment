
int[] nums = new int[100];
int val;

Console.Write("Input nums array value: ");

nums = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

Console.Write("Input val: ");
val = Convert.ToInt32(Console.ReadLine());

var count = 0;
for (var i = 0; i < nums.Length - 1; i++)
{
    if (nums[i] == val)
    {
        int temp = nums[i + 1];
        if (temp!=val)
        {
            count++;
        }
        nums[i] = temp;
        nums[i + 1] = val;
       
    }
}

Console.WriteLine(count);
Console.WriteLine(String.Join(", ", nums));




