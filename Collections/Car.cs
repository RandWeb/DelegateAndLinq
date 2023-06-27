using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Car
    {
        public string Name { get; set; }
        public Motor Motor { get; set; }
        public override string ToString()
        {
            return $"{Name}: {Motor.MotorName} {Motor.Company} {Motor.MotorType}";
        }

    }

    public class Motor
    {
        public string MotorName { get; set; }
        public Company Company { get; set; }
        public MotorType MotorType { get; set; }

        public override string ToString()
        {
            return $"{MotorName} {Company} {MotorType}";
        }

    }

    public enum Company
    {
        IranKhodro,
        ParsKhodro,
        Saipa
    }
    public enum MotorType
    {
        Gas,
        Petrol,
        Hybrid
    }
}