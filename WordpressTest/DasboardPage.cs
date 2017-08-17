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
                var spans = Driver.Instance.FindElements(By.TagName("span"));
                if (spans.Count > 0)
                    foreach(spans)
                    return spans[0].Text == "My Site";
                return false;
            }
        }
    }
}