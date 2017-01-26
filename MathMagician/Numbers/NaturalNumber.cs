﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        private int First { get; set; }

        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current + 1;
        }

        public int[] GetSequence(int how_many)
        {
            int[] naturalNums = new int[how_many];
            for (int i = 1; i <= how_many; i++)
            {
                naturalNums[i - 1] = i;
            }
            return naturalNums;
        }

        public string PrintNumbers(int[] how_many)
        {
            return String.Join(" ", how_many);
        }
    }
}