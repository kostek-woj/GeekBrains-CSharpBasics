using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message
{
    public static class Message
    {
        public static void PrintWordsShorterThanN(string msg, int n) {
            
            StringBuilder msgSb = new StringBuilder(); // for string without punctuation and numbers
            char[] msgArr = msg.ToCharArray();
            
            for (int i = 0; i < msgArr.Length; i++) {
                if (!Char.IsDigit(msgArr[i]) && !Char.IsPunctuation(msgArr[i])) {
                    msgSb.Append(msgArr[i]);
                }
            }

            string[] msgNew = msgSb.ToString().Split(' ');

            Console.WriteLine($"\nAll the words equal or shorter than {n}:");

            for (int i = 0; i < msgNew.GetLength(0); i++) {
                if (msgNew[i].Length <= n && msgNew[i].Length != 0) {
                    Console.WriteLine(msgNew[i].Length + "\t" + msgNew[i]);
                }
            }
        }


        public static void RemoveWordsEndingIn(string msg, char c) {
            
            string[] msgArr = msg.Trim().Split(' ');
            StringBuilder sb = new StringBuilder();
            
            foreach (string s in msgArr) {
                if (s[s.Length - 1] != c) {
                    sb.Append(s + " ");
                }
            }
            
            Console.WriteLine(sb.ToString().Trim());
        }


        public static string LongestWord(string msg) {
            
            string[] msgArr = msg.Trim().Split(' ');
            string longestWord = msgArr[0];
            
            foreach (string s in msgArr) {
                if (s.Length > longestWord.Length) {
                    longestWord = s;
                }
            }
            
            return longestWord;
        }


        public static void LongestWordsString(string msg) {
            
            int longestLength = LongestWord(msg).Length;
            StringBuilder sb = new StringBuilder();
            string[] msgArr = msg.Trim().Split(' ');
            
            foreach (string s in msgArr) {
                if (s.Length == longestLength) {
                    sb.Append(s + " ");
                }
            }

            Console.WriteLine($"\nLongest words make the following sentence:\n{sb.ToString().Trim()}");
        }


        public static Dictionary<string, int> FrequencyTextAnalysis(string msg) {
            
            string[] msgArr = msg.Trim().Split(' ');
            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string s in msgArr) {
                if (!frequency.ContainsKey(s)) {
                    frequency.Add(s, 1);
                } else {
                    frequency[s]++;
                }
            }

            foreach (KeyValuePair<string, int> kvp in frequency.OrderByDescending(key => key.Value).ThenBy(key => key.Key)) {
                Console.WriteLine($"{kvp.Value}\t{kvp.Key}");
            }

            return frequency; // return value since it was demanded to do so in the task :)
        }
    }
}
