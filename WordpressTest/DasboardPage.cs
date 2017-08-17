using System;
using System.Threading;
using OpenQA.Selenium;
using WordpressAutomation;

namespace WordpressTest
{
    public class DasboardPage
    {
        public static bool IsAt
        {
            get
            {
                Driver.Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                Thread.Sleep(5000);
                Console.WriteLine(Driver.Instance.Title);
                var spans = Driver.Instance.FindElements(By.TagName("span"));
                if (spans.Count > 0)
                    Console.WriteLine("There are " + spans.Count + " spans.");
                for (int i=0; i < spans.Count; i++)
                {
                    Console.WriteLine(i + spans[i].Text);
                    return spans[0].Text == "My Site";
                }
                return false;
            }
        }
    }
}