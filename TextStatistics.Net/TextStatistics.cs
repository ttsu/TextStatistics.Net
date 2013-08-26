using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextStatistics.Net
{
    public class TextStatistics
    {
        public static TextStatistics Parse(string text)
        {
            var cleanText = CleanText(text);

            return new TextStatistics(cleanText);
        }

        private static readonly string[] FullStopTags = new[] { "li", "p", "h1", "h2", "h3", "h4", "h5", "h6", "dd" };

        private static string CleanText(string text)
        {
            foreach (var tag in FullStopTags)
            {
                text = Regex.Replace(text, "</" + tag + ">", ".", RegexOptions.IgnoreCase);
            }
            text = Regex.Replace(text, @"<[^>]+>", string.Empty);   // strip tags - this may fail in some cases
            text = Regex.Replace(text, @"["",:;\()-]", " ");        // Replace commas, hyphens, quotes etc
            text = Regex.Replace(text, @"[\.!?]", ".");             // Unify terminators
            text = text.Trim() + ".";                               // Add final terminator
            text = Regex.Replace(text, @"\s+", " ");                // Replace new lines, multiple spaces
            text = Regex.Replace(text, @"[\.][\. ]+", ".");         // Remove duplicated terminators
            text = Regex.Replace(text, @"[ ]*[\.]", ". ").TrimEnd();// Pad sentence terminators
            text = Regex.Replace(text, @"[\.] [^ ]+", m => m.Value.ToLower()); // Lower case all words following terminators

            return text;
        }

        private readonly string _text;

        protected TextStatistics(string text)
        {
            _text = text;
        }

        /// <summary>
        /// Gives the Flesch-Kincaid Reading Ease of text entered rounded to one digit
        /// </summary>
        /// <returns></returns>
        public double FleschKincaidReadingEase()
        {
            return Math.Round(206.835 - (1.015 * AverageWordsPerSentence) - (84.6 * AverageSyllablesPerWord), 1);
        }

        /// <summary>
        /// Gives the Flesch-Kincaid Grade level of text entered rounded to one digit
        /// </summary>
        /// <returns></returns>
        public double FleschKincaidGradeLevel()
        {
            return Math.Round(((0.39 * AverageWordsPerSentence) + (11.8 * AverageSyllablesPerWord) - 15.59), 1);
        }

        /// <summary>
        /// Gives the Gunning-Fog score of text entered rounded to one digit
        /// </summary>
        /// <returns></returns>
        public double GunningFogScore()
        {
            return Math.Round(((AverageWordsPerSentence + PercentageWordsWithThreeSyllables * 100) * 0.4), 1);
        }


        /// <summary>
        /// Gives the Coleman-Liau Index of text entered rounded to one digit
        /// </summary>
        /// <returns></returns>
        public double ColemanLiauIndex()
        {
            return Math.Round(((5.89 * ((double)LetterCount / (double)WordCount)) - (0.3 * ((double)SentenceCount / (double)WordCount)) - 15.8), 1);
        }

        /// <summary>
        /// Gives the SMOG Index of text entered rounded to one digit
        /// </summary>
        /// <returns></returns>
        public double SMOGIndex()
        {
            return Math.Round(1.043 * Math.Sqrt(((double)WordsWithThreeSyllables * (30 / (double)SentenceCount)) + 3.1291), 1);
        }

        /// <summary>
        /// Gives the Automated Readability Index of text entered rounded to one digit
        /// </summary>
        /// <returns></returns>
        public double AutomatedReadabilityIndex()
        {
            return Math.Round(((4.71 * ((double)LetterCount / (double)WordCount)) + (0.5 * ((double)WordCount / (double)SentenceCount)) - 21.43), 1);
        }

        public int Length
        {
            get { return _text.Length; }
        }

        private int? _letterCount;
        /// <summary>
        /// Gets the letter count, ignoring all non-word characters.
        /// </summary>
        public int LetterCount 
        {
            get
            {
                if (_letterCount == null)
                {
                    var charString = Regex.Replace(_text, @"[^A-Za-z]+", string.Empty);

                    _letterCount = charString.Length;
                }

                return _letterCount.Value;
            }
        }

        private int? _sentenceCount;
        public int SentenceCount
        {
            get
            {
                if (_sentenceCount == null)
                {
                    _sentenceCount = Math.Max(1, _text.ToCharArray().Count(c => c == '.'));
                }

                return _sentenceCount.Value;
            }
        }

        private int? _wordCount;
        public int WordCount
        {
            get
            {
                if (_wordCount == null)
                {
                    _wordCount = 1 + _text.ToCharArray().Count(c => c == ' ');
                }

                return _wordCount.Value;
            }
        }

        private int? _wordsWithThreeSyllables;
        public int WordsWithThreeSyllables
        {
            get
            {
                if (_wordsWithThreeSyllables == null)
                {
                    _wordsWithThreeSyllables = CountWordsWithThreeSyllables();
                }

                return _wordsWithThreeSyllables.Value;
            }
        }


        private double? _percentageWordsWithThreeSyllables;
        public double PercentageWordsWithThreeSyllables
        {
            get
            {
                if (_percentageWordsWithThreeSyllables == null)
                {
                    _percentageWordsWithThreeSyllables = 
                        (double)CountWordsWithThreeSyllables(false) / (double)WordCount;
                }

                return _percentageWordsWithThreeSyllables.Value;
            }
        }

        private double? _averageSyllablesPerWord;
        public double AverageSyllablesPerWord
        {
            get
            {
                if (_averageSyllablesPerWord == null)
                {
                    int totalSyllables = _text.Split(' ').Sum(w => SyllableCount(w));
                    _averageSyllablesPerWord = (double)totalSyllables / WordCount;
                }

                return _averageSyllablesPerWord.Value;
            }
        }

        private double? _averageWordsPerSentence;
        public double AverageWordsPerSentence
        {
            get
            {
                if (_averageWordsPerSentence == null)
                {
                    _averageWordsPerSentence = (double)WordCount / SentenceCount;
                }

                return _averageWordsPerSentence.Value;
            }
        }

        private int CountWordsWithThreeSyllables(bool countProperNouns = true)
        {
            return _text.Split(' ')
                .Count(w => (countProperNouns || !Regex.IsMatch(w, @"^[A-Z]")) && SyllableCount(w) > 2);
        }

        public static int SyllableCount(string word)
        {
            word = Regex.Replace(word.ToLower(), @"[^a-z]", string.Empty);

            int syllableCount;

            var problemWords = new Dictionary<string, int>
            {
                {"simile", 3},
                {"forever", 3},
                {"shoreline", 2}
            };

            if (problemWords.TryGetValue(word, out syllableCount))
            {
                return syllableCount;
            }

            // These syllables would be counted as two but should be one
            var subSyllables = new[] 
            {
                 @"cial"
                ,@"tia"
                ,@"cius"
                ,@"cious"
                ,@"giu"
                ,@"ion"
                ,@"iou"
                ,@"sia$"
                ,@"[^aeiuoyt]{2,}ed$"
                ,@".ely$"
                ,@"[cg]h?e[rsd]?$"
                ,@"rved?$"
                ,@"[aeiouy][dt]es?$"
                ,@"[aeiouy][^aeiouydt]e[rsd]?$"
                ,@"[aeiouy]rse$"
            };

            // These syllables would be counted as one but should be two
            var addSyllables = new[] {
                 @"ia"
                ,@"riet"
                ,@"dien"
                ,@"iu"
                ,@"io"
                ,@"ii"
                ,@"[aeiouym]bl$"
                ,@"[aeiou]{3}"
                ,@"^mc"
                ,@"ism$"
                ,@"([^aeiouy])\1l$"
                ,@"[^l]lien"
                ,@"^coa[dglx]."
                ,@"[^gq]ua[^auieo]"
                ,@"dnt$"
                ,@"uity$"
                ,@"ie(r|st)$"
            };

            // Single syllable prefixes and suffixes
            var prefixSuffix = new[]{
                 @"^un"
                ,@"^fore"
                ,@"ly$"
                ,@"less$"
                ,@"ful$"
                ,@"ers?$"
                ,@"ings?$"
            };

            int prefixSuffixCount = 0;
            foreach (var regex in prefixSuffix)
            {
                if (Regex.IsMatch(word, regex))
                {
                    word = Regex.Replace(word, regex, string.Empty);
                    prefixSuffixCount++;
                }
            }

            int wordPartCount = Regex.Split(word, @"[^aeiouy]+").Count(s => s != string.Empty);

            syllableCount = wordPartCount + prefixSuffixCount;
            foreach (var regex in subSyllables)
            {
                if (Regex.IsMatch(word, regex)) syllableCount--;
            }
            foreach (var regex in addSyllables)
            {
                if (Regex.IsMatch(word, regex)) syllableCount++;
            }

            return Math.Max(1, syllableCount);
        }
    }
}
