using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMJulyBatch_Task.utilities
{
    public static class UtilExtension
    {
        public static string AddRandomDigits(this string text) => string.Concat(text, new Random().Next(1, 999));
        public static string AddRandomDigits2(this string text, string text2) => text + new Random().Next(1, 999) + text2;
        public static string AddRandomDigits3(this string text) => string.Concat(text, new Random().Next(1, 999) + $"@abc.co.uk");
        public static IJavaScriptExecutor ScrollIntoViewAndClickViaJs(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            js.ExecuteScript("arguments[0].click()", element);
            return js;
        }
    }
}