using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning.Task_20_07
{
    public delegate void FridgeDelegate(object a, FridgeEventArgs datetime);

    public class ProgramForFridge
    {
        public User User { get; set; }

        public FridgeRefreg FridgeRefreg { get; set; }

        public ProgramForFridge()
        {
            this.User = new User();
            this.FridgeRefreg = new FridgeRefreg();

            this.FridgeRefreg.Fridge += OnFridge;
            this.FridgeRefreg.Fridge += OffFridge;
            this.FridgeRefreg.Fridge += CloseMainDore;
            this.FridgeRefreg.Fridge += OpenMainDore;
            this.FridgeRefreg.Fridge += OpenSecondDore;
            this.FridgeRefreg.Fridge += CloseSecondDore;
        }

        public void Start()
        {
            FridgeRefreg.MainDorOpen();
        }

        public void OnFridge(object sender, FridgeEventArgs e)
        {
            User.On();
        }

        public void OffFridge(object sender, FridgeEventArgs e)
        {
            User.Off();
        }

        public void CloseMainDore(object sender, FridgeEventArgs e)
        {
            User.MainDorClose();
        }

        public void OpenMainDore(object sender, FridgeEventArgs e)
        {
            User.MainDorOpen();
        }

        public void OpenSecondDore(object sender, FridgeEventArgs e)
        {
            User.SecondDorClose();
        }

        public void CloseSecondDore(object sender, EventArgs e)
        {
            User.SecondDorOpen();
        }
    }
}
