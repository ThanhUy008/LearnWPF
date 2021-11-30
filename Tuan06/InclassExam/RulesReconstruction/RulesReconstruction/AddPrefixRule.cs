using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesReconstruction
{
    class AddPrefixRule : IRenameRule
    {
        public string Prefix { get; set; }
        public AddPrefixRule(string prefix)
        {
            Prefix = prefix;
        }

        public string Rename(string original)
        {
            string result = "";

            result = $"{Prefix}{original}";

            return result;
        }
    }
}
