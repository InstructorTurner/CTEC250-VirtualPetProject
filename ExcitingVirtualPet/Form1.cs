using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcitingVirtualPet
{
    public partial class Form1 : Form
    {
        //Constants
        //pet Constants
        const int MAX_HUNGER = 10;
        const int MIN_HUNGER = 0;
        const int MAX_AFFECTION = 10;
        const int MIN_AFFECTION = 0;
        const int MAX_THIRST = 10;
        const int MIN_THIRST = 0;
        const int MAX_BOREDOM = 10;
        const int MIN_BOREDOM = 0;
        //Resource Constants
        const int MAX_FOOD = 10;
        const int MIN_FOOD = 0;
        const int MAX_WATER = 10;
        const int MIN_WATER = 0;

        //Program "globals" (really just fields of Form1)
        int catHunger;
        int catAffection;
        int catThirst;
        int catBoredom;
        int currentFood;
        int currentWater;
        int catStartEating;
        int catStartDrinking;
        bool catEating = false;
        bool catDrinking = false;

        //Time Stuff
        Timer mainLoopTimer;
        int hungerFrame;
        int thirstFrame;
        int boredomFrame;
        int affectionFrame;
        int eatFrame;
        int drinkFrame;
        int hungerCounter;
        int thirstCounter;
        int boredomCounter;
        int affectionCounter;
        int eatCounter;
        int drinkCounter;

        Random generator;

        public Form1()
        {
            InitializeComponent();

            //set up initial stuff
            generator = new Random();
            InitializeCat();
            InitializeFood();
            InitializeWater();
            InitializeFrames();

            //set up loop
            mainLoopTimer = new Timer();
            mainLoopTimer.Interval = 16; //runs every 60th of a second
            mainLoopTimer.Tick += MainLoopTimer_Tick; //run MainLoopTimer_Tick method every 60th of a second
            mainLoopTimer.Start(); //start the main loop
        }

        private void MainLoopTimer_Tick(object sender, EventArgs e)
        {
            //increase frame counters
            increaseNeedCounters();
            
            //How Frame Counters Work
            //The fame counters "count" every tick of the main loop timer.
            //Once the counter reaches a frame (like hungerFrame), the cat
            //performs that action.  This way we can have 1 timer and multiple
            //actions that can be performed.  Once the count reaches the frame,
            //we also need to remember to reset the counter for the next time.

            //update cat needs
            if (hungerCounter >= hungerFrame)
            {
                increaseHunger();
                
            }
            if(thirstCounter >= thirstFrame)
            {
                increaseThirst();
                
            }
            if(affectionCounter >= affectionFrame)
            {
                decreaseAffection();
                
            }
            if(boredomCounter >= boredomFrame)
            {
                increaseBoredom();
                
            }
            //update cat need fulfillment
            if (catDrinking)
            {
                drinkCounter++;
                if(drinkCounter >= drinkFrame)
                {
                    tryToDrink();
                }
            }
            if (catEating)
            {
                eatCounter++;
                if (eatCounter >= eatFrame)
                {
                    tryToEat();
                }
            }

            //check game loss condition
            maybeTakeCatAway();

            //update view
            UpdateView();
        }

        //Set up main data
        private void InitializeCat()
        {
            petPictureBox.Image = Properties.Resources.basic_cat;
            catHunger = 5;
            catAffection = 0;
            catThirst = 5;
            catBoredom = 5;

            catStartEating = 6;
            catStartDrinking = 6;

            catEating = false;
            catDrinking = false;
        }
        private void InitializeFrames()
        {
            //set these to somewhat random amounts so the cat gets hungry/thirsty at different rates
            hungerFrame = generator.Next(120, 600);
            thirstFrame = generator.Next(120, 600);
            boredomFrame = generator.Next(120, 600);
            affectionFrame = generator.Next(120, 600);
            //cat eats and drinks 1 unit per second
            eatFrame = 60;
            drinkFrame = 60;

            //initialize the starter counters to 0
            hungerCounter = 0;
            thirstCounter = 0;
            affectionCounter = 0;
            eatCounter = 0;
            drinkCounter = 0;
        }
        private void InitializeFood()
        {
            currentFood = 1;
        }
        private void InitializeWater()
        {
            currentWater = 1;
        }
        private void increaseNeedCounters()
        {
            hungerCounter++;
            thirstCounter++;
            affectionCounter++;
            boredomCounter++;
        }
        private void increaseHunger()
        {
            if (catHunger < MAX_HUNGER) catHunger++;

            if (catHunger > catStartEating) catEating = true;

            //reset frame counter
            hungerCounter = 0;
        }
        private void increaseThirst()
        {
            if (catThirst < MAX_THIRST) catThirst++;

            if (catThirst > catStartDrinking) catDrinking = true;

            //reset frame counter
            thirstCounter = 0;
        }
        private void increaseBoredom()
        {
            if (catBoredom < MAX_BOREDOM) catBoredom++;

            //reset frame counter
            boredomCounter = 0;
        }
        private void decreaseAffection()
        {
            if (catAffection > MIN_AFFECTION) catAffection--;

            //reset frame counter
            affectionCounter = 0;
        }

        private void tryToDrink()
        {
            if(currentWater > MIN_WATER)
            {
                currentWater--;
                catThirst--;
            }

            if (catThirst == MIN_THIRST || currentWater == MIN_WATER) catDrinking = false;

            //reset frame counter
            drinkCounter = 0;
        }
        private void tryToEat()
        {
            if (currentFood > MIN_FOOD)
            {
                currentFood--;
                catHunger--;
            }

            if (catHunger == MIN_HUNGER || currentFood == MIN_FOOD) catEating = false;

            //reset frame counter
            eatCounter = 0;
        }
        private void maybeTakeCatAway()
        {
            //if you've really not taken care of your cat...
            if(catHunger == MAX_HUNGER && catThirst == MAX_THIRST && catBoredom == MAX_BOREDOM && catAffection == MIN_AFFECTION)
            {
                //replace image with lack of cat
                petPictureBox.Image = Properties.Resources.cat_leaving;
                
                //disable buttons
                feedCatButton.Enabled = false;
                catWaterButton.Enabled = false;
                catPlayButton.Enabled = false;
                petCatButton.Enabled = false;

                //stop main loop
                mainLoopTimer.Stop();
            }
        }


        private void UpdateView()
        {
            hungerMeter.Value = catHunger;
            thirstMeter.Value = catThirst;
            boredomMeter.Value = catBoredom;
            affectionMeter.Value = catAffection;

            waterAmountBar.Value = currentWater;
            foodAmountBar.Value = currentFood;
        }

        private void feedCatButton_Click(object sender, EventArgs e)
        {
            if(currentFood < MAX_FOOD)
            {
                currentFood++;
            }
        }

        private void catWaterButton_Click(object sender, EventArgs e)
        {
            if(currentWater < MAX_WATER)
            {
                currentWater++;
            }
        }

        private void catPlayButton_Click(object sender, EventArgs e)
        {
            if(catBoredom > MIN_BOREDOM)
            {
                catBoredom--;
            }
        }

        private void petCatButton_Click(object sender, EventArgs e)
        {
            if(catAffection < MAX_AFFECTION)
            {
                catAffection++;
            }
        }
    }
}
