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
    /*
     * Enrique Sanchezmurillo
     * Activity 15
     * CST-150
     * 21 AUG 2022
     */
    public partial class Form1 : Form
    {
        static int year;
        static int month;
        static string strMonth;
        static int day;
        static string astro_sign;

        public Form1() : base()
        {
           
            InitializeComponent();
            HoroscopeButton.Visible = false;
            //Populate the FIRST Combo Box
            //creating properties of labels
            Font LargeFont = new Font("Arial", 12);
            Label yearInputLabel = new Label();
            yearInputLabel.Location = new Point(70, 40);
            yearInputLabel.Size = new Size(80, 20);
            yearInputLabel.Text = "Birth Year: ";
            yearInputLabel.Font = LargeFont;
            //Adding the label to the form
            this.Controls.Add(yearInputLabel);

            // Creating comboBox
            ComboBox yearComboBox = new ComboBox();
            yearComboBox.Location = new Point(150, 40);
            yearComboBox.Size = new Size(100, 20);
            yearComboBox.Name = "yearInputBox";
            yearComboBox.Font = LargeFont;
            int ninetiesYear;
            //Fill box with years
            for (int i = 0; i < 10; i++)
            {
                ninetiesYear = 1990 + i;
                yearComboBox.Items.Add(ninetiesYear);
            }
            //add comboBox
            this.Controls.Add(yearComboBox);
            //Event handler once user selects a value
            yearComboBox.SelectedValueChanged += new EventHandler(yearBoxCombo_SelectedValueChanged);
            
        }

        private void yearBoxCombo_SelectedValueChanged(object sender, EventArgs e)
        {

            ComboBox yearComboBox = (ComboBox)sender;
            string selectedYear = yearComboBox.SelectedItem.ToString();
            year = int.Parse(selectedYear);

            //Creating Month Label
            Font LargeFont = new Font("Arial", 12);
            Label monthLabel = new Label();
            monthLabel.Location = new Point(60, 90);
            monthLabel.Size = new Size(90, 20);
            monthLabel.Text = "Birth Month: ";
            monthLabel.Font = LargeFont;
            //Adding the label to the form
            this.Controls.Add(monthLabel);

            // Creating comboBox
            ComboBox monthComboBox = new ComboBox();
            monthComboBox.Location = new Point(150, 90);
            monthComboBox.Size = new Size(100, 20);
            monthComboBox.Name = "monthInputBox";
            monthComboBox.Font = LargeFont;
            //add box for month
            int userMonth;
            //Fill box with years
            for (int i = 0; i < 12; i++)
            {
                userMonth = i + 1;
                monthComboBox.Items.Add(userMonth);
            }
            this.Controls.Add(monthComboBox);
            //Event handler once user selects month
            monthComboBox.SelectedValueChanged += new EventHandler(monthBoxCombo_SelectedValueChanged);
            //Make Chinese new year button visible
        }

        private void monthBoxCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            
            ComboBox monthComboBox = (ComboBox)sender;
            string selectedMonth = monthComboBox.SelectedItem.ToString();
            month = int.Parse(selectedMonth);

            //Creating Day Label
            Font LargeFont = new Font("Arial", 12);
            Label dayLabel = new Label();
            dayLabel.Location = new Point(60, 140);
            dayLabel.Size = new Size(90, 20);
            dayLabel.Text = "Birth Day: ";
            dayLabel.Font = LargeFont;
            //Adding the label to the form
            this.Controls.Add(dayLabel);

            // Creating comboBox
            ComboBox dayComboBox = new ComboBox();
            dayComboBox.Location = new Point(150, 140);
            dayComboBox.Size = new Size(100, 20);
            dayComboBox.Name = "dayInputBox";
            dayComboBox.Font = LargeFont;
            //add box for Day
            int userDay;
            int daysInMonth = CheckDaysInMonth();
            //Checking to see how many times to iterate the for loop.
            CheckDaysInMonth(); 
            //Fill box with years
            for (int i = 0; i < daysInMonth; i++)
            {
                userDay = i + 1;
                dayComboBox.Items.Add(userDay);
            }
            this.Controls.Add(dayComboBox);
            //Get the full date
            dayComboBox.SelectedValueChanged += new EventHandler(dayBoxCombo_SelectedValueChanged);

        }

        private void dayBoxCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox dayComboBox = (ComboBox)sender;
            string selectedDay = dayComboBox.SelectedItem.ToString();
            day = int.Parse(selectedDay);
            HoroscopeButton.Visible = true;

            setDate();
        }


        //Method to check how many days are in the selected month
        private int CheckDaysInMonth()
        {
            int days = 0;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                days = 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                days = 30;
            }
            else
            {
                if (year % 4 == 0)
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            
            return days; 
        }
        
        private void setDate()
        {
            switch (month)
            {
                case 1: strMonth = "January";
                    break;

                case 2: strMonth = "February";
                    break;

                case 3:
                    strMonth = "March";
                    break;

                case 4:
                    strMonth = "April";
                    break;
                case 5:
                    strMonth = "May";
                    break;

                case 6:
                    strMonth = "June";
                    break;
                case 7:
                    strMonth = "July";
                    break;

                case 8:
                    strMonth = "August";
                    break;
                case 9:
                    strMonth = "September";
                    break;

                case 10:
                    strMonth = "October";
                    break;
                case 11:
                    strMonth = "November";
                    break;

                case 12:
                    strMonth = "December";
                    break;
            }
            fullDateLabel.Text = day + " " + strMonth + ", " + year;
        }

        private void HoroscopeButton_Click(object sender, EventArgs e)
        {
            //Creating form 2 object
            Form2 form2 = new Form2();
            // checks month and date within the
            // valid range of a specified zodiac
            if (strMonth.ToLower() == "december"){
         
                if (day < 22)
                astro_sign = "Sagittarius";
                else
                astro_sign ="Capricorn";
            }
         
            else if (strMonth.ToLower() == "january"){
                if (day < 20)
                astro_sign = "Capricorn";
                else
                astro_sign = "Aquarius";
            }
         
            else if (strMonth.ToLower() == "february"){
                if (day < 19)
                astro_sign = "Aquarius";
                else
                astro_sign = "Pisces";
            }
         
            else if(strMonth.ToLower() == "march"){
                if (day < 21)
                astro_sign = "Pisces";
                else
                astro_sign = "Aries";
            }
            else if (strMonth.ToLower() == "april"){
                if (day < 20)
                astro_sign = "Aries";
                else
                astro_sign = "Taurus";
            }
         
            else if (strMonth.ToLower() == "may"){
                if (day < 21)
                astro_sign = "Taurus";
                else
                astro_sign = "Gemini";
            }
         
            else if(strMonth.ToLower() == "june"){
                if (day < 21)
                astro_sign = "Gemini";
                else
                astro_sign = "Cancer";
            }
         
            else if (strMonth.ToLower() == "july"){
                if (day < 23)
                astro_sign = "Cancer";
                else
                astro_sign = "Leo";
            }
         
            else if(strMonth.ToLower() == "august"){
                if (day < 23)
                astro_sign = "Leo";
                else
                astro_sign = "Virgo";
            }
         
            else if (strMonth.ToLower() == "september"){
                if (day < 23)
                astro_sign = "Virgo";
                else
                astro_sign = "Libra";
            }
         
            else if (strMonth.ToLower() == "october"){
                if (day < 23)
                astro_sign = "Libra";
                else
                astro_sign = "Scorpio";
            }
         
            else if (strMonth.ToLower() == "november"){
                if (day < 22)
                astro_sign = "Scorpio";
                else
                astro_sign = "Sagittarius";
            }
            
            form2.ShowDialog();

        }
        //Here we transfer the information to the second form
        public string transferAstroSign
        {
            get
            {
                return astro_sign;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
