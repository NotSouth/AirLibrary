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
        public int ID { get; set; }
        public double Temperature { get; set; }
        public double CO2 { get; set; }
        public double Humidity { get; set; }
        public DateTime TimeStamp { get; set; }

        public Air(double temp, double co2, double humidity)
        {
            TimeStamp = DateTime.Now;
            Temperature = temp;
            CO2 = co2;
            Humidity = humidity;
        }
        public Air()
        {

        }
    }
}
