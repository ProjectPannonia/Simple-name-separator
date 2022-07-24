using System;
using System.Collections.Generic;

namespace IndexFinderTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = "FirstName1 LastName1  FirstName2 LastName2   FirstName3 LastName3   FirstName4 LastName4 ";
            // Split string at spaces
            List<string> separatedNames = new List<string>(names.Split(' '));
            // Get rid of empty strings
            separatedNames.RemoveAll(x => String.IsNullOrEmpty(x));
            
            int counter = 0;
            string name = "";
            List<string> clearNamesList = new List<string>();

            for(int i = 0; i < separatedNames.Count; i++)
            {
                // If counter == 0 -> It is a first name
                if (counter ==  0)
                {
                    // Concat firstname
                    name += separatedNames[i];
                    // Increment name counter
                    counter++;
                }
                // If counter == 1 -> It is a last name
                else if(counter == 1)
                {
                    // Full name Created -> Concat last name to first name
                    name = $"{name} {separatedNames[i]}";
                    // Add to cleared name list
                    clearNamesList.Add(name.Trim());
                    // Full name created, so set the counter to zero
                    counter = 0;
                    // Set name to an empty string, before iteration continoued
                    name = "";
                } 
                
            }
            // Write cleared full names to console
            foreach(string s in clearNamesList)
            {
                Console.WriteLine(s);
            }
            
            Console.ReadLine();
        }
    }
}
