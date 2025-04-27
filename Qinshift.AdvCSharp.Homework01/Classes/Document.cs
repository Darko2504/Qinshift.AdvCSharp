
using Qinshift.AdvCSharp.Homework01.Interfaces;
namespace Qinshift.AdvCSharp.Homework01.Classes
{
   public class Document : ISearchable
    {
        public string Text { get; set; }
        public Document(string text)
        {
            Text = text;
        }
        public bool Search(string word)
        {
            Console.WriteLine("Searching Document....");
            return (Text.Contains(word.ToLower()));
        }
    }
}
