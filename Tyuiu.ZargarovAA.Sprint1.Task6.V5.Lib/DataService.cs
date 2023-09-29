using System;
using System.Linq; // Добавляем это для использования LINQ
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZargarovAA.Sprint1.Task6.V5.Lib
{
    public class DataService
    {
        public string CheckSymmetricalWords(string inputText)
        {
            return string.Join(" ", inputText.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Where(word => IsPalindrome(word)));
        }

        private bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
