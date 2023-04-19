using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky19042023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text = "";
            int n = 0;
            //if(int.TryParse(textBox2.Text, out n)){
            try
            {
                n = int.Parse(textBox2.Text);
                int[] pole = new int[n];
                Random rng = new Random();
                for(int i = 0;i< n; i++)
                {
                    pole[i] = rng.Next(1, 20);
                }
                foreach (int neg in pole)
                {
                    listBox1.Items.Add(neg);
                }
                int kolik = pole[5];
                double cislo = Math.Pow(pole[0], kolik);
                label1.Text = "První číslo na ntou(šesté číslo):" + cislo.ToString();
                

                //}
                //int vysledek = 0;
                //for (int i = 0; i < n && i < textBox1.Lines.Count(); i++)
                //{
                //    try
                //    {
                //        checked { vysledek += int.Parse(textBox1.Lines[i]); }
                //    }
                //    catch(FormatException ex)
                //    {

                //    }
                //    catch(ArithmeticException k) { }

                //}
                //label3.Text = vysledek.ToString();
            }
            catch (IndexOutOfRangeException jj)
            {
                label3.Text = jj.Message.ToString();
            }
            catch (FormatException ex)
            {
                label3.Text = ex.Message.ToString();
            }
            catch(OverflowException ex)
            {
                label3.Text = ex.Message.ToString();
                
            }
            catch(Exception bug)
            {
                label3.Text = bug.Message.ToString();
            }
        }
    }
}
