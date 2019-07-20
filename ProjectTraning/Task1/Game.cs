using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task1
{
   
    class Game
    {
        public Ping Ping { get; set; }

        public Pong Pong { get; set; }

        public Game ()
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

        public void OnPingIvoked(object sender, EventArgs e)
        {
            Ping.PingE();
        }

        public void OnPongIvoked(object sender, EventArgs e)
        {
            Pong.PongE();
        }
    }
}
