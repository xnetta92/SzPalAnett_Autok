using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzPalAnett_Autok
{
    internal static class Program
    {
        public static List<Cars> cars = new List<Cars>();
        public static DataBase db = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            db = new DataBase();
            cars = db.getAllCars();
            Application.Run(new OpenForm());
        }
    }
}
