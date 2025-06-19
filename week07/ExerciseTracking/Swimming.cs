using System;
using System.ComponentModel;
using System.Drawing;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

// calling the namespace for the subclass

namespace ExerciseTracking
{
    // creating a class Swimming that inherits from Activity

    public class Swimming : Activity
    {

        // creating a private property for the laps of the swimming activity

        private int laps { get; set; }

        // creating a constructor that takes the date, duration, and laps as parameters

        public Swimming(DateTime Date, double Duration, int Laps) : base(Date, Duration)
        {
            // assigning the parameters to the private properties

            laps = Laps;
        }

        // overriding the GetDistance method to return the distance of the swimming activity

        public override double GetDistance()
        {
            // assuming each lap is 50 meters, so distance = laps * 50

            return laps * 50; // returns distance in meters
        }

        // overriding the GetSpeed method to calculate and return the speed of the swimming activity

        public override double GetSpeed()
        {
            // speed = distance / time
            // converting duration from minutes to hours for speed calculation

            return GetDistance() / (base.duration / 60); // returns speed in meters per minute
        }

        // overriding the GetPace method to calculate and return the pace of the swimming activity

        public override double GetPace()
        {
            // pace = time / distance
            // converting duration from minutes to hours for pace calculation

            return (base.duration / GetDistance()) * 60; // returns pace in minutes per meter
        }
    }
}