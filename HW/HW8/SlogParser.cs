using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    class SlogParser
    {
        private static readonly HashSet<char> Glas = new HashSet<char>("аоуиэыяюеё"),
                                              Zvonk = new HashSet<char>("лмнр"),
                                              Soglas = new HashSet<char>("бвгджзклмнпрстфхцчшщъь"),
                                              Gluh = new HashSet<char>("бвгджзкпстфхцчшщъь");

        public static IEnumerable<string> GetSlogs(string input)
        {
            var sb = new StringBuilder();
            Predicate<int> case1 = index => input[index] == 'й' && Soglas.Contains(input[index + 1]);
            Predicate<int> case2 = index => Zvonk.Contains(input[index]) && Gluh.Contains(input[index + 1]);
            int i = 0;
            for (; GlasLeft(input, i) > 1 || sb.Length != 0; i++)
            {
                sb.Append(input[i]);
                if (case1(i) || case2(i) || Glas.Contains(input[i]) && !(case1(i) || case2(i)))
                {
                    yield return sb.Append('-').ToString();
                    sb.Clear();
                }
            }
            yield return input.Substring(i);
        }

        private static int GlasLeft(string input, int i)
        {
            int count = 0;
            for (int j = i; j < input.Length; j++)
                if (Glas.Contains(input[j]))
                    count++;
            return count;
        }
    }
}
