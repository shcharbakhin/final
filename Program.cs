internal class Program
{
    private static void Main(string[] args)
    {
        {
            string[] final = { };
            string[] arr = { "hello", "world", "coomit", "22b", "ad" };
            for (int i = 0; i < arr.Length; i++)
            {
                string str = arr[i];
                int x = str.Length;
                if (x < 4)
                {
                    int j = 0;
                    final[j] = str;
                    Console.Write(final[j]);
                    j++;
                }
            }
        }
    }
}