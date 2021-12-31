using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpuletNyilvantarto
{
    public partial class Form_Tombhaz : Form
    {
        public Form_Tombhaz()
        {
            InitializeComponent();
        }

        private void button_Rogzit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_cim.Text))
            {
                return;
            }
            Anyagok anyag = (Anyagok)Enum.Parse(typeof(Anyagok),comboBox_Epitesanyagok.SelectedItem.ToString());
            Fenntartas fenntartas = (Fenntartas)Enum.Parse(typeof(Fenntartas),comboBox_Fenntartastipusa.ToString());
            Tombhaz uj = new Tombhaz
                (
                    textBox_cim.Text,
                    anyag,
                    (int)numericUpDown_Alapterulet.Value,
                    dateTimePicker_Munkakezdet.Value,
                    dateTimePicker_Munkaveg.Value,
                    (int)numericUpDown_Lakasokszama.Value,
                    checkBox_VaneEift.Checked,
                    fenntartas
                    );
            Program.form1.listBox_Epuletek.Items.Add(uj);
        }

        private void Form_Tombhaz_Load(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(Anyagok)))
            {
                comboBox_Epitesanyagok.Items.Add(item);
            }
            foreach (string item in Enum.GetNames(typeof(Fenntartas)))
            {
                comboBox_Fenntartastipusa.Items.Add(item);
            }
        }
    }
}
