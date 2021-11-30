using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesReconstruction
{
    class ReplaceRule : IRenameRule
    {
        public List<string> Needles { get; set; }
        public string Replacer { get; set; }

        public ReplaceRule(List<string> needles, string replacer)
        {
            this.Needles = needles;
            this.Replacer = replacer;
        }

        public string Rename(string original)
        {
            string result = original;

            foreach (var needle in Needles)
            {
                result = result.Replace(needle, Replacer);
            }

            return result;
        }
    }
}
