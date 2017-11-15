using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCodeStudy
{
    public class Game
    {
        private int score;
        private int[] throws = new int[21];
        private int currentThrow;

        public int Score
        {
            get { return score; }
        }

        public void Add(int pins)
        {
            throws[currentThrow++] = pins;
            score += pins;
        }

        public int ScoreForFrame(int thFrame)
        {
            int score = 0;
            int ball = 0;

            for (int currentFrame = 0; currentFrame < thFrame; currentFrame++)
            {
                int firstThrow = throws[ball++];
                int secondThrow = throws[ball++];

                int framScore = firstThrow + secondThrow;

                if (framScore == 10)
                    score += framScore + throws[ball];
                else
                    score += framScore;
            }

            return score;
        }
    }
}
