using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _1.SplittingStoneFree
{
    class Program
    {
        static void Main()
        {

            //2 consecutive elements by which we are spliting... 
            string namesV1 = "Tod Bob Maria Helena Jacky John";
            string[] splitNamesV1 = namesV1.Split(' ');

            foreach (var item in splitNamesV1)
            {
                Console.WriteLine(item);
            }
            string namesV2 = "Tod, Bob, Maria, Helena, Jacky, John";
            char[] separ = new char[10];
            string[] splitNamesV2 = namesV2.Split(Separate(", "),StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in splitNamesV2)
            {
                Console.WriteLine(item);
            }

            string namesV3 = "Tod,,,THAO Bob,,,THAO Maria,,,THAO Helena,,,THAO Jacky,,,THAO John";
            string[] splitNamesV3 = namesV3.Split(",,,THAO ",StringSplitOptions.None);

            foreach (var item in splitNamesV3)
            {
                Console.WriteLine(item);
            }

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://testing.todvachev.com/sitemap-posttype-post.xml");
            string[] pageSource = driver.PageSource.Split('>');

            foreach (var item in pageSource)
            {
                Console.WriteLine(item);
            }
            int startIndex = 0;
            int lenght = 0;
            List<string> links = new List<string>();
            foreach (var link in pageSource)
            {
                if (link.Contains("http://testing.todorvachev.com"))
                {
                    Console.WriteLine(startIndex);
                    startIndex = link.IndexOf('"')+1;
                    lenght = link.LastIndexOf('"')-startIndex;
                    links.Add(link.Substring(startIndex, lenght));
                }
            }
            foreach (var item in links)
            {
                Console.WriteLine(item);
            }
        }
        static char[] Separate(string characters)
        {
            char[] chars = characters.ToCharArray();
            return chars;
        }
    }
}
