using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task2
{
    public delegate void PingPongDelegate(object a, PingPongEventArgs datetime);
    class Game2
    {
        public Ping Ping { get; set; }

        public Pong Pong { get; set; }

        public Game2()
        {
            this.Ping = new Ping();
            this.Pong = new Pong();

            this.Ping.NewPing += this.OnPongIvoked;
            this.Pong.NewPong += this.OnPingIvoked;
        }

        public void Player()
        {
            this.Pong.PongE();
        }

        public void OnPingIvoked(object sender, PingPongEventArgs e)
        {
            Console.WriteLine(e);
            Ping.PingE();
        }

        public void OnPongIvoked(object sender, PingPongEventArgs e)
        {
            Console.WriteLine(e);
            Pong.PongE();
        }
    }
}

