using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_el246_page
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; } // количесво мешков для коров
        private int feedMultiplier; // // столько требуется мешков для одной коровы в месяц
        private int numberOfCows; // количество коров

// Свойство NumbersOfCows  
        public int NumberOfCows   
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * feedMultiplier;
            }
        }
        //  конструктор класса Farmer

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}
