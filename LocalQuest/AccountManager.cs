﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalQuest
{
    internal static class AccountManager
    {
        // should store separate, but I am lazy right now!!
        
        static List<string> Adjectives = new List<string>()
        {
            "Silly",
            "Goofy",
            "Happy",
            "Crazy",
        };

        static List<string> Animals = new List<string>()
        {
            "Cat",
            "Kitten",
            "Fox",
            "Bat",
            "Wolf",
            "Possum",
        };

        public static string CreateName()
        {
            Random R = new Random();
            return Adjectives[new Random().Next(0, Adjectives.Count)] + Animals[new Random().Next(0, Adjectives.Count)];
        }
    }
}