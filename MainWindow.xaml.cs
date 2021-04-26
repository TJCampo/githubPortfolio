using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MadlibGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       static string[] words =
        {
            "creature",
            "luminous",
            "ghastly",
            "specteral",
            "countryman",
            "farrier",
            "farmer",
            "dreadful",
            "apparition",
            "hound",
        };
       
        

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            words[0] = TypeNounOne.Text;
            words[1] = TypeAdjectiveOne.Text;
            words[2] = TypeAdjectiveTwo.Text;
            words[3] = TypeAdjectiveThree.Text;
            words[4] = TypeOccupationOne.Text;
            words[5] = TypeOccupationTwo.Text;
            words[6] = TypeOccupationThree.Text;
            words[7] = TypeAdjectiveFour.Text;
            words[8] = TypeNounTwo.Text;
            words[9] = TypeNounThree.Text;

            string story = "They all agreed that it was a huge " + words[0] + ", " + words[1] + ", " + words[2] + ", and " + words[3] + ". I have cross-examined these men, one of them a hard-headed " + words[4] + ", one a " + words[5] + ", and one a moorland " + words[6] + ", who all tell the same story of this " + words[7] + " " + words[8] + ", exactly corresponding to the hell-" + words[9] + " of the legend.";

            StoryDisplay.Text = story;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            StoryDisplay.Text = "";
            TypeNounOne.Text = "";
            TypeAdjectiveOne.Text = "";
            TypeAdjectiveTwo.Text = "";
            TypeAdjectiveThree.Text = "";
            TypeOccupationOne.Text = "";
            TypeOccupationTwo.Text = "";
            TypeOccupationThree.Text = "";
            TypeAdjectiveFour.Text = "";
            TypeNounTwo.Text = "";
            TypeNounThree.Text = "";
        }
    }
}
