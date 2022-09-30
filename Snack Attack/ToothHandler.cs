using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snack_Attack
{
    public class ToothHandler
    {
        PictureBox[] teethObjects; //Storing each PictureBox to change how they show
        int maxAmount;
        int currentAmount;

        public ToothHandler(int amount, PictureBox[] objects)
        {
            teethObjects = objects;
            maxAmount = amount;
            currentAmount = amount;
        }

        public void Restore()
        {
            currentAmount = maxAmount; //Prevents the amount of teeth going below 0, as that's impossible. 
            foreach (PictureBox Object in this.teethObjects)
            {
                Object.BackgroundImage = Properties.Resources.Tooth;
            }
            game.teethCounter.Text = $"{currentAmount} / {maxAmount}";
        }
        public void RemoveTooth()
        {
            currentAmount = Math.Max(currentAmount - 1, 0); //Prevents the amount of teeth going below 0, as that's impossible. 
            teethObjects[currentAmount].BackgroundImage = Properties.Resources.MissingTooth;
            game.teethCounter.Text = $"{currentAmount} / {maxAmount}";

            if (currentAmount == 0)
            {
                game.Stop();
            }

        }

        public void AddTooth()
        {
            currentAmount = Math.Min(currentAmount + 1, maxAmount); //Prevents the amount of teeth going above the max amount.
            teethObjects[currentAmount - 1].BackgroundImage = Properties.Resources.Tooth;
            game.teethCounter.Text = $"{currentAmount} / {maxAmount}";
        }

    }
}
