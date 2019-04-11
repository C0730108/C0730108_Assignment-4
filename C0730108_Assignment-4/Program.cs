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
                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        Beowulf.Add(ln);
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
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

