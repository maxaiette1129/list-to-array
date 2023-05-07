namespace list
{
    internal class Program
    {

        static void Main(string[] args)
        {
           List<int> nums = new List<int>(); 

           nums.Add(05);
           nums.Add(20);
           nums.Add(30);
           nums.Add(50);
           nums.Add(100);

            int[] numsToArray = nums.ToArray();

            for (int i = 0; i < numsToArray.Length; i++)
            {
                Console.WriteLine(numsToArray[i]);
            }
    






            







        }
    }
}