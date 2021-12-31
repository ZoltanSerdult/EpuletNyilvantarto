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
    public partial class Form_Csaladihaz : Form
    {
        public string Muvelet = "uj";
        public Form_Csaladihaz()
        {
            InitializeComponent();
        }

        private void Form_Csaladihaz_Load(object sender, EventArgs e)
        {
            if (Muvelet.Equals("modosit"))
            {
                Csaladihaz kiv = (Csaladihaz)Program.form1.listBox_Epuletek.SelectedItem;
                textBox_cim.Text = kiv.Cim;
                textBox_cim.ReadOnly = true;
                numericUpDown_Alapterulet.Value = kiv.Alapterulet;
                comboBox_Epitesanyagok.SelectedItem = kiv.Epitesanyag;
                comboBox_Epitesanyagok.Enabled = false;
                dateTimePicker_Munkakezdet.Value = kiv.Kezdes;
                dateTimePicker_Munkaveg.Value = kiv.Befejezes;
                numericUpDown_Ottelek.Value = kiv.Ottelok;
                checkBox_Garazs.Checked = kiv.VanGarazs;
                comboBox_Tetotipus.SelectedItem = kiv.Tetoanyag;
            }
            foreach (string item in Enum.GetNames(typeof(Anyagok)))
            {
                comboBox_Epitesanyagok.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(TetoTipusa)))
            {
                comboBox_Tetotipus.Items.Add(item);
            }
        }

        private void button_Rogzit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_cim.Text))
            {
                return;
            }
            TetoTipusa tetoTipusa = (TetoTipusa)Enum.Parse(typeof(TetoTipusa), comboBox_Tetotipus.SelectedItem.ToString());
            Anyagok epitesanyag = (Anyagok)Enum.Parse(typeof(Anyagok), comboBox_Epitesanyagok.SelectedItem.ToString());
            Csaladihaz uj = new Csaladihaz
            (
                textBox_cim.Text,
                epitesanyag,
                (int)numericUpDown_Alapterulet.Value,
                dateTimePicker_Munkakezdet.Value,
                dateTimePicker_Munkaveg.Value,
                (int)numericUpDown_Ottelek.Value,
                checkBox_Garazs.Checked,
                tetoTipusa
            );
            
            Program.form1.listBox_Epuletek.Items.Add(uj);
        }
    }
}
