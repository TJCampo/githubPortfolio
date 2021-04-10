using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreaturesOfTheSeaGUI
{
    public partial class Form1 : Form
    {

        public List<Creature> Creatures { get; set; }

        public List<Item> Items { get; set; }

        public Creature SelectedCreature { get; set; }

        public Form1()
        {
            InitializeComponent();


            SeaWeed seeWeed = new SeaWeed()
            {
                Name = "Sea Weed"
            };

            Food fishFood = new Food()
            {
                Name = "Fish Food",
                Calories = 10
            };

            Algae algae = new Algae()
            {
                Name = "Algae",
                Calories = 45
            };

            Goldfish swimShady = new Goldfish()
            {
                Name = "Swim Shady",
                Age = 1,
                Color = "Orange",
                NumberOfFins = 1,
                CreatureSound = CreaturesOfTheSeaGUI.Resource.Fish,
                HungerLevelProgress = SwimShadyProgress
            };

            Pufferfish phat = new Pufferfish()
            {
                Name = "Phat",
                Age = 7,
                Color = "Yellow",
                NumberOfFins = 5,
                CreatureSound = CreaturesOfTheSeaGUI.Resource.Fish,
                HungerLevelProgress = PhatProgress
            };

            SeaTurtle crush = new SeaTurtle()
            {
                Name = "Crush",
                Age = 150,
                Color = "Green",
                HasTail = true,
                CreatureSound = CreaturesOfTheSeaGUI.Resource.Turtle,
                HungerLevelProgress = CrushProgress
            };

            Reptile waterDragon = new Reptile()
            {
                Name = "Water Dragon",
                Age = 2,
                Color = "Green",
                HasTail = true,
                CreatureSound = CreaturesOfTheSeaGUI.Resource.Whale,
                HungerLevelProgress = WaterDragonProgress
            };


            Creatures = new List<Creature>()
            {
                swimShady,
                phat,
                crush,
                waterDragon
            };

            Items = new List<Item>()
            {
                fishFood,
                algae,
                seeWeed
            };

        }

        /// <summary>
        /// Displays the hunger levels on their respective progress bars.
        /// </summary>
        private void ShowHungerLevels()
        {
            foreach (var creature in Creatures)
            {
                creature.HungerLevelProgress.Value = creature.HungerLevel;
            }
        }

        private void Creature_Click(object sender, EventArgs e)
        {
            //Getting a reference to the selected creature using the TAG property of the picturebox.
            if (sender is PictureBox)
            {
                PictureBox selectedCreature = (PictureBox)sender;
               
                //Get the name of the creature from the TAG property
                string nameOfTheCreature = selectedCreature.Tag.ToString();

                //using LINQ to find the selected creature from the Creatures list
                SelectedCreature = Creatures.First(creture => creture.Name == nameOfTheCreature);

                //You can also do a for each loop to find the selected creature
                //foreach (var creature in Creatures)
                //{
                //    if (creature.Name == nameOfTheCreature)
                //    {
                //        SelectedCreature = creature;
                //    }
                //}

                //Showing all instructions and elements on the creen
                CreatureInstructions.Visible = FeedButton.Visible = CommunicateButton.Visible = SelectedCreatureDetails.Visible = ResetButton.Visible = true;

                //Turning off all border styling on creature elements
                Crush.BorderStyle = Phat.BorderStyle = SwimShady.BorderStyle = WaterDragon.BorderStyle = BorderStyle.None;

                //Adding border style to the selected creature
                selectedCreature.BorderStyle = BorderStyle.FixedSingle;

                //Height = 500;
            }

        }

        private void FeedButton_Click(object sender, EventArgs e)
        {
            //Getting a random number
            Random random = new Random();
            int index = random.Next(0, Items.Count);

            //Showing what the creature is eating on the screen
            SelectedCreatureDetails.Text = SelectedCreature.Eat(Items[index]);

            ShowHungerLevels();

            
        }

        //
        private void CommunicateButton_Click(object sender, EventArgs e)
        {
            //Showing how the creature is commuinicating
            SelectedCreatureDetails.Text = SelectedCreature.Communicate();
        }

        
        /// <summary>
        /// Resetting all the progress levels on the creatures
        /// </summary>
        /// <param name="sender">Sender is a button</param>
        /// <param name="e">No arguments</param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (var creature in Creatures)
            {
                creature.HungerLevel = 0;
            }

            ShowHungerLevels();
        }
    }
}
