using System.Collections.Generic;
using System.Linq;

namespace IresoftUkol_DanielAdamek.DTOs
{
    internal class Statistics
    {
        public int NumberOfSentences { get; set; }
        public int NumberOfWords { get; set; }
        public int NumberOfCharacters { get; set; }
        public int NumberOfRows { get; set; }

        public static Statistics Calculate(string fileName)
        {
            var lines = GetLines(fileName);
            var words = GetWords(lines);
            return new Statistics
            {
                NumberOfSentences = GetNumberOfSentences(words),
                NumberOfWords = words.Count,
                NumberOfCharacters = GetNumberOfCharacters(words),
                NumberOfRows = lines.Length
            };
        }

        private static string[] GetLines(string fileName)
        {
            string[] lines;
            try
            {
                lines = System.IO.File.ReadAllLines(fileName);
            }
            catch
            {
                throw;
            }
            return lines;
        }

        private static List<string> GetWords(string[] lines)
        {
            var words = new List<string>();
            foreach (var line in lines)
            {
                if (line.Length > 0)
                    words.AddRange(line.Split(" "));
            }
            return words;
        }

        private static int GetNumberOfCharacters(List<string> words)
        {
            var numberOfCharacters = 0;
            foreach (var word in words)
            {
                numberOfCharacters += word.Length;
            }
            return numberOfCharacters;
        }

        private static int GetNumberOfSentences(List<string> words) => words.Count(x => x.EndsWith(".") || x.EndsWith("?") || x.EndsWith("!"));
    }
}
