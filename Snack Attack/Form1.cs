using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Snack_Attack
{

    public partial class game : Form
    {
        public static Point[] Boundaries = new Point[] { new Point(0, -60), new Point(610, -60) }; //Boundaries of the application

        public static Player playerObject;
        public static ToothHandler Teeth;
        public static Label teethCounter;
        static Label scoreObject;
        public static PictureBox groundObject;
        public static int gameTime = 0;

        private static PictureBox gameOverBG;
        private static Button restartBtn;
        private static Button exitBtn;
        private static List<ValueTuple<int, Action>> scheduledMethods = new List<ValueTuple<int, Action>>();
        private static bool Playing = true;

        Random rnd = new Random();
        Dictionary<Keys, bool> KeyIsDown = new Dictionary<Keys, bool> { { Keys.A, false }, { Keys.D, false } }; //Data structure to store the status of the movement keys that have been pressed
        

        public game()
        {
            InitializeComponent();
            scoreObject = Score; //Make the Score label available to other classes
            teethCounter = teethAmount; //Make the teethCounter label available to other classes
            groundObject = Ground; //Make the Ground PictureBox available to other classes 
            gameOverBG = GameOverBG;
            restartBtn = RestartBtn;
            exitBtn = ExitBtn;
            Teeth = new ToothHandler(
                5,
                new PictureBox[] { Tooth1, Tooth2, Tooth3, Tooth4, Tooth5 }
            ); //Make the Teeth objects available to other classes
            playerObject = new Player(Character); //Create the player object
        }

        public static Label GetScoreObject()
        {
            return scoreObject;
        }

        public static void ScheduleTask(int time, Action method)
        {
            scheduledMethods.Add((time, method)); //Add the Action to the list of actions to be executed when the time reaches the passed in time.
        }

        private void Restart()
        {
            //Hide UI
            gameOverBG.Visible = false;
            restartBtn.Visible = false;
            exitBtn.Visible = false;

            //Reset variables
            scheduledMethods = new List<ValueTuple<int, Action>>(); //Reset event scheduler
            KeyIsDown = new Dictionary<Keys, bool> { { Keys.A, false }, { Keys.D, false } }; //Reset the key variables
            gameTime = 0; // Reset game time
            playerObject = new Player(Character);
            Character.Location = new Point(293, 445);
            Character.Size = new Size(83, 79);
            GravityObject.Clear();
            Teeth.Restore();

            Playing = true;
            Focus();
        }


        public static void Stop()
        {
            Playing = false;

            gameOverBG.Visible = true;
            gameOverBG.BringToFront();

            restartBtn.Visible = true;
            exitBtn.Visible = true;
            restartBtn.BringToFront();
            exitBtn.BringToFront();


        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (Playing)
            {
                gameTime++; //Increase the game time by 1

                List<ValueTuple<int, Action>> methodClone = new List<ValueTuple<int, Action>>();

                foreach (ValueTuple<int, Action> action in scheduledMethods)
                {
                    methodClone.Add(action);
                } //Copy the Action list to another list so that the main list can be edited through the foreach loop

                foreach (ValueTuple<int, Action> action in methodClone)
                {
                    if (gameTime >= action.Item1) //If the time is correct as stored
                    {
                        action.Item2(); //Execute the given function
                        scheduledMethods.Remove(action); //Remove the action from the schedule list
                    }
                }

                GravityObject.OnTick(); //Trigger GravityObject static method OnTick
                playerObject.OnTick(); //Trigger playerObject method OnTick
            }
        }

        private void FoodSpawn_Tick(object sender, EventArgs e)
        {
            if (Playing)
            {
                if (new Random().Next(4) < 3) // 3/4 Chance to spawn a fruit
                {
                    PictureBox newFruitObject = new PictureBox
                    { //Create new PictureBox to represent the Fruit
                        Name = "Fruit",
                        Size = new Size(83, 79),
                        Location = new Point(100, 100),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                    };

                    //Add the PictureBox to the form and fix the layering
                    this.Controls.Add(newFruitObject);
                    newFruitObject.BringToFront();
                    Character.BringToFront();
                    Ground.BringToFront();
                    Score.BringToFront();

                    Fruit newFruit = new Fruit(newFruitObject,
                        rnd.Next(4) > 2 ? (FruitType)rnd.Next(Enum.GetNames(typeof(FruitType)).Length) : FruitType.APPLE // 1/4 chance in spawning a special fruit, otherwise spawn an apple.
                   ); //Create Fruit Object to handle the new fruit PictureBox
                    newFruit.Spawn(); //Spawn the fruit
                }
                else // 1/4 Chance to spawn junkfood
                {
                    PictureBox newJunkObject = new PictureBox
                    { //Create new PictureBox to represent the Junk 
                        Name = "Junk",
                        Size = new Size(83, 79),
                        Location = new Point(100, 100),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                    };

                    //Add the PictureBox to the form and fix the layering
                    this.Controls.Add(newJunkObject);
                    newJunkObject.BringToFront();
                    Character.BringToFront();
                    Ground.BringToFront();
                    Score.BringToFront();

                    Junk newJunk = new Junk(newJunkObject, (JunkType)rnd.Next(3)); //Create Junk Object to handle the new junk PictureBox
                    newJunk.Spawn(); //Spawn the junk
                }
            }
        }

       
        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && KeyIsDown[Keys.A] == false)
            {
                playerObject.ChangeMovement(-1); //Change direction to the left
                KeyIsDown[Keys.A] = true; 
            }
            else if(e.KeyCode == Keys.D && KeyIsDown[Keys.D] == false)
            {
                playerObject.ChangeMovement(1); //Change direction to the right
                KeyIsDown[Keys.D] = true;
            }
        }

        private void game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && KeyIsDown[Keys.A] == true)
            {
                playerObject.ChangeMovement(1); //Remove leftwards influence on the player's direction
                KeyIsDown[Keys.A] = false;
            }
            else if (e.KeyCode == Keys.D && KeyIsDown[Keys.D] == true)
            {
                playerObject.ChangeMovement(-1); //Remove rightwards influence on the player's direction
                KeyIsDown[Keys.D] = false;
            }
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
