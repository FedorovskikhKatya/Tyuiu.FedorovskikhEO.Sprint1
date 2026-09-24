using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FedorovskikhEO.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string result="";
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reverse = "";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reverse += word[j];
                }
                if (word == reverse)
                {
                    result += word + " ";
                }

            }
            return result.Trim();


        }
    }
}
