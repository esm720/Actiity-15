using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actiity_15
{
    public partial class Form2 : Form
    {
        static string astroSign;
        public Form2()
        {
            InitializeComponent();
        }
        //Here we receive the data needed to determine the right horoscope
        private void Form2_Load(object sender, EventArgs e)
        {
            using(Form1 form1 = new Form1())
            {
                astroSign = form1.transferAstroSign;
                SignLabel.Text = astroSign;
                showSign();
            }
        }
        //Here we compare to see what is the right image to show
        private void showSign()
        {
            if (astroSign.Equals("Aries")){
            AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Aries.jpg");
            
            }
            if (astroSign.Equals("Taurus"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Taurus.jpg");

            }
            if (astroSign.Equals("Gemini"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Gemini.jpg");

            }
            if (astroSign.Equals("Cancer"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Cancer.jpg");

            }
            if (astroSign.Equals("Leo"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Leo.jpg");

            }
            if (astroSign.Equals("Virgo"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Virgo.jpg");

            }
            if (astroSign.Equals("Libra"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Libra.jpg");

            }
            if (astroSign.Equals("Scorpio"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Scorpio.jpg");

            }
            if (astroSign.Equals("Sagittarius"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Sagittarus.jpg");

            }
            if (astroSign.Equals("Capricorn"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Capricorn.jpg");

            }
            if (astroSign.Equals("Aquarius"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Aquaries.jpg");

            }
            if (astroSign.Equals("Pisces"))
            {
                AstroPicBox.Image = Image.FromFile("C:\\Users\\esm72\\source\\repos\\Actiity 15\\images\\Pisces.jpg");

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
