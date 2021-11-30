using System;
using System.IO;
using System.Collections.Generic;
namespace RulesReconstruction
{
    class Program
    {
        static int Main(string[] args)
        {
            var preset = new List<IRenameRule>() { };

            using (var reader = new StreamReader("preset01.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    int index = line.IndexOf(' ');

                    IRenameRule rule;


                    switch (line.Substring(0, index))
                    {
                        case "AddPrefix":
                            
                            int paraIndex = line.IndexOf('\"');
                            int secondParaIndex = line.IndexOf('\"', paraIndex + 1);
                             rule = new AddPrefixRule(line.Substring(paraIndex + 1, secondParaIndex - paraIndex - 1));
                            preset.Add(rule);
                            break;
                        case "Replace":
                            int ReplaceparaIndex = line.IndexOf("[\"");
                            int ReplacesecondParaIndex = line.IndexOf("\"]", ReplaceparaIndex + 1);
                            List<string> needles = new List<string>();
                            needles.Add(line.Substring(ReplaceparaIndex + 2, ReplacesecondParaIndex - ReplaceparaIndex - 2));
                            string replacer = line.Substring(line.IndexOf("=> ") + 3);
                            replacer = replacer.Replace("\"", String.Empty);
                             rule = new ReplaceRule(needles, replacer);
                            preset.Add(rule);
                            break;
                    }

                    
                }
            }
            string newname = "Do Hai Thang vietnamworks.com.pdf";
                    foreach (var rule in preset)
                    {
                        newname = rule.Rename(newname);
                    }
            Console.WriteLine(newname);
            return 0;
        }
    }
}
