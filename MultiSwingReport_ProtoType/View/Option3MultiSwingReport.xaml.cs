using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MultiSwingReport_ProtoType.View
{
    /// <summary>
    /// Interaction logic for Option3MultiSwingReport.xaml
    /// </summary>
    public partial class Option3MultiSwingReport : UserControl
    {
        //List<AddressSwingResults> addressPositionPelvis = new List<AddressSwingResults>();
        //List<AddressSwingResults> addressPositionTorso = new List<AddressSwingResults>();
        List<SwingResults> swingResults = new List<SwingResults>();
        public Option3MultiSwingReport()
        {
            InitializeComponent();

            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 37, 51), PelvisTurn = 9.00, PelvisBend = 21.00, PelvisSideBend = -2.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 28, 29), PelvisTurn = 4.00, PelvisBend = 21.00, PelvisSideBend = -1.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 10, 42), PelvisTurn = 5.00, PelvisBend = 20.00, PelvisSideBend = -3.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 02, 19), PelvisTurn = 3.00, PelvisBend = 19.00, PelvisSideBend = -2.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 49, 30), PelvisTurn = 9.00, PelvisBend = 20.00, PelvisSideBend = -3.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 37, 20), PelvisTurn = 9.00, PelvisBend = 21.00, PelvisSideBend = -2.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 15, 29), PelvisTurn = 4.00, PelvisBend = 21.00, PelvisSideBend = -1.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 02, 42), PelvisTurn = 5.00, PelvisBend = 20.00, PelvisSideBend = -3.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 51, 19), PelvisTurn = 3.00, PelvisBend = 19.00, PelvisSideBend = -2.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 40, 02), PelvisTurn = 9.00, PelvisBend = 20.00, PelvisSideBend = -3.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 32, 51), PelvisTurn = 9.00, PelvisBend = 21.00, PelvisSideBend = -2.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 19, 45), PelvisTurn = 4.00, PelvisBend = 21.00, PelvisSideBend = -1.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 10, 30), PelvisTurn = 5.00, PelvisBend = 20.00, PelvisSideBend = -3.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 02, 00), PelvisTurn = 3.00, PelvisBend = 19.00, PelvisSideBend = -2.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 49, 30), PelvisTurn = 9.00, PelvisBend = 20.00, PelvisSideBend = -3.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 37, 20), PelvisTurn = 9.00, PelvisBend = 21.00, PelvisSideBend = -2.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 15, 29), PelvisTurn = 4.00, PelvisBend = 21.00, PelvisSideBend = -1.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 02, 42), PelvisTurn = 5.00, PelvisBend = 20.00, PelvisSideBend = -3.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 12, 51, 19), PelvisTurn = 3.00, PelvisBend = 19.00, PelvisSideBend = -2.00 });
            swingResults.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 12, 40, 02), PelvisTurn = 9.00, PelvisBend = 20.00, PelvisSideBend = -3.00 });

            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 37, 51), TorsoTurn = 10.00, TorsoBend = 31.00, TorsoSideBend = 11.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 28, 29), TorsoTurn = 8.00, TorsoBend = 37.00, TorsoSideBend = 10.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 10, 42), TorsoTurn = 8.00, TorsoBend = 40.00, TorsoSideBend = 9.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 02, 19), TorsoTurn = 10.00, TorsoBend = 40.00, TorsoSideBend = 11.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 49, 30), TorsoTurn = 2.00, TorsoBend = 42.00, TorsoSideBend = 10.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 37, 20), TorsoTurn = 7.60, TorsoBend = 39.40, TorsoSideBend = 10.20 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 15, 29), TorsoTurn = 8.00, TorsoBend = 40.00, TorsoSideBend = 10.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 02, 42), TorsoTurn = 10.00, TorsoBend = 31.00, TorsoSideBend = 11.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 51, 19), TorsoTurn = 8.00, TorsoBend = 37.00, TorsoSideBend = 10.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 40, 02), TorsoTurn = 8.00, TorsoBend = 40.00, TorsoSideBend = 9.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 32, 51), TorsoTurn = 10.00, TorsoBend = 40.00, TorsoSideBend = 11.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 19, 45), TorsoTurn = 2.00, TorsoBend = 42.00, TorsoSideBend = 10.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 10, 30), TorsoTurn = 7.60, TorsoBend = 39.40, TorsoSideBend = 10.20 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 02, 00), TorsoTurn = 8.00, TorsoBend = 40.00, TorsoSideBend = 10.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 49, 30), TorsoTurn = 10.00, TorsoBend = 31.00, TorsoSideBend = 11.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 37, 20), TorsoTurn = 8.00, TorsoBend = 37.00, TorsoSideBend = 10.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 15, 29), TorsoTurn = 8.00, TorsoBend = 40.00, TorsoSideBend = 9.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 02, 42), TorsoTurn = 10.00, TorsoBend = 40.00, TorsoSideBend = 11.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 12, 51, 19), TorsoTurn = 2.00, TorsoBend = 42.00, TorsoSideBend = 10.00 });
            swingResults.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 12, 40, 02), TorsoTurn = 7.60, TorsoBend = 39.40, TorsoSideBend = 10.20 });

            LastFiveRadioButton.IsChecked = true;
        }

        private void LastFive_Checked(object sender, RoutedEventArgs e)
        {
            var swingResultsLastFive = swingResults.Take(5);
            dgMultiSwingData.ItemsSource = swingResultsLastFive;

        }

        private void LastTen_Checked(object sender, RoutedEventArgs e)
        {
            var swingResultsLastTen = swingResults.Take(10);
            dgMultiSwingData.ItemsSource = swingResultsLastTen;
        }

        private void LastFifteen_Checked(object sender, RoutedEventArgs e)
        {
            var swingResultsLastFifteen = swingResults.Take(15);
            dgMultiSwingData.ItemsSource = swingResultsLastFifteen;
        }

        private void All_Checked(object sender, RoutedEventArgs e)
        {
            dgMultiSwingData.ItemsSource = swingResults;
        }
    }
}
