using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Call
    {
        //fields

        private DateTime date; 

        private DateTime time;

        private int dialedPhoneNumber;

        private int duration;

        //constructors

        public Call(DateTime Date, DateTime Time, int DialedPhoneNumber, int Duration)
        {
            this.date = Date;
            this.time = Time;
            this.dialedPhoneNumber = DialedPhoneNumber;
            this.duration = Duration;
        }

        //public DateTime Date
        //{
        //    get { return this.date; }
        //}
        //public DateTime Time
        //{
        //    get { return this.time; }
        //}
        //public uint DialedPhoneNumber
        //{
        //    get { return this.dialedPhoneNumber; }
        //}
        //public ulong Duration
        //{
        //    get { return this.duration; }
        //}
    }
}
