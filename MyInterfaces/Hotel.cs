using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyInterfaces
{
    class Hotel : IHasScore
    {
        private int numOfRooms;
        private int score;
        private string HotelName { get; set; }
        private string HotelDescription { get; set; }
        private int NumberOfRooms
        {
            get => numOfRooms;
            set
            {
                if (value >= 1) numOfRooms = value;
                else NumberOfRooms = 1;
            }
        }
        private int Score
        {
            get => score;
            set
            {
                if (value >= 0 && value <= 5) score = value;
                else if (value < 0) score = 0;
                else if (value > 5) score = 5;
            }
        }

        int IHasScore.Score => score;

        public Hotel(string hotelName, string hotelDescrip, int numOfRooms,
            int score)
        {
            HotelName = hotelName;
            HotelDescription = hotelDescrip;
            NumberOfRooms = numOfRooms;
            Score = score;
        }

        public bool Equals([AllowNull] IHasScore other)
            => Score == other.Score ? true : false;
        
        public override string ToString() => "Hotel";
    }
}
