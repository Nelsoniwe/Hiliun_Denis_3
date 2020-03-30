using System;
using System.Collections.Generic;

namespace laba3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryOptions dictionaryOptions = new DictionaryOptions();

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("IV","S001");
            dic.Add("V", "S002");
            dic.Add("VI", "S001");
            dic.Add("VII", "S005");
            dic.Add("VIII","S005");
            dic.Add("IX","S009");
            dic.Add("X","S007");

            dictionaryOptions.FindUniqueValues(dic);


           // Console.WriteLine("Hello World!");
        }
    }

    class DictionaryOptions
    {
        
        public void FindUniqueValues(Dictionary<string,string>dic)
        {
            Dictionary<string, string> UniqueDictionary = new Dictionary<string, string>();

            ICollection<string> keys = dic.Keys;

            foreach (string key in keys)
            {
                if (UniqueDictionary.ContainsValue(dic[key])) { }
                else
                {
                    UniqueDictionary.Add(key,dic[key]);
                }
            }
            Console.WriteLine("UniqueValues: ");

            ICollection<string> uniquekeys = UniqueDictionary.Keys;

            foreach (string j in uniquekeys)
                Console.Write("{0} ",UniqueDictionary[j]);


        }

    }




}
