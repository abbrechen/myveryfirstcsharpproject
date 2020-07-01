using System;

namespace Gaming
{
    class Player
    {
        private int score;
        private string name;

        public string Name
        {
            set
            {
                if (value.Length <= 0) throw new Exception("Name must be longer than 0");
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Score
        {
            set
            {
                if (value < 0) throw new Exception("Score may not be lower than 0");
                score = value;
            }
            get
            {
                return score;
            }
        }
        public string playerInfo
        {
            get
            {
                return $"player >{name}< added with a score of {score}.";
            }
        }
    }
}
