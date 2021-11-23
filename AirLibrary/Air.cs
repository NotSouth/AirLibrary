using System;

namespace AirLibrary
{
    /// <summary>
    /// Class to hold all the data gathered from the sensor
    /// </summary>
    public class Air
    {
        //properties are strings because we can always parse them later in the case they are numbers
        //i dont know how the sensor will display this data
        public string Temperature { get; set; }
        public string CO2 { get; set; }
        public string Humidity { get; set; }

        public Air(string temp, string co2, string humidity)
        {
            Temperature = temp;
            CO2 = co2;
            Humidity = humidity;
        }
        public Air()
        {

        }
    }
}
