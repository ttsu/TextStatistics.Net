using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TextStatistics.Net.Test
{
    public class TextStatisticsTest
    {
        [Fact]
        public void SyllableCountBasicWords()
        {
            TextStatistics.SyllableCount("a").Should().Be(1);
            TextStatistics.SyllableCount("was").Should().Be(1);
            TextStatistics.SyllableCount("the").Should().Be(1);
            TextStatistics.SyllableCount("and").Should().Be(1);
            TextStatistics.SyllableCount("foobar").Should().Be(2);
            TextStatistics.SyllableCount("hello").Should().Be(2);
            TextStatistics.SyllableCount("world").Should().Be(1);
            TextStatistics.SyllableCount("wonderful").Should().Be(3);
            TextStatistics.SyllableCount("simple").Should().Be(2);
            TextStatistics.SyllableCount("easy").Should().Be(2);
            TextStatistics.SyllableCount("hard").Should().Be(1);
            TextStatistics.SyllableCount("quick").Should().Be(1);
            TextStatistics.SyllableCount("brown").Should().Be(1);
            TextStatistics.SyllableCount("fox").Should().Be(1);
            TextStatistics.SyllableCount("jumped").Should().Be(1);
            TextStatistics.SyllableCount("over").Should().Be(2);
            TextStatistics.SyllableCount("lazy").Should().Be(2);
            TextStatistics.SyllableCount("dog").Should().Be(1);
            TextStatistics.SyllableCount("camera").Should().Be(3);
        }

        [Fact]
        public void SyllableCountComplexWords()
        {
            TextStatistics.SyllableCount("antidisestablishmentarianism").Should().Be(12);
            TextStatistics.SyllableCount("supercalifragilisticexpialidocious").Should().Be(14);
            TextStatistics.SyllableCount("chlorofluorocarbonation").Should().Be(8);
            TextStatistics.SyllableCount("forethoughtfulness").Should().Be(4);
            TextStatistics.SyllableCount("phosphorescent").Should().Be(4);
            TextStatistics.SyllableCount("theoretician").Should().Be(5);
            TextStatistics.SyllableCount("promiscuity").Should().Be(5);
            TextStatistics.SyllableCount("unbutlering").Should().Be(4);
            TextStatistics.SyllableCount("continuity").Should().Be(5);
            TextStatistics.SyllableCount("craunched").Should().Be(1);
            TextStatistics.SyllableCount("squelched").Should().Be(1);
            TextStatistics.SyllableCount("scrounge").Should().Be(1);
            TextStatistics.SyllableCount("coughed").Should().Be(1);
            TextStatistics.SyllableCount("smile").Should().Be(1);
            TextStatistics.SyllableCount("monopoly").Should().Be(4);
            TextStatistics.SyllableCount("doughey").Should().Be(2);
            TextStatistics.SyllableCount("doughier").Should().Be(3);
            TextStatistics.SyllableCount("leguminous").Should().Be(4);
            TextStatistics.SyllableCount("thoroughbreds").Should().Be(3);
            TextStatistics.SyllableCount("special").Should().Be(2);
            TextStatistics.SyllableCount("delicious").Should().Be(3);
            TextStatistics.SyllableCount("spatial").Should().Be(2);
            TextStatistics.SyllableCount("pacifism").Should().Be(4);
            TextStatistics.SyllableCount("coagulant").Should().Be(4);
            TextStatistics.SyllableCount("shouldn't").Should().Be(2);
            TextStatistics.SyllableCount("mcdonald").Should().Be(3);
            TextStatistics.SyllableCount("audience").Should().Be(3);
            TextStatistics.SyllableCount("finance").Should().Be(2);
            TextStatistics.SyllableCount("prevalence").Should().Be(3);
            TextStatistics.SyllableCount("impropriety").Should().Be(5);
            TextStatistics.SyllableCount("alien").Should().Be(3);
            TextStatistics.SyllableCount("dreadnought").Should().Be(2);
            TextStatistics.SyllableCount("verandah").Should().Be(3);
            TextStatistics.SyllableCount("similar").Should().Be(3);
            TextStatistics.SyllableCount("similarly").Should().Be(4);
            TextStatistics.SyllableCount("central").Should().Be(2);
            TextStatistics.SyllableCount("cyst").Should().Be(1);
            TextStatistics.SyllableCount("term").Should().Be(1);
            TextStatistics.SyllableCount("order").Should().Be(2);
            TextStatistics.SyllableCount("fur").Should().Be(1);
            TextStatistics.SyllableCount("sugar").Should().Be(2);
            TextStatistics.SyllableCount("paper").Should().Be(2);
            TextStatistics.SyllableCount("make").Should().Be(1);
            TextStatistics.SyllableCount("gem").Should().Be(1);
            TextStatistics.SyllableCount("program").Should().Be(2);
            TextStatistics.SyllableCount("hopeless").Should().Be(2);
            TextStatistics.SyllableCount("hopelessly").Should().Be(3);
            TextStatistics.SyllableCount("careful").Should().Be(2);
            TextStatistics.SyllableCount("carefully").Should().Be(3);
            TextStatistics.SyllableCount("stuffy").Should().Be(2);
            TextStatistics.SyllableCount("thistle").Should().Be(2);
            TextStatistics.SyllableCount("teacher").Should().Be(2);
            TextStatistics.SyllableCount("unhappy").Should().Be(3);
            TextStatistics.SyllableCount("ambiguity").Should().Be(5);
            TextStatistics.SyllableCount("validity").Should().Be(4);
            TextStatistics.SyllableCount("ambiguous").Should().Be(4);
            TextStatistics.SyllableCount("deserve").Should().Be(2);
            TextStatistics.SyllableCount("blooper").Should().Be(2);
            TextStatistics.SyllableCount("scooped").Should().Be(1);
            TextStatistics.SyllableCount("deserve").Should().Be(2);
            TextStatistics.SyllableCount("deal").Should().Be(1);
            TextStatistics.SyllableCount("death").Should().Be(1);
            TextStatistics.SyllableCount("dearth").Should().Be(1);
            TextStatistics.SyllableCount("deign").Should().Be(1);
            TextStatistics.SyllableCount("reign").Should().Be(1);
            TextStatistics.SyllableCount("bedsore").Should().Be(2);
            TextStatistics.SyllableCount("anorexia").Should().Be(5);
            TextStatistics.SyllableCount("anymore").Should().Be(3);
            TextStatistics.SyllableCount("cored").Should().Be(1);
            TextStatistics.SyllableCount("sore").Should().Be(1);
            TextStatistics.SyllableCount("foremost").Should().Be(2);
            TextStatistics.SyllableCount("restore").Should().Be(2);
            TextStatistics.SyllableCount("minute").Should().Be(2);
            TextStatistics.SyllableCount("manticores").Should().Be(3);
            TextStatistics.SyllableCount("asparagus").Should().Be(4);
            TextStatistics.SyllableCount("unexplored").Should().Be(3);
            TextStatistics.SyllableCount("unexploded").Should().Be(4);
            TextStatistics.SyllableCount("CAPITALS").Should().Be(3);
        }

        [Fact]
        public void SyllableCountProgrammedExceptions()
        {
            TextStatistics.SyllableCount("simile").Should().Be(3);
            TextStatistics.SyllableCount("shoreline").Should().Be(2);
            TextStatistics.SyllableCount("forever").Should().Be(3);
        }

        [Fact]
        public void AverageSyllablesPerWord()
        {
            TextStatistics.Parse("and then there was one").AverageSyllablesPerWord.Should().Be(1);
            TextStatistics.Parse("because special ducklings deserve rainbows").AverageSyllablesPerWord.Should().Be(2);
            TextStatistics.Parse("and then there was one because special ducklings deserve rainbows").AverageSyllablesPerWord.Should().Be(1.5);
        }

        [Fact]
        public void WordCount()
        {
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog").WordCount.Should().Be(9);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog.").WordCount.Should().Be(9);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. ").WordCount.Should().Be(9);
            TextStatistics.Parse(" The quick brown fox jumped over the lazy dog. ").WordCount.Should().Be(9);
            TextStatistics.Parse(" The  quick brown fox jumped over the lazy dog. ").WordCount.Should().Be(9);
            TextStatistics.Parse("Yes. No.").WordCount.Should().Be(2);
            TextStatistics.Parse("Yes.No.").WordCount.Should().Be(2);
            TextStatistics.Parse("Yes.No.").WordCount.Should().Be(2);
            TextStatistics.Parse("Yes . No.").WordCount.Should().Be(2);
            TextStatistics.Parse("Yes .No.").WordCount.Should().Be(2);
            TextStatistics.Parse("Yes - No. ").WordCount.Should().Be(2);
        }

        [Fact]
        public void CheckPercentageWordsWithThreeSyllables()
        {
            TextStatistics.Parse("there is just one word with three syllables in this sentence").PercentageWordsWithThreeSyllables.Should().Be(1.0/11.0);
            TextStatistics.Parse("there are no valid words with three Syllables in this sentence").PercentageWordsWithThreeSyllables.Should().Be(0);
            TextStatistics.Parse("there is one and only one word with three or more syllables in this long boring sentence of twenty words").PercentageWordsWithThreeSyllables.Should().Be(1.0/20.0);
            TextStatistics.Parse("there are two and only two words with three or more syllables in this long sentence of exactly twenty words").PercentageWordsWithThreeSyllables.Should().Be(2.0/20.0);
            TextStatistics.Parse("there is Actually only one valid word with three or more syllables in this long sentence of Exactly twenty words").PercentageWordsWithThreeSyllables.Should().Be(1.0/20.0);
            TextStatistics.Parse("no long words in this sentence").PercentageWordsWithThreeSyllables.Should().Be(0);
            TextStatistics.Parse("no long valid words in this sentence because the test ignores proper case words like this Behemoth").PercentageWordsWithThreeSyllables.Should().Be(0);
        }

        [Fact]
        public void TextLengthCheck()
        {
            TextStatistics.Parse("a").LetterCount.Should().Be(1);
            TextStatistics.Parse("").LetterCount.Should().Be(0);
            TextStatistics.Parse("this sentence has 30 characters, not including the digits").LetterCount.Should().Be(46);
        }
        
        [Fact]
        public void SentenceCount()
        {
            TextStatistics.Parse("This is a sentence").SentenceCount.Should().Be(1);
            TextStatistics.Parse("This is a sentence.").SentenceCount.Should().Be(1);
            TextStatistics.Parse("This is a sentence!").SentenceCount.Should().Be(1);
            TextStatistics.Parse("This is a sentence?").SentenceCount.Should().Be(1);
            TextStatistics.Parse("This is a sentence..").SentenceCount.Should().Be(1);
            TextStatistics.Parse("This is a sentence. So is this.").SentenceCount.Should().Be(2);
            TextStatistics.Parse("This is a sentence. \n\n So is this, but this is multi-line!").SentenceCount.Should().Be(2);
            TextStatistics.Parse("This is a sentence,. So is this.").SentenceCount.Should().Be(2);
            TextStatistics.Parse("This is a sentence!? So is this.").SentenceCount.Should().Be(2);
            TextStatistics.Parse("This is a sentence. So is this. And this one as well.").SentenceCount.Should().Be(3);
            TextStatistics.Parse("This is a sentence - but just one.").SentenceCount.Should().Be(1);
            TextStatistics.Parse("This is a sentence (but just one).").SentenceCount.Should().Be(1);
        }

        [Fact]
        public void AverageWordsPerSentence()
        {
            TextStatistics.Parse("This is a sentence").AverageWordsPerSentence.Should().Be(4);
            TextStatistics.Parse("This is a sentence.").AverageWordsPerSentence.Should().Be(4);
            TextStatistics.Parse("This is a sentence. ").AverageWordsPerSentence.Should().Be(4);
            TextStatistics.Parse("This is a sentence. This is a sentence").AverageWordsPerSentence.Should().Be(4);
            TextStatistics.Parse("This is a sentence. This is a sentence.").AverageWordsPerSentence.Should().Be(4);
            TextStatistics.Parse("This, is - a sentence . This is a sentence. ").AverageWordsPerSentence.Should().Be(4);
            TextStatistics.Parse("This is a sentence with extra text. This is a sentence. ").AverageWordsPerSentence.Should().Be(5.5);
            TextStatistics.Parse("This is a sentence with some extra text. This is a sentence. ").AverageWordsPerSentence.Should().Be(6);
        }

        [Fact]
        public void FleschKincaidReadingEase()
        {
            TextStatistics.Parse("This. Is. A. Nice. Set. Of. Small. Words. Of. One. Part. Each.").FleschKincaidReadingEase().Should().Be(121.2);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog.").FleschKincaidReadingEase().Should().Be(94.3);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog.").FleschKincaidReadingEase().Should().Be(94.3);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog").FleschKincaidReadingEase().Should().Be(94.3);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. \n\n The quick brown fox jumped over the lazy dog.").FleschKincaidReadingEase().Should().Be(94.3);
            TextStatistics.Parse("Now it is time for a more complicated sentence, including several longer words.").FleschKincaidReadingEase().Should().Be(50.5);
        }

        [Fact]
        public void FleschKincaidGradeLevel()
        {
            TextStatistics.Parse("This. Is. A. Nice. Set. Of. Small. Words. Of. One. Part. Each.").FleschKincaidGradeLevel().Should().Be(-3.4);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog.").FleschKincaidGradeLevel().Should().Be(2.3);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog.").FleschKincaidGradeLevel().Should().Be(2.3);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog").FleschKincaidGradeLevel().Should().Be(2.3);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. \n\n The quick brown fox jumped over the lazy dog.").FleschKincaidGradeLevel().Should().Be(2.3);
            TextStatistics.Parse("Now it is time for a more complicated sentence, including several longer words.").FleschKincaidGradeLevel().Should().Be(9.4);
        }

        [Fact]
        public void GunningFogScore()
        {
            TextStatistics.Parse("This. Is. A. Nice. Set. Of. Small. Words. Of. One. Part. Each.").GunningFogScore().Should().Be(0.4);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog.").GunningFogScore().Should().Be(3.6);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog.").GunningFogScore().Should().Be(3.6);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. \n\n The quick brown fox jumped over the lazy dog.").GunningFogScore().Should().Be(3.6);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog").GunningFogScore().Should().Be(3.6);
            TextStatistics.Parse("Now it is time for a more complicated sentence, including several longer words.").GunningFogScore().Should().Be(14.4);
            TextStatistics.Parse("Now it is time for a more Complicated sentence, including Several longer words.").GunningFogScore().Should().Be(8.3);
        }

        [Fact]
        public void ColemanLiauIndex()
        {
            TextStatistics.Parse("This. Is. A. Nice. Set. Of. Small. Words. Of. One. Part. Each.").ColemanLiauIndex().Should().Be(3.0);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog.").ColemanLiauIndex().Should().Be(7.7);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog.").ColemanLiauIndex().Should().Be(7.7);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. \n\n The quick brown fox jumped over the lazy dog.").ColemanLiauIndex().Should().Be(7.7);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog").ColemanLiauIndex().Should().Be(7.7);
            TextStatistics.Parse("Now it is time for a more complicated sentence, including several longer words.").ColemanLiauIndex().Should().Be(13.6);
        }

        [Fact]
        public void SMOGIndex()
        {
            TextStatistics.Parse("This. Is. A. Nice. Set. Of. Small. Words. Of. One. Part. Each.").SMOGIndex().Should().Be(1.8);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog.").SMOGIndex().Should().Be(1.8);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog.").SMOGIndex().Should().Be(1.8);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. \n\n The quick brown fox jumped over the lazy dog.").SMOGIndex().Should().Be(1.8);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog").SMOGIndex().Should().Be(1.8);
            TextStatistics.Parse("Now it is time for a more complicated sentence, including several longer words.").SMOGIndex().Should().Be(10.1);
        }

        [Fact]
        public void AutomatedReadabilityIndex()
        {
            TextStatistics.Parse("This. Is. A. Nice. Set. Of. Small. Words. Of. One. Part. Each.").AutomatedReadabilityIndex().Should().Be(-5.6);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog.").AutomatedReadabilityIndex().Should().Be(1.9);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog.").AutomatedReadabilityIndex().Should().Be(1.9);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. \n\n The quick brown fox jumped over the lazy dog.").AutomatedReadabilityIndex().Should().Be(1.9);
            TextStatistics.Parse("The quick brown fox jumped over the lazy dog. The quick brown fox jumped over the lazy dog").AutomatedReadabilityIndex().Should().Be(1.9);
            TextStatistics.Parse("Now it is time for a more complicated sentence, including several longer words.").AutomatedReadabilityIndex().Should().Be(8.6);
        }
    }
}
