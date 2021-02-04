//written by Webi Chala


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bowl
    {
        //private variables
        private int max = 100;
        private int min = 1;
        private string bowl = "Bowl";
        private string super = "Super";
        private List<int> alistofNumbers = new List<int>();
        //gets and sets

        public int Max
        {
            get
            {
                return this.max;
            }
            set
            {
                this.max = value;

            }
        }
        public int Min
        {
            get
            {
                return this.min;
            }
            set
            {
                this.min = value;

            }
        }
        public string Bow
        {
            get
            {
                return this.bowl;
            }
            set
            {
                this.bowl = value;
            }
        }
        public string Super
        {
            get
            {
                return this.super;
            }
            set
            {
                this.super = value;
            }
        }

        //methods
        public string GetSuperBowl()
        {
            return this.super + this.bowl;
        }
        public List<int> Num(int max, int min)
        {

            for(int i = min; i<max+1; i++)
            {
                alistofNumbers.Add(i);
            }
            return alistofNumbers;
        }
        public override string ToString()
        {
            string message = "";
            foreach(var s in this.Num(max, min))
            {
                if(s%3 == 0)
                {
                    message = message + s + " "+ this.Bow + "\n";
                }
                else if (s % 5 == 0)
                {
                    message = message + s + " " + this.Super + "\n";
                }
                else if((s % 5 == 0) && (s % 3 == 0))
                {
                    message = message + s + " " + this.GetSuperBowl() + "\n";
                }
                else if (s % 7 == 0)
                {
                    message = message + s + " " + this.GetSuperBowl() + "\n";
                }
                else
                {
                    message = message + s + "\n";
                }

                
            }
            return message;
        }



    }
}
