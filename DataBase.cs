using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        internal void updateCars(Cars cars)
        {
            sql.CommandText = "UPDATE `auto` SET " +
                "`marka`=@marka," +
                "`modell`=@modell," +
                "`gyartasiev`=@gyartasiev," +
                "`forgalmiErvenyesseg`=@forgalmiErvenyesseg," +
                "`vetelar`=@vetelar," +
                "`kmallas`=@kmallas," +
                "`hengerűrtartalom`=@hengerűrtartalom," +
                "`tomeg`=@tomeg," +
                "`teljesitmeny`=@teljesitmeny " +
                "WHERE `rendszam`=@rendszam";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@marka", cars.Make);
            sql.Parameters.AddWithValue("@modell", cars.Model);
            sql.Parameters.AddWithValue("@gyartasiev", cars.ManDate);
            sql.Parameters.AddWithValue("@forgalmiErvenyesseg", DateTime.ParseExact(cars.Validity, "yyyy.MM.dd HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
            sql.Parameters.AddWithValue("@vetelar", cars.Price);
            sql.Parameters.AddWithValue("@kmallas", cars.Km);
            sql.Parameters.AddWithValue("@hengerűrtartalom", cars.EngineSize);
            sql.Parameters.AddWithValue("@tomeg", cars.Mass);
            sql.Parameters.AddWithValue("@teljesitmeny", cars.Horsepower);
            sql.Parameters.AddWithValue("@rendszam", cars.LicPlate);


            try
            {
                connectionOpen();
                sql.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connectionClose(); }


        }

        internal void deleteCars(Cars cars)
        {
            sql.CommandText = "DELETE FROM `auto` WHERE `rendszam`=@rendszam";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@rendszam", cars.LicPlate);

            try
            {
                connectionOpen();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connectionClose(); }
        }

        internal void insertCars(Cars newCar)
        {
            sql.CommandText = "INSERT INTO `auto` (`rendszam`, `marka`, `modell`, `gyartasiev`, `forgalmiErvenyesseg`, `vetelar`, `kmallas`, `hengerűrtartalom`, `tomeg`, `teljesitmeny`) " +
                              "VALUES (@rendszam, @marka, @modell, @gyartasiev, @forgalmiErvenyesseg, @vetelar, @kmallas, @hengerűrtartalom, @tomeg, @teljesitmeny)";

            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@rendszam", newCar.LicPlate);
            sql.Parameters.AddWithValue("@marka", newCar.Make);
            sql.Parameters.AddWithValue("@modell", newCar.Model);
            sql.Parameters.AddWithValue("@gyartasiev", newCar.ManDate);
            sql.Parameters.AddWithValue("@forgalmiErvenyesseg", newCar.Validity);
            sql.Parameters.AddWithValue("@vetelar", newCar.Price);
            sql.Parameters.AddWithValue("@kmallas", newCar.Km);
            sql.Parameters.AddWithValue("@hengerűrtartalom", newCar.EngineSize);
            sql.Parameters.AddWithValue("@tomeg", newCar.Mass);
            sql.Parameters.AddWithValue("@teljesitmeny", newCar.Horsepower);

            try
            {
                connectionOpen();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectionClose();
            }
        }
    }
}
