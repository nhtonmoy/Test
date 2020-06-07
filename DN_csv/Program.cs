using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;
namespace DotNetCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var reader = new StreamReader(@"csv/data__2019-11-28.csv"))
            {
                reader.ReadLine();
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    
                    listA.Add(values[6]);
                    listB.Add(values[0]);
                }

                int fCount=0;
                int mCount=0;
                int total=0;
                foreach(var i in listA)
                {
                    total++;
                    if(i.Contains("FEMALE"))
                    {
                        fCount++;
                    }
                }
                mCount=total-fCount;

                Console.WriteLine("Female count="+ fCount);
                Console.WriteLine("Male Count= "+ mCount);
                List<string> dist = listB.Distinct().ToList();

                int uniqPolicyCount=0;
                foreach(var i in dist)
                {
                    uniqPolicyCount++;
                }

                Console.WriteLine(uniqPolicyCount);
            }
        }
    }
}
