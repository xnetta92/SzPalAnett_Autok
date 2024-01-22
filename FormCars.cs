using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzPalAnett_Autok
{
    public partial class FormCars : Form
    {
        string action;
        public FormCars(string action)
        { 
            InitializeComponent();
            this.action = action;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormCars_Load(object sender, EventArgs e)
        {
            switch (action)
            {
                case "add":
                    this.Text = "New car";
                    button_action.Text = "Submit";
                    button_action.BackColor = Color.Green;
                    button_action.Click += new EventHandler(insertCars);
                    break;
                case "edit":
                    this.Text = "Edit";
                    button_action.Text = "Edit";
                    button_action.BackColor = Color.Blue;
                    button_action.Click += new EventHandler(updateCars);
                    uploadData(Program.openForm.listBox_Cars.SelectedIndex);
                    break;
                case "delete":
                    this.Text = "Delete car";
                    button_action.Text = "Delete";
                    button_action.BackColor = Color.Red;
                    button_action.Click += new EventHandler(deleteCars);
                    uploadData(Program.openForm.listBox_Cars.SelectedIndex); // < nem jo az index amit ad (ha a teljes SeletedItem -et adom az sem ad vissza jo ertekeket)
                    break;

            }
        }

        private void uploadData(int index) // < szeretnem beadni neki a listBox_Cars.SelectedIndex -et de az nem jo erteket ad vissza :(
        {
            Cars cars = Program.cars[3]; // < ha fixen adok egy indexet visszaadja a hozza tartozo Cars objectet 
            textBox_licplate.Text = cars.LicPlate;
            textBox_make.Text = cars.Make;
            textBox_model.Text=cars.Model;
            numericUpDown_manDate.Value = (decimal)cars.ManDate;
            maskedTextBox_validity.Text = cars.Validity;
            numericUpDown_price.Value = (decimal)cars.Price;
            numericUpDown_km.Value = (decimal)cars.Km;
            numericUpDown_CC.Value = (decimal)cars.EngineSize;
            numericUpDown_mass.Value = (decimal)cars.Mass;
            numericUpDown_Hp.Value = (decimal)cars.Horsepower;

        }

        private void deleteCars(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void updateCars(object sender, EventArgs e)
        {

            Cars cars = new Cars();
            cars.LicPlate = textBox_licplate.Text;
            cars.Make = textBox_make.Text;
            cars.Model = textBox_model.Text;
            cars.ManDate = Decimal.ToInt32(numericUpDown_manDate.Value);
            cars.Validity = maskedTextBox_validity.Text;
            cars.Price = Decimal.ToInt32(numericUpDown_price.Value);
            cars.Km = Decimal.ToInt32(numericUpDown_km.Value);
            cars.EngineSize = Decimal.ToInt32(numericUpDown_CC.Value);
            cars.Mass = Decimal.ToInt32(numericUpDown_mass.Value);
            cars.Horsepower = Decimal.ToInt32(numericUpDown_Hp.Value);
            Program.db.updateCars(cars);
        }

        private void insertCars(object sender, EventArgs e)
        {
            Cars newCar = new Cars();
            newCar.LicPlate = textBox_licplate.Text;
            newCar.Make = textBox_make.Text;
            newCar.Model = textBox_model.Text;
            newCar.ManDate = Decimal.ToInt32(numericUpDown_manDate.Value);
            newCar.Validity = maskedTextBox_validity.Text;
            newCar.Price = Decimal.ToInt32(numericUpDown_price.Value);
            newCar.Km = Decimal.ToInt32(numericUpDown_km.Value);
            newCar.EngineSize = Decimal.ToInt32(numericUpDown_CC.Value);
            newCar.Mass = Decimal.ToInt32(numericUpDown_mass.Value);
            newCar.Horsepower = Decimal.ToInt32(numericUpDown_Hp.Value);

            
            Program.db.insertCars(newCar);


            Program.openForm.updateCars();

            this.Close();

        }
    }
}
