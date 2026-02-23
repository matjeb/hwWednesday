using System.Runtime.CompilerServices;
int size = 0;
int k = int.Parse(Console.ReadLine());
List<int>[] arrays = new List<int>[k];
for (int i = 0; i < k; i++)
{
    List<int> list = new List<int>();
    string[] s = Console.ReadLine().Split(' ');
    size += s.Length;
    for (int k2 = 0; k2 < s.Length; k2++) list.Add(int.Parse(s[k2]));
    arrays[i] = list;
}

List<int> ans = new List<int>();
//for (int i = 0; i < k; i++)
//{
//    for (int j = 0; j < arrays[i].Length; j++) ans.Add(arrays[i][j]);
//}
//ans.ToArray();
//ans.Sort();

while (ans.Count != size)
{
    int[] nums = new int[k];
    for (int i = 0; i < k; i++) nums[i] = int.MaxValue;
    for (int i = 0; i < k; i++)
    {
        if (arrays[i].Count > 0) { nums[i] = arrays[i][0]; }
    }
    foreach (int n in nums) Console.Write(n + " "); Console.WriteLine(); Console.WriteLine();
    Console.WriteLine(arrays[1].Count);
    ans.Add(nums.Min());
    for (int i = 0; i < k; i++)
    {
        if (arrays[i].Count != 0 && arrays[i][0] == nums.Min()) { arrays[i].RemoveAt(0); break; }
    }
}

for (int i = 0; i < ans.Count; i++) Console.Write(ans[i] + " ");

//4
//1 2 6 13 23
//1 6 6 7 9 10
//8 12 13
//9 10