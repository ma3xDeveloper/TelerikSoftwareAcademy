using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DefiningClassesPart1
{
    public class Battery
    {
        //fields
        private string modelBattery;

        private int idle;

        private int talk;

        private BatteryType batteryType;



        public enum BatteryType // Enumeration BatteryType 
        {
            LiIon,
            NiMH,
            NiCd
        }

        //properties to encapsulate the data fields 
        public string ModelBattery
        {
            get
            {
                return this.modelBattery;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Battery model can NOT be null or empty!");
                }
                this.modelBattery = value;
            }
        }

        public int Idle
        {
            get
            {
                return this.idle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can NOT be a negative number!");
                }
                this.idle = value;
            }
        }

        public int Talk
        {
            get
            {
                return this.talk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can NOT be a negative number!");
                }
                this.talk = value;
            }
        }
    }
}
