using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SzPalAnett_Autok
{
    internal class DataBase
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public DataBase()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "anett";
            builder.Password = "7112";
            builder.Database = "autok";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            sql = conn.CreateCommand();
            try
            {
                connectionOpen();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                connectionClose();
            }
        }

        private void connectionOpen()
        {
            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
        }

        private void connectionClose()
        {
            if (conn.State != System.Data.ConnectionState.Closed) conn.Close();
        }

        internal List<Cars> getAllCars()
        {
            List<Cars> cars = new List<Cars>();
            sql.CommandText = "SELECT * FROM `auto` ORDER BY `marka`";
            try
            {
                connectionOpen();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string LicPlate = dr.GetString("rendszam");
                        string Make = dr.GetString("marka");
                        string Model = dr.GetString("modell");
                        int ManDate = dr.GetInt32("gyartasiev");
                        string Validity = dr.GetDateTime("forgalmiErvenyesseg").ToString();
                        int Price = dr.GetInt32("vetelar");
                        int Km = dr.GetInt32("kmallas");
                        int EngineSize = dr.GetInt32("hengerűrtartalom");
                        int Mass = dr.GetInt32("tomeg");
                        int Horsepower = dr.GetInt32("teljesitmeny");
                        cars.Add(new Cars(LicPlate, Make, Model, ManDate, Validity, Price, Km, EngineSize, Mass, Horsepower));

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectionClose();
            }
            return cars;
        }


    }
}
