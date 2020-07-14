using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censor_multimedia
{
    public class MediaPart
    {
        private int startTimeInSecond, stopTimeInSecond;
        public MediaPart(int startTimeInSecond, int stopTimeInSecond)
        {
            this.startTimeInSecond = startTimeInSecond;
            this.stopTimeInSecond = stopTimeInSecond;
        }
        public int getStartTimeInSecond()
        {
            return startTimeInSecond;
        }
        public int getStopTimeInSecond()
        {
            return stopTimeInSecond;
        }
        public override string ToString()
        {
            string startPointHMSstring = toHMS(secondToHMS(startTimeInSecond));
            string stopPointHMSstring = toHMS(secondToHMS(stopTimeInSecond));
            return startPointHMSstring + " - " + stopPointHMSstring;
        }

        public static int[] secondToHMS(int timeInSeconds)
        {
            int[] res = new int[3];//h,m,s
            res[0] = timeInSeconds / 3600;
            timeInSeconds = timeInSeconds - (timeInSeconds / 3600) * 3600;
            res[1] = timeInSeconds / 60;
            timeInSeconds = timeInSeconds - (timeInSeconds / 60) * 60;
            res[2] = timeInSeconds;
            return res;
        }

        public static int HMStoSeconds(int hour, int minute, int seconds)
        {
            return hour * 3600 + minute * 60 + seconds;
        }

        public static string toHMS(int[] hmsPoint)
        {
            string hour = hmsPoint[0].ToString();
            string minute = hmsPoint[1].ToString();
            string second = hmsPoint[2].ToString();
            return hour + ":" + minute + ":" + second;
        }
    }
}
