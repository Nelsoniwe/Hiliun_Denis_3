using System;
using System.Collections.Generic;

namespace laba_3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            ListOptions options = new ListOptions();

            Random ran = new Random();

            List<string> StringList = new List<string>();

            options.AddList(StringList,"asdf",0);
            options.AddList(StringList, "asdf",0);
            options.AddList(StringList, "asdf", 0);
            options.AddList(StringList, "asdf", 1);
            options.AddList(StringList, "asdf", 2);


            foreach (var item in StringList)
            {
                Console.WriteLine(item);
            }




        }
    }

    class ListOptions
    {
        public void AddList(List<string> ExampleList,string word,int index)
        {

            if (ExampleList.Count>1&&index<ExampleList.Count&&index!=0)
            {
                string exampleword = ExampleList[index-1] + " " + ExampleList[index];

                ExampleList.Insert(index, exampleword);
            }
            else if(ExampleList.Count==0||ExampleList.Count==1)
            {
                ExampleList.Add(word);
            }
            else if(index<0)
            {
                Console.WriteLine("wrong index");
            }
            else if(index>=ExampleList.Count)
            {
                Console.WriteLine("AAAAAAAAAAA");
            }
            

        }




    }



}
