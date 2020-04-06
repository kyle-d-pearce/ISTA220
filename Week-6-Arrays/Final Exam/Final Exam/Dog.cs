﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Dog
    {
        public string name; 
        public string breed; 
        private int age;
        public string color; 

        public Dog(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public int Age // property
        {
            get { return age; }
            set { age = value; }
        }

        public string getName()
        {
            return name;
        }
        public string getBreed()
        {
            return breed;
        }
        public int getage()
        {
            return age;
        }
        public string getcolor()
        {
            return color;
        }

        public void makeString()
        {
            Console.WriteLine("The dog's name is {0}. The breed is {1}. The age is {2}. The color is {3}.", name, breed, age, color);
        }
    }
}