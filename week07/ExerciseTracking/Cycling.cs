using System;
using System.ComponentModel;
using System.Drawing;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

// calling the namespace for the subclass

namespace ExerciseTracking
{
    // creating a class Cycling that inherits from Activity

    public class Cycling : Activity
    {
        // creating a private property for the speed of the cycling activity

        private double speed { get; set; }

        // creating a constructor that takes the date, duration, and speed as parameters

        public Cycling(DateTime Date, double Duration, double Speed) : base(Date, Duration)
        {
            // assigning the parameters to the private properties

            speed = Speed;
        }

        // overriding the GetDistance method to return the distance of the cycling activity

        public override double GetDistance()
        {
            // distance = speed * time
            // converting duration from minutes to hours for distance calculation

            return speed * (base.duration / 60); // returns distance in kilometers
        }

        // overriding the GetSpeed method to return the speed of the cycling activity

        public override double GetSpeed()
        {
            // speed = distance / time
            // converting duration from minutes to hours for speed calculation

            return speed; // returns speed in kilometers per hour
        }

        // overriding the GetPace method to calculate and return the pace of the cycling activity

        public override double GetPace()
        {
            // pace = time / speed
            // converting duration from minutes to hours for pace calculation

            return (base.duration / GetDistance()) * 60; // returns pace in minutes per kilometer
        }

    }
}