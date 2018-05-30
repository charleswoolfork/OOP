using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Dog
    {
        //Declare fields

        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;

        //Declare properties (States)

        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        
       
          //Declareconstructors

        public Dog()
        {
          // (Default constructor)
        }

            //Methods (behaviors)

        public void Run()
        {

        }
        public void Bark()
        {

        }
        public void Potty()
        {

        }
        public void Cuddle()
        {

        }

        // Loaded constructor

        public Dog (int hairLength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void RUn()
        {
            Console.WriteLine("Your dog can run {0}miles per hour", runningSpeed);
        }




    }
}