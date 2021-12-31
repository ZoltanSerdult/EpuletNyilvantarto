using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EpuletNyilvantarto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /*
           --Hibás az adatbetöltés--

           Adatbetoltes();
           */
        }

        private void Adatbetoltes()
        {
            if (File.Exists("epuletek.csv"))
            {
                using (StreamReader sr = new StreamReader("epuletek.csv"))
                {
                    while (sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        if (sor[0].Equals("csaladi"))
                        {
                            Csaladihaz uj = new Csaladihaz(
                                sor[1],
                                (Anyagok)Enum.Parse(typeof(Anyagok), sor[2]),
                                int.Parse(sor[3]),
                                DateTime.Parse(sor[4]),
                                DateTime.Parse(sor[5]),
                                int.Parse(sor[6]),
                                bool.Parse(sor[7]),
                                (TetoTipusa)Enum.Parse(typeof(TetoTipusa), sor[8]));
                            listBox_Epuletek.Items.Add(uj);
                        }
                        else
                        {
                            Tombhaz uj = new Tombhaz(
                                sor[1],
                                (Anyagok)Enum.Parse(typeof(Anyagok), sor[2]),
                                int.Parse(sor[3]),
                                DateTime.Parse(sor[4]),
                                DateTime.Parse(sor[5]),
                                int.Parse(sor[6]),
                                bool.Parse(sor[7]),
                                (Fenntartas)Enum.Parse(typeof(Fenntartas), sor[8]));
                            listBox_Epuletek.Items.Add(uj);
                        }
                    }
                }
            }
        }

        private void button_Csaladi_Click(object sender, EventArgs e)
        {
            Program.form_Csaladihaz.ShowDialog();
        }

        private void button_Tombhaz_Click(object sender, EventArgs e)
        {
            Program.form_Tombhaz.ShowDialog();
        }

        private void Ment_Epuletek()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("epuletek.csv"))
                {
                    foreach (var item in listBox_Epuletek.Items)
                    {
                        if (typeof(Csaladihaz) == item.GetType())
                        {
                            sw.WriteLine(((Csaladihaz)item).Kiir());
                        }
                        else
                        {
                            sw.WriteLine(((Tombhaz)item).Kiir());
                        }
                    }
                }
                MessageBox.Show("Sikeres Mentés", "MENTVE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valóban kilép\n(És autamikusan elment)"," ",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Ment_Epuletek();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button_Torol_Click(object sender, EventArgs e)
        {
            if (listBox_Epuletek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott Épület");
                return;
            }
            if (MessageBox.Show("Kivánja törölni az kiválasztott elemet","TÖRLÉS",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                listBox_Epuletek.Items.RemoveAt(listBox_Epuletek.SelectedIndex);

            }
        }

        private void button_Modosit_Click(object sender, EventArgs e)
        {
            if (listBox_Epuletek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott Épület");
                return;
            }
            Program.form_Csaladihaz.Muvelet = "modosit";
            Program.form_Csaladihaz.ShowDialog();
        }
    }
}
