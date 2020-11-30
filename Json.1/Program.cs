using System;
using System.Text;

namespace Json._1
{
    class Program
    {
        static void Main()
        {
            var str = Console.ReadLine();
            var sum = 0;
            for(var i = 0; i < str.Length; i++)
            {
                var builder = new StringBuilder();
                if (char.IsDigit(str[i]) || str[i] == '-')
                {
                    builder.Append(str[i]);
                    i++;
                    while (char.IsDigit(str[i]))
                    {
                        builder.Append(str[i]);
                        i++;
                    }
                    sum += int.Parse(builder.ToString());
                }
            }
            Console.WriteLine(sum);
        }
    }
}
