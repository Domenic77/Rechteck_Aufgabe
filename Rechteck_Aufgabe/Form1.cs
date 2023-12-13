using System;
using System.Windows.Forms;


namespace Rechteck_Aufgabe 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void berechnen_Click(object sender, EventArgs e)
        {

            if (double.TryParse(widthTextbox.Text, out double width) && double.TryParse(heightTextbox.Text, out double height))
            {
                Rechteck rechteck = new Rechteck();

                rechteck.Height = height;
                rechteck.Width = width;

                string flaeche = rechteck.GetArea().ToString();

                textBox1.Text = $"Fläche: {flaeche}";
            }
        }
    }
}