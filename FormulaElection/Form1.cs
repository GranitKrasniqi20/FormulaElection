using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaElection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double> PerqindjetPartiake;

        private void button1_Click(object sender, EventArgs e)
        {
            PerqindjetPartiake = new List<double>();
            double totaliPerqindjeve = 0;
            int numriPlote = 0;
            int numriPjeseshem=0;
            double koeficientiPerqindjeve;

            List<double> listaDoubleValue = new List<double>();
            int[] varguIntValue = new int[4];

            double s1, s2, s3, s4, s5, s6, s7, s8, s11, s12, s13, s14;
            int intValueS11, intValueS12, intValueS13, intValueS14;
            double doubleValueS11, doubleValueS12, doubleValueS13, doubleValueS14;

            if(string.IsNullOrEmpty(textBox1.Text) == true) textBox1.Text = "0";
            if(string.IsNullOrEmpty(textBox2.Text) == true) textBox2.Text = "0";
            if(string.IsNullOrEmpty(textBox3.Text) == true) textBox3.Text = "0";
            if(string.IsNullOrEmpty(textBox4.Text) == true) textBox4.Text = "0";

            s1 = double.Parse(textBox1.Text);
            if (s1 >= 5.0) { PerqindjetPartiake.Add(s1); }

            s2 = double.Parse(textBox2.Text);
            if (s2 >= 5.0) { PerqindjetPartiake.Add(s2); }

            s3 = double.Parse(textBox3.Text);
            if (s3 >= 5.0) { PerqindjetPartiake.Add(s3); }

            s4 = double.Parse(textBox4.Text);
            if (s4 >= 5.0) { PerqindjetPartiake.Add(s4); }

            foreach (var item in PerqindjetPartiake)
            {
                totaliPerqindjeve += item;
            }

            if (totaliPerqindjeve <= 100 && totaliPerqindjeve >= 0)
            {
                textBox5.Text = (100 - totaliPerqindjeve).ToString();
                koeficientiPerqindjeve = 100 / totaliPerqindjeve;
            }
            else throw new Exception();

            if (s1 >= 5.0)
            {
                s11 = (s1 * koeficientiPerqindjeve);
                textBox11.Text = s11.ToString();
                intValueS11 = (int)s11;
                varguIntValue[0] = intValueS11;
                numriPlote += intValueS11;
                doubleValueS11 = s11 - intValueS11;
                //listaDoubleValue.Add(doubleValueS11);
                listaDoubleValue.Add(s11);
            }
            else textBox11.Text ="0";

            if (s2 >= 5.0)
            {
                s12 = (s2 * koeficientiPerqindjeve);
                textBox12.Text = s12.ToString();
                intValueS12 = (int)s12;
                varguIntValue[1] = intValueS12;
                numriPlote += intValueS12;
                doubleValueS12 = s12 - intValueS12;
                //listaDoubleValue.Add(doubleValueS12);
                listaDoubleValue.Add(s12);
            }
            else textBox12.Text = "0";

            if (s3 >= 5.0)
            {
                s13 = (s3 * koeficientiPerqindjeve);
                textBox13.Text = s13.ToString();
                intValueS13 = (int)s13;
                varguIntValue[2] = intValueS13;
                numriPlote += intValueS13;
                doubleValueS13 = s13 - intValueS13;
                //listaDoubleValue.Add(doubleValueS13);
                listaDoubleValue.Add(s13);
            }
            else textBox13.Text = "0";

            if (s4 >= 5.0)
            {
                s14 = (s4 * koeficientiPerqindjeve);
                textBox14.Text = s14.ToString();
                intValueS14 = (int)s14;
                varguIntValue[3] = intValueS14;
                numriPlote += intValueS14;
                doubleValueS14 = s14 - intValueS14;
                //listaDoubleValue.Add(doubleValueS14);
                listaDoubleValue.Add(s14);
            }
            else textBox14.Text = "0";

            numriPjeseshem = 100 - numriPlote;

            

            List<int> listaIntValue = new List<int>();
            for (int i = 0; i < listaDoubleValue.Count; i++)
            {
                listaIntValue.Add((int)listaDoubleValue[i]);
            }

            for (int i = 0; i < numriPjeseshem; i++)
            {
                double itemValue = Helper.maxElement(listaDoubleValue);

                int index = listaDoubleValue.IndexOf(itemValue);
                listaDoubleValue[index] = 0;
                listaIntValue[index] += 1;// itemValue + 1;
            }


            if (s1 >= 5.0)
            {
                textBox6.Text = listaIntValue[0].ToString();
            }
            else 
            { 
                textBox6.Text = ""; 
                textBox11.Text = "";
            }

            if (s2 >= 5.0)
            {
                textBox7.Text = listaIntValue[1].ToString();
            }
            else
            {
                textBox7.Text = "";
                textBox12.Text = "";
            }

            if (s3 >= 5.0)
            {
                textBox8.Text = listaIntValue[2].ToString();
            }
            else
            {
                textBox8.Text = "";
                textBox13.Text = "";
            }

            if (s4 >= 5.0)
            {
                textBox9.Text = listaIntValue[3].ToString();
            }
            else
            {
                textBox9.Text = "";
                textBox14.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerqindjetPartiake = null;

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";

            textBox5.Text = "100";

            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            textBox1.Text = (1.07 * random.Next(30,35)).ToString();
            textBox2.Text = (1.08 * random.Next(20,25)).ToString();
            textBox3.Text = (1.09 * random.Next(10,15)).ToString();
            textBox4.Text = (1.11 * random.Next(4,10)).ToString();

            textBox5.Text = (100 - double.Parse(textBox1.Text) - double.Parse(textBox2.Text)
                - double.Parse(textBox3.Text)- double.Parse(textBox4.Text)).ToString();
        }

    }
}
