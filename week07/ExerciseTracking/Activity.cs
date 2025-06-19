using System;
using System.ComponentModel;
using System.Drawing;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

//calling the namespace

namespace ExerciseTracking
{
    //creating an abstract class Activity
    //this class will be the base class for other activities like Running, Cycling, and Swimming
    //it will contain properties and methods that are common to all activities


    public abstract class Activity
    {
        //creating a private property for the date and duration of the activity

        protected DateTime date { get; set; }

        protected double duration { get; set; }

        //creating a constructor that takes the date and duration as parameters

        public Activity(DateTime Date, double Duration)
        {
            //assigning the parameters to the private properties

            date = Date;

            duration = Duration;
        }

        //getters and setters for the date and duration properties

        public DateTime GetDate()
        {
            return date;
        }

        public void SetDate(DateTime Date)
        {
            date = Date;
        }

        public double GetDuration()
        {
            return duration;
        }

        public void SetDuration(double Duration)
        {
            duration = Duration;
        }

        //creating a method to get the distance of the activity

        public abstract double GetDistance();

        //creating a method to get the speed of the activity

        public abstract double GetSpeed();

        //creating a method to get the pace of the activity

        public abstract double GetPace();

        //creating a method to get the summary of the activity

        public virtual string GetSummary()
        {
            //returning a string that contains the date, duration, distance, speed, and pace of the activity

            return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({duration} min), Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
        }
    }
}