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
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_Make_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            foreach (string brand in Program.cars.Select(a => a.Make).Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = brand;
                cb.Checked = true;
                cb.Location = new Point(10, panel_Make.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(make_changed);
                panel_Make.Controls.Add(cb);
            }
            updateCars();

        }

        private void make_changed(object sender, EventArgs e)
        {
            updateCars();
        }

        private void updateCars()
        {
            listBox_Cars.Items.Clear();
            
            List<string> chosen = new List<string>();
            foreach (CheckBox item in panel_Make.Controls)
            {
                if (item.Checked) { chosen.Add(item.Text); };
            }
            foreach (Cars item in Program.cars)
            {
                if (chosen.Contains(item.Make))
                {
                    listBox_Cars.Items.Add(item);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCars formCars = new FormCars("add");
            formCars.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Cars.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormCars formLaptop = new FormCars("edit");
            formLaptop.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Cars.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormCars formLaptop = new FormCars("delete");
            formLaptop.ShowDialog();
        }
    }
}
