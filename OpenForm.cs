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
                cb.Text = brand; //-- szöveg beállítása
                cb.Checked = true;
                cb.Location = new Point(10, panel_Make.Controls.Count * 20);
               //cb.CheckedChanged += new EventHandler(gyarto_valtozott);
                panel_Make.Controls.Add(cb);
            }
            
        }
    }
}
