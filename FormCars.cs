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
                    uploadData();
                    break;
                case "delete":
                    this.Text = "Delet car";
                    button_action.Text = "Delete";
                    button_action.BackColor = Color.Red;
                    button_action.Click += new EventHandler(deleteCars);
                    uploadData();
                    break;

            }
        }

        private void uploadData()
        {
            Cars cars = (Cars)Program.openForm.listBox_Cars.SelectedItem;
            cars.LicPlate = textBox_licplate.Text;
            cars.Make = textBox_make.Text;
            cars.Model = textBox_model.Text;
            cars.ManDate = Decimal.ToInt32(numericUpDown_manDate.Value);
            cars.Validity = dateTimePicker_validity.Value.ToString();
            cars.Price = Decimal.ToInt32(numericUpDown_price.Value);
            cars.Km = Decimal.ToInt32(numericUpDown_km.Value);
            cars.EngineSize = Decimal.ToInt32(numericUpDown_CC.Value);
            cars.Mass = Decimal.ToInt32(numericUpDown_mass.Value);
            cars.Horsepower = Decimal.ToInt32(numericUpDown_Hp.Value);
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
            cars.Validity = dateTimePicker_validity.Value.ToString();
            cars.Price = Decimal.ToInt32(numericUpDown_price.Value);
            cars.Km = Decimal.ToInt32(numericUpDown_km.Value);
            cars.EngineSize = Decimal.ToInt32(numericUpDown_CC.Value);
            cars.Mass = Decimal.ToInt32(numericUpDown_mass.Value);
            cars.Horsepower = Decimal.ToInt32(numericUpDown_Hp.Value);
            Program.db.updateCars(cars);
        }

        private void insertCars(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
