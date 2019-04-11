using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730108_Assignment_4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
            p.ProcessArrayList();

        }
        public void Run()
        {
            this.ReadTextFiles();
            this.ProcessArrayList();
        }
public void ReadTextFiles()
        { }
        public void ProcessArrayList()
        {
            int LineNumber = 0;
        
        
        
            foreach (var line in Beowulf)
            {
                Console.WriteLine();
                {
                    LineNumber++;
                    if (ContainsWord(line.ToString().ToLower(), "sea") && ContainsWord(line.ToString().ToLower(), "fare"))
                    {
                        Console.WriteLine("line number is:{0}", LineNumber);
                        LineNumber++;

                    }
                }
            }
            public bool ContainsWord(string line, string word)
            {
                if (line.Contains(word) == true)
                {
                    return true;
                }
                return false;
            }
            public void ReadTextLine();
            {
                //Read file using StreamReader.Reads file line by line 
                using (StreamReader file = new StreamReader("U:/Users/730108/Beowulf.txt"))
                {
                    int counter = 0;
                    string ln;
                    StreamReader reader = new StreamReader("U:/Users/730108/Beowulf.txt");
                    string script = reader.ReadToEnd();

                    while ((ln = file.ReadLine()) != null)
                    {
                    }
                        var text = script.Trim();
                        int count = 0, index = 0;


                    while(index< text.Length)
                    {
                        Console.WriteLine(ln);
                        Beowulf.Add(ln);
                        counter++;
                        while(index < text.Length && !char.IsWhiteSpace(text[index]))
                        {
                            index++;
                            count++;
                        }
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                    Console.WriteLine("Total number of words are:", +count);
                }

            }
            public int FindNumberOfBlankSpaces(string line)
            {
                int countletters = 0;
                int countSpaces = 0;

                foreach (char c in line)
                {
                    if (char.IsLetter(c))
                    { countletters++; }
                    if (char.IsWhiteSpace(c)) { countSpaces++; }
                }
                return countSpaces;

            }

        }
    }
}

