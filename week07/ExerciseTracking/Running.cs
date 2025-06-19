using System;
using System.ComponentModel;
using System.Drawing;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

// calling the namespace again in the subclass

namespace ExerciseTracking
{
    // creating a class Running that inherits from Activity

    public class Running : Activity
    {
        // creating a private property for the distance of the running activity

        private double distance { get; set; }

        // creating a constructor that takes the date, duration, and distance as parameters

        public Running(DateTime Date, double Duration, double Distance) : base(Date, Duration)
        {
            // assigning the parameters to the private properties

            distance = Distance;
        }

        // overriding the GetDistance method to return the distance of the running activity

        public override double GetDistance()
        {
            return distance;
        }

        // overriding the GetSpeed method to calculate and return the speed of the running activity

        public override double GetSpeed()
        {
            // speed = distance / time
            // converting duration from minutes to hours for speed calculation
            return distance / base.duration / 60;
        }

        // overriding the GetPace method to calculate and return the pace of the running activity

        public override double GetPace()
        {
            // pace = time / distance
            // converting duration from minutes to hours for pace calculation
            return base.duration / distance * 60; // returns pace in minutes per kilometer
        }

    }
}