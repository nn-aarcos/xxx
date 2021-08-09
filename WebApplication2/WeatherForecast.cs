using System;

namespace WebApplication2
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class recibe
    {
        public string valor { get; set; }
    }

    [Obsolete("ya usar clase respuesta 2")]
    public class respuesta1
    {
        public string mensaje { get; set; }


    }
    public class respuesta2
    {
        public string mensaje { get; set; }


    }
}
