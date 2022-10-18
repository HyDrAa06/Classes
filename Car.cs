using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string regNumber;

        public Car(string make, string model, int horsePower, string regNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegNumber = regNumber;
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public string RegNumber
        {
            get { return regNumber; }
            set { regNumber = value; }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Make: {make}");
            builder.AppendLine($"Model: {model}");
            builder.AppendLine($"Horse power: {horsePower}");
            builder.AppendLine($"Reg number: {regNumber}");

            return builder.ToString();
        }

    }
}
