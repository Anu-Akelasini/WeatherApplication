﻿namespace TodoBlazor.DTOs.OpenWeather.Forecast
{
    public class WeatherForecastDTO
    {
        public string cod { get; set; }
        public double message { get; set; }
        public double cnt { get; set; }
        public List<List> list { get; set; }
        public City city { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class City
    {
        public double id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public double population { get; set; }
        public double timezone { get; set; }
        public double sunrise { get; set; }
        public double sunset { get; set; }
    }

    public class Clouds
    {
        public double all { get; set; }
    }

    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public double visibility { get; set; }
        public double pop { get; set; }
        public Sys sys { get; set; }
        public string dt_txt { get; set; }
        public DateTime dtDateTime
        {
            get
            {
                return DateTime.Parse(dt_txt);
            }
        }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public double humidity { get; set; }
        public double temp_kf { get; set; }
    }


    public class Sys
    {
        public string pod { get; set; }
    }

    public class Weather
    {
        public double id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public string iconImgSrc
        {
            get
            {
                return $"http://openweathermap.org/img/wn/{icon}@2x.png";
            }
        }
    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
        public double gust { get; set; }
    }


}
