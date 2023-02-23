using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class SettingForm : Form
    {
        public static List<string> FinalCities = new List<string>();
        public static string FinalRefreshTime = "";
        public SettingForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string cities = string.Empty;
            foreach (var item in checkedListBoxCities.CheckedItems)
            {
                FinalCities.Add(item.ToString());
                cities += item.ToString() + ",";
            }
            cities = cities.TrimEnd(',');
            Console.WriteLine(cities);
            FinalRefreshTime = comboBoxTime.SelectedItem.ToString();

            MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SettingForm_Load_1(object sender, EventArgs e)
        {
            checkedListBoxCities.Items.Add("Mumbai");
            checkedListBoxCities.Items.Add("Delhi");
            checkedListBoxCities.Items.Add("Kolkata");
            checkedListBoxCities.Items.Add("Chennai");
            checkedListBoxCities.Items.Add("Bangalore");
            checkedListBoxCities.CheckOnClick = true;

            comboBoxTime.Items.Add("5");
            comboBoxTime.Items.Add("10");
            comboBoxTime.Items.Add("15");
        }
    }
}
