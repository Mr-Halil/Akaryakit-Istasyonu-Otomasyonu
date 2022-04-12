using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akaryakıt_İstasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }



        double depo_benzin_95 = 0, depo_benzin_97 = 0, depo_dizel = 0, depo_EURO_DİZEL = 0, depo_LPG = 0;
        double Eklenen_benzin_95 = 0, Eklenen_benzin_97 = 0, Eklenen_dizel = 0, Eklenen_EURO_DİZEL = 0, Eklenen_LPG = 0;


        double Fiyat_benzin_95 = 0, Fiyat_benzin_97 = 0, Fiyat_dizel = 0, Fiyat_EURO_DİZEL = 0, Fiyat_LPG = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        double Satilan_benzin_95 = 0, Satilan_benzin_97 = 0, Satilan_dizel = 0, Satilan_EURO_DİZEL = 0, Satilan_LPG = 0;

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Satilan_benzin_95 = double.Parse(numericUpDown1.Value.ToString());
            Satilan_benzin_97 = double.Parse(numericUpDown2.Value.ToString());
            Satilan_dizel = double.Parse(numericUpDown3.Value.ToString());
            Satilan_EURO_DİZEL = double.Parse(numericUpDown4.Value.ToString());
            Satilan_LPG = double.Parse(numericUpDown5.Value.ToString());

            if (numericUpDown1.Enabled == true)
            {
                depo_benzin_95 = depo_benzin_95 - Satilan_benzin_95;
                label30.Text = Convert.ToString(Satilan_benzin_95*Fiyat_benzin_95);
            }
            else if (numericUpDown2.Enabled == true)
            {
                depo_benzin_97 = depo_benzin_97 - Satilan_benzin_97;
                label30.Text = Convert.ToString(Satilan_benzin_97 * Fiyat_benzin_97);
            }
            else if (numericUpDown3.Enabled == true)
            {
                depo_dizel = depo_dizel - Satilan_dizel;
                label30.Text = Convert.ToString(Satilan_dizel * Fiyat_dizel);
            }
            else if (numericUpDown4.Enabled == true)
            {
                depo_EURO_DİZEL = depo_EURO_DİZEL - Satilan_EURO_DİZEL;
                label30.Text = Convert.ToString(Satilan_EURO_DİZEL * Fiyat_EURO_DİZEL);
            }
            else if (numericUpDown5.Enabled == true)
            {
                depo_LPG = depo_LPG - Satilan_LPG;
                label30.Text = Convert.ToString(Satilan_LPG * Fiyat_LPG);
            }

            depo_bilgileri[0] = Convert.ToString(depo_benzin_95);
            depo_bilgileri[1] = Convert.ToString(depo_benzin_97);
            depo_bilgileri[2] = Convert.ToString(depo_dizel);
            depo_bilgileri[3] = Convert.ToString(depo_EURO_DİZEL);
            depo_bilgileri[4] = Convert.ToString(depo_LPG);

            System.IO.File.WriteAllLines(Application.StartupPath + "//Depo.txt", depo_bilgileri);

            depo_bilgileri_oku();
            depo_yaz();
            progressbar_guncelle();
            numericupdown_value();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;




        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Eklenen_benzin_95 = Convert.ToDouble(textBox1.Text);
                if (1000 < depo_benzin_95 + Eklenen_benzin_95 || Eklenen_benzin_95 <= 0)
                {
                    textBox1.Text = "HATA!!";
                }
                else
                {
                    depo_bilgileri[0] = Convert.ToString(depo_benzin_95+Eklenen_benzin_95);
                }
            }
            catch (Exception)
            {
                textBox1.Text = "HATA!!";
            }
            try
            {
                Eklenen_benzin_97 = Convert.ToDouble(textBox2.Text);
                if (1000 < depo_benzin_97 + Eklenen_benzin_97 || Eklenen_benzin_97 <= 0)
                {
                    textBox2.Text = "HATA!!";
                }
                else
                {
                    depo_bilgileri[1] = Convert.ToString(depo_benzin_97 + Eklenen_benzin_97);
                }
            }
            catch (Exception)
            {
                textBox2.Text = "HATA!!";
            }
            try
            {
                Eklenen_dizel = Convert.ToDouble(textBox3.Text);
                if (1000 < depo_dizel + Eklenen_dizel || Eklenen_dizel <= 0)
                {
                    textBox3.Text = "HATA!!";
                }
                else
                {
                    depo_bilgileri[2] = Convert.ToString(depo_dizel + Eklenen_dizel);
                }
            }
            catch (Exception)
            {
                textBox3.Text = "HATA!!";
            }
            try
            {
                Eklenen_EURO_DİZEL = Convert.ToDouble(textBox4.Text);
                if (1000 < depo_EURO_DİZEL + Eklenen_EURO_DİZEL || Eklenen_EURO_DİZEL <= 0)
                {
                    textBox4.Text = "HATA!!";
                }
                else
                {
                    depo_bilgileri[3] = Convert.ToString(depo_EURO_DİZEL + Eklenen_EURO_DİZEL);
                }
            }
            catch (Exception)
            {
                textBox4.Text = "HATA!!";
            }
            try
            {
                Eklenen_LPG = Convert.ToDouble(textBox5.Text);
                if (1000 < depo_LPG + Eklenen_LPG || Eklenen_LPG <= 0)
                {
                    textBox5.Text = "HATA!!";
                }
                else
                {
                    depo_bilgileri[4] = Convert.ToString(depo_LPG + Eklenen_LPG);
                }
            }
            catch (Exception)
            {
                textBox5.Text = "HATA!!";
            }

            System.IO.File.WriteAllLines(Application.StartupPath+"//Depo.txt", depo_bilgileri);

            depo_bilgileri_oku();
            depo_yaz();
            progressbar_guncelle();
            numericupdown_value();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Benzin 95")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Benzin 97")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Euro Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "LPG")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;
            }
        }

        String[] depo_bilgileri;
        String[] Fiyat_bilgileri;
        String[] yakit_turleri = {"Benzin 95","Benzin 97", "Dizel", "Euro Dizel", "LPG"};
        

        private void depo_bilgileri_oku()
        {
            depo_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\Depo.txt");

            depo_benzin_95 = Convert.ToDouble(depo_bilgileri[0]);
            depo_benzin_97 = Convert.ToDouble(depo_bilgileri[1]);
            depo_dizel = Convert.ToDouble(depo_bilgileri[2]);
            depo_EURO_DİZEL = Convert.ToDouble(depo_bilgileri[3]);
            depo_LPG = Convert.ToDouble(depo_bilgileri[4]);
        }

        private void Fiyat_bilgileri_oku()
        {
            Fiyat_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\Fiyat.txt");

            Fiyat_benzin_95 = Convert.ToDouble(Fiyat_bilgileri[0]);
            Fiyat_benzin_97 = Convert.ToDouble(Fiyat_bilgileri[1]);
            Fiyat_dizel = Convert.ToDouble(Fiyat_bilgileri[2]);
            Fiyat_EURO_DİZEL = Convert.ToDouble(Fiyat_bilgileri[3]);
            Fiyat_LPG = Convert.ToDouble(Fiyat_bilgileri[4]);
        }

        private void depo_yaz()
        {
            label2.Text = depo_benzin_95.ToString("N");
            label3.Text = depo_benzin_97.ToString("N");
            label5.Text = depo_dizel.ToString("N");
            label7.Text = depo_EURO_DİZEL.ToString("N");
            label9.Text = depo_LPG.ToString("N");
        }

        private void fiyat_yaz()
        {
            label19.Text = Fiyat_benzin_95.ToString("N");
            label17.Text = Fiyat_benzin_97.ToString("N");
            label15.Text = Fiyat_dizel.ToString("N");
            label13.Text = Fiyat_EURO_DİZEL.ToString("N");
            label11.Text = Fiyat_LPG.ToString("N");
        }

        private void progressbar_guncelle()
        {
            progressBar1.Maximum = 1000;
            progressBar2.Maximum = 1000;
            progressBar3.Maximum = 1000;
            progressBar4.Maximum = 1000;
            progressBar5.Maximum = 1000;


            progressBar1.Value = Convert.ToInt16(depo_benzin_95);
            progressBar2.Value = Convert.ToInt16(depo_benzin_97);
            progressBar3.Value = Convert.ToInt16(depo_dizel);
            progressBar4.Value = Convert.ToInt16(depo_EURO_DİZEL);
            progressBar5.Value = Convert.ToInt16(depo_LPG);
        }

        private void numericupdown_value()
        {
            numericUpDown1.Maximum = decimal.Parse(depo_benzin_95.ToString());
            numericUpDown2.Maximum = decimal.Parse(depo_benzin_97.ToString());
            numericUpDown3.Maximum = decimal.Parse(depo_dizel.ToString());
            numericUpDown4.Maximum = decimal.Parse(depo_EURO_DİZEL.ToString());
            numericUpDown5.Maximum = decimal.Parse(depo_LPG.ToString());

        }


        private void label30_Click(object sender, EventArgs e)
        {
            
        }


























        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "AKARYAKIT UYGULAMASI";

            depo_bilgileri_oku();
            depo_yaz();
            progressbar_guncelle();

            Fiyat_bilgileri_oku();
            fiyat_yaz();
            numericupdown_value();

            comboBox1.Items.AddRange(yakit_turleri);

            
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown5.DecimalPlaces = 2;

            numericUpDown1.Increment = 0.1M;
            numericUpDown2.Increment = 0.1M;
            numericUpDown3.Increment = 0.1M;
            numericUpDown4.Increment = 0.1M;
            numericUpDown5.Increment = 0.1M;

            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;
        }
    }
}
