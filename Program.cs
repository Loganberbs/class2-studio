using System;
using System.Collections.Generic;

namespace class2_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";


                char[] ipsumArray = loremIpsum.ToCharArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();
                foreach(char c in ipsumArray){
                
                if (counts.ContainsKey(c)){
                
                    int i = counts.GetValueOrDefault(c);
                    counts[c] = i + 1;
                } 
                  else {
                    counts[c] = 1;
                }
            }
        foreach (KeyValuePair<char, int> count in counts){
            
                Console.WriteLine(count.Key + ": " + count.Value);
            }
            Console.ReadLine();
        }

    }
}
