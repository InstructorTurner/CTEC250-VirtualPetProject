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

        int frame;

        Timer catHungerTimer;
        Timer catThirstTimer;
        Timer catBoredomTimer;
        Timer catAffectionTimer;
        Timer catEatTimer;
        Timer catDrinkTimer;

        Random generator;

        public Form1()
        {
            InitializeComponent();

            //set up initial stuff
            generator = new Random();
            InitializeCat();
            InitializeFood();
            InitializeWater();
            InitializeTimers();
            

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
        }
        private void InitializeTimers()
        {
            catHungerTimer = new Timer();
            catThirstTimer = new Timer();
            catBoredomTimer = new Timer();
            catAffectionTimer = new Timer();
            catEatTimer = new Timer();
            catDrinkTimer = new Timer();

            catHungerTimer.Tick += increaseHunger;
            catAffectionTimer.Tick += decreaseAffection;
            catThirstTimer.Tick += increaseThirst;
            catBoredomTimer.Tick += increaseBoredom;
            catEatTimer.Tick += tryToEat;
            catDrinkTimer.Tick += tryToDrink;

            catHungerTimer.Interval = generator.Next(2000, 10000);
            catThirstTimer.Interval = generator.Next(2000, 10000);
            catBoredomTimer.Interval = generator.Next(2000, 10000);
            catAffectionTimer.Interval = generator.Next(2000, 10000);
            catEatTimer.Interval = 1000;
            catDrinkTimer.Interval = 1000;

            catHungerTimer.Start();
            catThirstTimer.Start();
            catBoredomTimer.Start();
            catAffectionTimer.Start();
        }
        private void InitializeFood()
        {
            currentFood = 1;
        }
        private void InitializeWater()
        {
            currentWater = 1;
        }

        private void increaseHunger(Object o, EventArgs e)
        {
            if (catHunger < MAX_HUNGER) catHunger++;

            if (catHunger > catStartEating) catEatTimer.Start();

            maybeTakeCatAway();

            UpdateView();
        }
        private void increaseThirst(Object o, EventArgs e)
        {
            if (catThirst < MAX_THIRST) catThirst++;

            if (catThirst > catStartDrinking) catDrinkTimer.Start();

            maybeTakeCatAway();

            UpdateView();
        }
        private void increaseBoredom(Object o, EventArgs e)
        {
            if (catBoredom < MAX_BOREDOM) catBoredom++;

            maybeTakeCatAway();

            UpdateView();
        }
        private void decreaseAffection(Object o, EventArgs e)
        {
            if (catAffection > MIN_AFFECTION) catAffection--;

            maybeTakeCatAway();

            UpdateView();
        }

        private void tryToDrink(Object o, EventArgs e)
        {
            if(currentWater > MIN_WATER)
            {
                currentWater--;
                catThirst--;
            }

            if (catThirst == MIN_THIRST || currentWater == MIN_WATER) catDrinkTimer.Stop();

            UpdateView();
        }
        private void tryToEat(Object o, EventArgs e)
        {
            if (currentFood > MIN_FOOD)
            {
                currentFood--;
                catHunger--;
            }

            if (catHunger == MIN_HUNGER || currentFood == MIN_FOOD) catEatTimer.Stop();

            UpdateView();
        }
        private void maybeTakeCatAway()
        {
            if(catHunger == MAX_HUNGER && catThirst == MAX_THIRST && catBoredom == MAX_BOREDOM && catAffection == MIN_AFFECTION)
            {
                //replace image with lack of cat
                petPictureBox.Image = Properties.Resources.cat_leaving;
                //stop timers
                stopAllTimers();
                //disable buttons
                feedCatButton.Enabled = false;
                catWaterButton.Enabled = false;
                catPlayButton.Enabled = false;
                petCatButton.Enabled = false;
            }
        }
        private void stopAllTimers()
        {
            catHungerTimer.Stop();
            catThirstTimer.Stop();
            catBoredomTimer.Stop();
            catAffectionTimer.Stop();
            catEatTimer.Stop();
            catDrinkTimer.Stop();
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
            UpdateView();
        }

        private void catWaterButton_Click(object sender, EventArgs e)
        {
            if(currentWater < MAX_WATER)
            {
                currentWater++;
            }
            UpdateView();
        }

        private void catPlayButton_Click(object sender, EventArgs e)
        {
            if(catBoredom > MIN_BOREDOM)
            {
                catBoredom--;
            }
            UpdateView();
        }

        private void petCatButton_Click(object sender, EventArgs e)
        {
            if(catAffection < MAX_AFFECTION)
            {
                catAffection++;
            }
            UpdateView();
        }
    }
}
