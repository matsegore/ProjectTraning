﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task1
{
    class Driver: Worker
    {

        private double driverExperience;

        private DriverLicenceCategories driverLicence;

        public Driver(double driverExperience, DriverLicenceCategories driverLicence, string name, int age, decimal salary)

            : base(name, age, salary)

        {
            this.driverExperience = driverExperience;

            this.driverLicence = driverLicence;

            Name = name;

            Age = age;

            Salary = salary;
        }

        public double DriverExperience
        {
            get
            {
                return driverExperience;
            }

            set
            {
                driverExperience = value;
            }
        }

        public DriverLicenceCategories DriverLicence
        {
            get
            {
                return driverLicence;
            }
            set
            {
                driverLicence = value;
            }
        }
    }

    enum DriverLicenceCategories
    {
        A,

        B,

        C
    }
}

