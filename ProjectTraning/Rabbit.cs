using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectTraning
{
    class Rabbit
    {
        public delegate void LocationDelegate(object sender, HuntEventArgs args);

        public event LocationDelegate EventNewLocation;

        public int FirstCoordinate { get; set; }

        public int SecondCoordinate { get; set; }

        public void ChangeLocation()
        {
            var random = new Random();

            while (true)
            {
                this.FirstCoordinate = random.Next();

                this.SecondCoordinate = random.Next();

                this.OnEventNewLocation(new HuntEventArgs(this.FirstCoordinate, this.SecondCoordinate));

                Thread.Sleep(2000);
            }
        }

        protected virtual void OnEventNewLocation(HuntEventArgs e)
        {
            this.EventNewLocation?.Invoke(this, e);
        }
    }
}
