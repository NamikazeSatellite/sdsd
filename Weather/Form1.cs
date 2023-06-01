using Newtonsoft.Json;
using System.Net;

namespace Weather;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        GetWeather();
    }
    string APIKey = "c2448e1589cfe3c36b4c38c52cd3dfb9";
    string unit = "metric";
    string unit1 = "Km/h";
    void GetWeather()
    {
        using (WebClient web = new WebClient())
        {
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units={2}", cityTextBox.Text, APIKey, unit);
            var json = web.DownloadString(url);
            WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
            pictureBox.ImageLocation = "C:\\Users\\hp\\Source\\Repos\\Weather\\Data\\" + info.weather[0].icon + ".png";
            tempLabel.Text = Math.Round(info.main.temp).ToString() + "°";
            conditionText.Text = info.weather[0].main;
            humidityLabel.Text = info.main.humidity + "%";
            pressureLabel.Text = info.main.pressure + " hPa";
            windSpeedLabel.Text = Math.Round(info.wind.speed).ToString() + unit1;
            windDirectionLabel.Text = info.wind.deg.ToString() + "°";
            sunriseLabel.Text = ConvertDateTime(info.sys.sunrise).ToShortTimeString();
            sunsetLabel.Text = ConvertDateTime(info.sys.sunset).ToShortTimeString();
            DateTime ConvertDateTime(long milisec)
            {
                DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(milisec).ToLocalTime();
                return day;
            }
        }
    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void cityTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void tempLabel_Click(object sender, EventArgs e)
    {

    }

    private void convertToFarentheitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        unit = "imperial";
        unit1 = "Mph";
    }

    private void dayForecastToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2(cityTextBox.Text);
        form2.Show();
    }
}