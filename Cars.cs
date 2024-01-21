using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzPalAnett_Autok
{
    internal class Cars
    {
        string licPlate;
        string make;
        string model;
        int manDate;
        string validity;
        int price;
        int km;
        int engineSize;
        int mass;
        int horsepower;


        public string LicPlate { get => licPlate; set => licPlate = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int ManDate { get => manDate; set => manDate = value; }
        public string Validity { get => validity; set => validity = value; }
        public int Price { get => price; set => price = value; }
        public int Km { get => km; set => km = value; }
        public int EngineSize { get => engineSize; set => engineSize = value; }
        public int Mass { get => mass; set => mass = value; }
        public int Horsepower { get => horsepower; set => horsepower = value; }

        public Cars(string licPlate, string make, string model, int manDate, string validity, int price, int km, int engineSize, int mass, int horsepower)
        {
            LicPlate = licPlate;
            Make = make;
            Model = model;
            ManDate = manDate;
            Validity = validity;
            Price = price;
            Km = km;
            EngineSize = engineSize;
            Mass = mass;
            Horsepower = horsepower;
        }

        public Cars()
        {
        }

        public override string ToString()
        {
            return $"{this.Make} {this.Model} ({this.Price})";
        }
    }
}
