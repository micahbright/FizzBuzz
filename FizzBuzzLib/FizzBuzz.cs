using System.Collections.Generic;
using System.Text;

namespace fizzbuzz
{
    public static class FizzBuzzClass
    {
        public static string GetFizzBuzzItem(int i, List<Tuple<int, string>> fizzBuzz)
        {
            string s = "";
            bool bFound = false;
            foreach(var itm in fizzBuzz)
            {
                if (i % itm.Item1 == 0)
                {
                    s += itm.Item2;
                    bFound = true;
                }
            }
            if (!bFound)
                s += i.ToString();
            return s;
        }

        public static IEnumerable<string> FizzBuzz(int n, List<Tuple<int, string>> fizzBuzz)
        {
            for(int i=1;i<=n; ++i)
            {
                yield return GetFizzBuzzItem(i, fizzBuzz);
            }
        }

    }
}
