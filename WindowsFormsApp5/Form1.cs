using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        WeatherInfo weatherInfo;
        private int panelIndex = 0;
        private int totalCities = 0;

        public Form1()
        {
            InitializeComponent();
            totalCities = SettingForm.FinalCities.Count;
            weatherInfo = new WeatherInfo();
            UpdateLabels();
            timer1.Interval = Int32.Parse(SettingForm.FinalRefreshTime) * 1000; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void lblAtmosphere2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelIndex++;

            if (panelIndex > totalCities)
            {
                panelIndex = 0;
            }

            UpdateLabels();
            
        }
        private void UpdateLabels()
        {
            WheatherData weatherData;
            try
            {
                weatherData = weatherInfo.GetWeatherData(SettingForm.FinalCities.ElementAt(panelIndex));
                label1.Text = SettingForm.FinalCities.ElementAt(panelIndex);
                lblHumidity.Text = $"Humidity: {weatherData.humidity}%";
                lblAtmosphere.Text = $"Atmosphere: {weatherData.atmosphere} Pa";
                lblTemperature.Text = $"Temperature: {weatherData.temperature}°C";
                
                //switch (panelIndex)
                //{
                //    case 1:
                //        weatherData = weatherInfo.GetWeatherData(SettingForm.FinalCities.ElementAt(1));
                //        label1.Text = MyStrings.Bengaluru;
                //        lblHumidity.Text = $"Humidity: {weatherData.humidity}%";
                //        lblAtmosphere.Text = $"Atmosphere: {weatherData.atmosphere} Pa";
                //        lblTemperature.Text = $"Temperature: {weatherData.temperature}°C";
                //        break;
                //    case 2:
                //        weatherData = weatherInfo.GetWeatherData("Varanesi");
                //        label1.Text = MyStrings.Varanasi;
                //        lblHumidity.Text = $"Humidity: {weatherData.humidity}%";
                //        lblAtmosphere.Text = $"Atmosphere: {weatherData.atmosphere} Pa";
                //        lblTemperature.Text = $"Temperature: {weatherData.temperature}°C";
                //        break;
                //    case 3:
                //        weatherData = weatherInfo.GetWeatherData("Medikeri");
                //        label1.Text = MyStrings.Madikeri;
                //        lblHumidity.Text = $"Humidity: {weatherData.humidity}%";
                //        lblAtmosphere.Text = $"Atmosphere: {weatherData.atmosphere} Pa";
                //        lblTemperature.Text = $"Temperature: {weatherData.temperature}°C";
                //        break;
                //}
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}



      

