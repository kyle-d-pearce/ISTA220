﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4A_Farm
{
    class Horse
    {
        public Horse(string name)
        {
            string animalName = name;
            Console.WriteLine($"Hello, my name is {animalName}. ");
        }

        public string speak()
        {
            string sound = "neigh";
            return sound;
        }

        public string eat()
        {
            string food = "hay";
            return food;
        }

        public string movie()
        {
            string film = "Black Beauty";
            return film;
        }

        public string product()
        {
            string service = "transportation";
            return service;
        }
    }
}
