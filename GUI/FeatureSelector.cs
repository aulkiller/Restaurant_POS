using GUI.StaffWorking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FeatureSelector : Form
    {
        public FeatureSelector()
        {
            InitializeComponent();
            this.Text = Utilities.UtilsForm.GetFormTitle(this.Text);
        }

        private void btnSystemSetup_Click(object sender, EventArgs e)
        {
            new RestaurantSetup().ShowDialog();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            new TablesStatus().ShowDialog();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            new Analytics().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new TablesStatus().ShowDialog();
        }

        private void FeatureSelector_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new RestaurantSetup().ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Analytics().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TablesStatus().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RestaurantSetup().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Analytics().ShowDialog();
        }
    }
}
