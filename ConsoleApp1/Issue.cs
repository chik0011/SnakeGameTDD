using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Issue
    {
        private int min;
        private int max;
        private Random random;

        public Issue(int min, int max, Random random)
        {
            this.min = min;
            this.max = max;
            this.random = random;
        }

        public int getRandomNumber()
        {
            int randomNumber = this.random.Next(this.min, this.max);
            issueIsBetweenLimit(randomNumber);

            return randomNumber;
        }

        public bool issueIsBetweenLimit(int number)
        {
            if (number >= this.min && number <= this.max)
                return true;
            else
                throw new RandomNumberIsNotBetweenLimit("Your number is not valid");
        }

        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
    }

    
    public class RandomNumberIsNotBetweenLimit : Exception
    {
        public RandomNumberIsNotBetweenLimit(string? message) : base(message)
        {
        }
    }
}
