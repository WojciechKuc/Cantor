using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kantor
{
    
    
    
    public partial class Form1 : Form
    {

        private static Form1 instance;

        public Form1()

        {
  
            InitializeComponent();
            comboBox1.Text = "USD";
            comboBox2.Text = "PLN";

        }

public static Form1 GetInstance
{
get
{
    if (instance == null || instance.IsDisposed)
    {
        instance = new Form1();
    }
    return instance;
}
}
 
        private void button1_Click(object sender, EventArgs e)
        {
            
            double i;
            i = float.Parse(textBox1.Text);

            //PLN -> USD
            if (comboBox2.SelectedItem.ToString()  == "PLN" && comboBox1.SelectedItem.ToString()  == "USD")
            {
                ConvertClient PLNUSDClient = new ConvertClient(new PLNUSD());
                label1.Text = PLNUSDClient.Calculate(i).ToString() + " USD"; 
            }

            //PLN -> EURO
            else if (comboBox2.SelectedItem.ToString() == "PLN" && comboBox1.SelectedItem.ToString() == "EUR")
            {
                ConvertClient PLNEURClient = new ConvertClient(new PLNEUR());
                label1.Text = PLNEURClient.Calculate(i).ToString() + " EUR";
            }

            //USD -> PLN
            else if (comboBox2.SelectedItem.ToString() == "USD" && comboBox1.SelectedItem.ToString() == "PLN")
            {
                ConvertClient USDPLNClient = new ConvertClient(new USDPLN());
                label1.Text = USDPLNClient.Calculate(i).ToString() + " PLN";
            }

            //USD -> EURO
            else if (comboBox2.SelectedItem.ToString() == "USD" && comboBox1.SelectedItem.ToString() == "EUR")
            {
                ConvertClient USDEURClient = new ConvertClient(new USDEUR());
                label1.Text = USDEURClient.Calculate(i).ToString() + " EUR";
            }

            //EURO -> PLN
            else if (comboBox2.SelectedItem.ToString() == "EUR" && comboBox1.SelectedItem.ToString() == "PLN")
            {
                ConvertClient EURPLNClient = new ConvertClient(new EURPLN());
                label1.Text = EURPLNClient.Calculate(i).ToString() + " PLN";
            }

            //Euro -> USD
            else if (comboBox2.SelectedItem.ToString() == "EUR" && comboBox1.SelectedItem.ToString() == "USD")
            {
                ConvertClient EURUSDClient = new ConvertClient(new EURUSD());
                label1.Text = EURUSDClient.Calculate(i).ToString() + " USD";
            }

            else if (comboBox2.SelectedItem.ToString() == comboBox1.SelectedItem.ToString())
            {

                label1.Text = "Wybierz różne waluty";
            }

        }

        private void txtbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
