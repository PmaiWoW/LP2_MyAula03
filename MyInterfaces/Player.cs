using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyInterfaces
{
    class Player : IHasScore
    {
        private int score;
        private string PlayerName { get; set; }
        private int Score
        {
            get => score;
            set
            {
                if (value >= 0) score = value;
                else Score = 0;
            }
        }

        int IHasScore.Score => score;

        public Player(string playerName, int score)
        {
            PlayerName = playerName;
            Score = score;
        }

        public bool Equals([AllowNull] IHasScore other)
            => Score == other.Score ? true : false;

        public override string ToString() => "Player";
    }
}
