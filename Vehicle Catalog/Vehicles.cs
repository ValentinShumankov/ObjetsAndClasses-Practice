using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Catalog
{
    public class Vehicles
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicles(string type
            , string model
            , string color
            , double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;

        }


        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            if (Type == "car")
            {
                st.AppendLine($"Type: Car");

            }
            else if (Type == "truck")
            {
                st.AppendLine($"Type: Truck");
            }
            st.AppendLine($"Model: {this.Model}");
            st.AppendLine($"Color: {this.Color}");
            st.AppendLine($"Horsepower: {this.HorsePower}");

            return st.ToString().TrimEnd();
        }

    }
}
