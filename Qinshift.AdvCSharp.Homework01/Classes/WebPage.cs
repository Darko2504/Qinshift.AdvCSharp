

using Qinshift.AdvCSharp.Homework01.Interfaces;

namespace Qinshift.AdvCSharp.Homework01.Classes
{
   public class WebPage : ISearchable
    {
        public string Text { get; set; }
        public WebPage(string text)
        { 
            Text = text;
        }
        public bool Search(string word)
        {
            Console.WriteLine("Searching WebPage....");
            return (Text.Contains(word.ToLower()));
        }
    }
}
