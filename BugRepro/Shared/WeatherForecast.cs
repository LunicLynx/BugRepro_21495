using System;
using System.Collections.Generic;
using System.Text;

namespace BugRepro.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    public class LoginParameters
    {
        //[Required]
        public string UserName { get; set; } = default!;

        //[Required]
        public string Password { get; set; } = default!;

        public bool RememberMe { get; set; }
    }
}
