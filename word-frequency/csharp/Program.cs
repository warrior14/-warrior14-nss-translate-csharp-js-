using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace WordFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            // removing all non-alphanumeric characters from a string except dash:
            // replace whatever doesn't match inside the bracketed characters [^a-zA-Z0-9-] with an empty string.
            // Regex rgx = new Regex("[a-zA-Z0-9-]");
            // str = rgx.Replace(str, "");

            // Or: string s1 = Regex.Replace(s, "[A-Za-z0-9-]", ""); where is the string to be replaced
            // A Regular Expression/Regex, is a pattern we search for in a text which helps with matching, locating, and managing text.
            var text = getText();
            // The bracketed characters [^a-zA-z0-9-] means that any letter (regardless of case) or digit or dash in the text
            // will not be replaced by any empty string 
            var replaced = Regex.Replace(text, "[^A-Za-z]", ""); // string input, string pattern, string replacement
            var words = replaced.Split(" ");

            // Creating a C# dictionary, setting the initial value to an empty object, and implenting the ContainsKey() method
            Dictionary<string, int> freqCounts = new Dictionary <string, int>();

            foreach (var in words)
            {
                if (word.Trim() === "")
                {
                    continue;
                }
                if (freqCounts.ContainsKey(word)) 
                {
                    freqCounts[word] += 1;
                }
                else 
                {
                    freqCounts[word] = 1;
                }
            } 

            // iterate through dictionary collection and print each key/value pair:
            foreach (KeyValuePair<string, int> freqCount in freqCounts)
            {
                // Console.WriteLine("Key = {0}, Value = {1}", freqCount.Key, freqCount.Value);
                Console.WriteLine($"{freqCount.Key}: {freqCount.Value}");
            }

            string getText()
            {
                return @"Look again at that dot. That's here. That's home. That's us. On it everyone you love, everyone you know, everyone you ever heard of, every human being who ever was, lived out their lives. The aggregate of our joy and suffering, thousands of confident religions, ideologies, and economic doctrines, every hunter and forager, every hero and coward, every creator and destroyer of civilization, every king and peasant, every young couple in love, every mother and father, hopeful child, inventor and explorer, every teacher of morals, every corrupt politician, every 'superstar,' every 'supreme leader,' every saint and sinner in the history of our species lived there--on a mote of dust suspended in a sunbeam.
                    The Earth is a very small stage in a vast cosmic arena. Think of the rivers of blood spilled by all those generals and emperors so that, in glory and triumph, they could become the momentary masters of a fraction of a dot. Think of the endless cruelties visited by the inhabitants of one corner of this pixel on the scarcely distinguishable inhabitants of some other corner, how frequent their misunderstandings, how eager they are to kill one another, how fervent their hatreds.
                    Our posturings, our imagined self-importance, the delusion that we have some privileged position in the Universe, are challenged by this point of pale light. Our planet is a lonely speck in the great enveloping cosmic dark.In our obscurity, in all this vastness, there is no hint that help will come from elsewhere to save us from ourselves.
                    The Earth is the only world known so far to harbor life.There is nowhere else, at least in the near future, to which our species could migrate. Visit, yes.Settle, not yet. Like it or not, for the moment the Earth is where we make our stand.
                    It has been said that astronomy is a humbling and character - building experience.There is perhaps no better demonstration of the folly of human conceits than this distant image of our tiny world.To me, it underscores our responsibility to deal more kindly with one another, and to preserve and cherish the pale blue dot, the only home we've ever known.
                    - Carl Sagan";
            }
        }
    }
}