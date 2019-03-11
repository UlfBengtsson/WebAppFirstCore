using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstCore.Models
{
    /*
     Algorithms:
         Angle In Radians: (Math.PI / 180) * angle
         Distance: Math.Pow(velocity, 2) / GRAVITY * Math.Sin(2 * angleInRadians)
         Gravity is equal to 9.8.
         Example: At 45 Degrees and 56 m/s, the ball should travel 320 meters.
     */

    public class Golf
    {
        static readonly double GRAVITY = 9.8;

        private static double AngleInRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static double Distance(double angle, double velocity)
        {
            return Math.Pow(velocity, 2) / GRAVITY * Math.Sin(2 * AngleInRadians(angle));
        }
    }
}
