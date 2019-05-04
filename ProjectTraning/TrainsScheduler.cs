using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    public class TrainsScheduler
    {
        private const int TrainsMaxNumber = 2;
        
        private Train[] trainlist;

        public TrainsScheduler()
        {
            this.trainlist = new Train[TrainsScheduler.TrainsMaxNumber];
        }

        public void Execute()
        {
            for (int i = 0; i < TrainsScheduler.TrainsMaxNumber; i++)
            {
                this.trainlist[i] = this.GetNewTrain();
            }
            int selectedTrainNumber = this.AskTrainNumber();

            this.DisplayTrainInfo(selectedTrainNumber);
        }

        private int AskTrainNumber()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Please enter a train number");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
            }
            return number;
        }

        private void DisplayTrainInfo (int trainNumber)
        {
            Train selectedTrain=new Train();

            for (int i = 0; i < TrainsScheduler.TrainsMaxNumber; i++)
            {
                if (this.trainlist[i].GetTrainNumber() == trainNumber)
                    selectedTrain = this.trainlist[i];
            }
            if (selectedTrain.GetTrainNumber() == 0)
            {
                Console.WriteLine($"Train number {trainNumber} was not found in train list");
                return;
            }

            Console.WriteLine($"Train {trainNumber} is departuring to {selectedTrain.GetDestination()} at {selectedTrain.GetDepartureTime()}");
        }

        private Train GetNewTrain()
        {
            int number;
            while (true) {
                Console.WriteLine("Enter the number of train");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
        }

            DateTime departureTime;
            while (true)
            {
                Console.WriteLine("Enter departure time of a train");
                if (DateTime.TryParse(Console.ReadLine(), out departureTime))
                    break;
            }

            string destination = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter destination of a train");

                destination = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(destination)) { }
                break;
            }
            return new Train(number, destination, departureTime);
        }
    }
}
