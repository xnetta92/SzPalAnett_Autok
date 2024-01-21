using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzPalAnett_Autok
{
    internal class Cars
    {
        string LicPlate;
        string Make;
        string Model;
        int ManDate;
        string Validity;
        int Price;
        int Km;
        int EngineSize;
        int Mass;
        int Horsepower;


        public string LicPlate { get => LicPlate; set => LicPlate = value; }
        public string Make { get => Make; set => Make = value; }
        public string Model { get => Model; set => Model = value; }
        public int ManDate { get => ManDate; set => ManDate = value; }
        public string Validity { get => Validity; set => Validity = value; }
        public int Price { get => Price; set => Price = value; }
        public int Km { get => Km; set => Km = value; }
        public int EngineSize { get => EngineSize; set => EngineSize = value; }
        public int Mass { get => Mass; set => Mass = value; }
        public int Horsepower { get => Horsepower; set => Horsepower = value; }

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
