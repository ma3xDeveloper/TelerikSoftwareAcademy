using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class GSM
    {

        //fields

        private string model;

        private string manufacturer;

        private int price;

        private string owner;

        private Battery Battery = new Battery();

        private Display Display = new Display();

        private static GSM iPhone4s = new GSM("IPhone4S", "Apple");

        private List<Call> callHistory;


        //constructors
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;


        }
        public GSM(string model, string manufacturer, int price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }
        public GSM(string model, string manufacturer, int price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public override string ToString() //overriding ToString method
        {
            return "Model: " + this.Model + "; Manufacturer: " + this.Manufacturer + "; Price: " + this.Price + "; Owner: " + this.Owner;
        }

        // Adding static property for iPhone4S
        public static GSM IPhone4S 
        {
            get { return iPhone4s; }
        }



        //properties to encapsulate the data fields 
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The value must be long at least 2 characters");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The value must be long at least 2 characters");
                }
                this.manufacturer = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can NOT be a negative number!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The value must be long at least 2 characters");
                }
                this.owner = value;
            }
        }



        public List<Call> CallHistory
        {

            get { return callHistory; }

            set { callHistory = value; }

        }

        //task 10
        public void AddCall(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }

        public void DeleteCall(Call myCall) 
        {
            this.CallHistory.Remove(myCall);
        }
        
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        //task 11
        public decimal CalculateTotalPriceOfCalls(decimal pricePerMin)
        {
            decimal price = 0.0m;

            foreach (var call in CallHistory)
            {
                price += call.Duration * pricePerMin / 60;
            }
            return price;
        }


    }
}
