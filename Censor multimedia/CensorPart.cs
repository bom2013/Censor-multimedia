using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censor_multimedia
{
    public class CensorPart : MediaPart
    {
        private char level;
        private string message;

        public CensorPart(int startTimeInSecond, int stopTimeInSecond) : base(startTimeInSecond, stopTimeInSecond)
        {
            level = 'A';
            message = "";
        }

        public CensorPart(int startTimeInSecond, int stopTimeInSecond, char level, string message) : base(startTimeInSecond, stopTimeInSecond)
        {
            this.level = level;
            this.message = message;
        }

        public char getLevel()
        {
            return level;
        }

        public string getMessage()
        {
            return message;
        }

        public static char getMaxLevel(char level1, char level2)
        {
            return (char)Math.Min((int)level1, (int)level2);
        }

        //return if level1 bigger than level2(level A > level C)
        public static bool isLevelbiggerOrEqualThan(char level1, char level2)
        {
            return level1 <= level2;//its opposite
        }

        public override string ToString()
        {
            return base.ToString() + " Level " + level + ": " + message;
        }
    }
}
