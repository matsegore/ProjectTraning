using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{

    public struct Train
    {
        private int trainNumber;

        private string destination;

        private DateTime departureTime;

        public Train(int trainNumber, string destination, DateTime departureTime)
        {
            if (trainNumber == 0)
                throw new ArgumentException(nameof(destination));

            if (string.IsNullOrWhiteSpace(destination))
                throw new ArgumentException(nameof(destination));

            this.trainNumber = trainNumber;

            this.departureTime = departureTime;

            this.destination = destination;
        }

        public int GetTrainNumber()
        {
            return this.trainNumber;
        }

        public string GetDestination()
        {
            return this.destination;
        }

        public DateTime GetDepartureTime()
        {
            return this.departureTime;
        }
    }
}

