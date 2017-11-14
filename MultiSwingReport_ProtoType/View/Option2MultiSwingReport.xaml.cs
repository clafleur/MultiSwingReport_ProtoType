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

namespace MultiSwingReport_ProtoType.View
{
    /// <summary>
    /// Interaction logic for Option2MultiSwingReport.xaml
    /// </summary>
    public partial class Option2MultiSwingReport : UserControl
    {
        List<AddressSwingResults> addressPositionPelvis = new List<AddressSwingResults>();
        List<AddressSwingResults> addressPositionTorso = new List<AddressSwingResults>();
        List<AddressSwingResults> addressSR = new List<AddressSwingResults>();

        public Option2MultiSwingReport()
        {
            InitializeComponent();

            #region AddressSwingResults

            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 37, 51), Turn = 9.00, Bend = 21.00, SideBend = -2.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 28, 29), Turn = 4.00, Bend = 21.00, SideBend = -1.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 10, 42), Turn = 5.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 02, 19), Turn = 3.00, Bend = 19.00, SideBend = -2.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 49, 30), Turn = 9.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 37, 20), Turn = 9.00, Bend = 21.00, SideBend = -2.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 15, 29), Turn = 4.00, Bend = 21.00, SideBend = -1.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 02, 42), Turn = 5.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 51, 19), Turn = 3.00, Bend = 19.00, SideBend = -2.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 40, 02), Turn = 9.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 32, 51), Turn = 9.00, Bend = 21.00, SideBend = -2.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 19, 45), Turn = 4.00, Bend = 21.00, SideBend = -1.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 10, 30), Turn = 5.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 02, 00), Turn = 3.00, Bend = 19.00, SideBend = -2.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 49, 30), Turn = 9.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 37, 20), Turn = 9.00, Bend = 21.00, SideBend = -2.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 15, 29), Turn = 4.00, Bend = 21.00, SideBend = -1.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 02, 42), Turn = 5.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 12, 51, 19), Turn = 3.00, Bend = 19.00, SideBend = -2.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 12, 40, 02), Turn = 9.00, Bend = 20.00, SideBend = -3.00 });

            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 37, 51), Turn = 10.00, Bend = 31.00, SideBend = 11.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 28, 29), Turn = 8.00, Bend = 37.00, SideBend = 10.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 10, 42), Turn = 8.00, Bend = 40.00, SideBend = 9.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 02, 19), Turn = 10.00, Bend = 40.00, SideBend = 11.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 49, 30), Turn = 2.00, Bend = 42.00, SideBend = 10.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 37, 20), Turn = 7.60, Bend = 39.40, SideBend = 10.20 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 15, 29), Turn = 8.00, Bend = 40.00, SideBend = 10.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 02, 42), Turn = 10.00, Bend = 31.00, SideBend = 11.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 51, 19), Turn = 8.00, Bend = 37.00, SideBend = 10.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 40, 02), Turn = 8.00, Bend = 40.00, SideBend = 9.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 32, 51), Turn = 10.00, Bend = 40.00, SideBend = 11.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 19, 45), Turn = 2.00, Bend = 42.00, SideBend = 10.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 10, 30), Turn = 7.60, Bend = 39.40, SideBend = 10.20 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 02, 00), Turn = 8.00, Bend = 40.00, SideBend = 10.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 49, 30), Turn = 10.00, Bend = 31.00, SideBend = 11.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 37, 20), Turn = 8.00, Bend = 37.00, SideBend = 10.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 15, 29), Turn = 8.00, Bend = 40.00, SideBend = 9.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 02, 42), Turn = 10.00, Bend = 40.00, SideBend = 11.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 12, 51, 19), Turn = 2.00, Bend = 42.00, SideBend = 10.00 });
            addressSR.Add(new AddressSwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 12, 40, 02), Turn = 7.60, Bend = 39.40, SideBend = 10.20 });

            //Put each position into its own list
            foreach (var item in addressSR)
            {
                if (item.Position == "Pelvis")
                {
                    addressPositionPelvis.Add(item);
                }
                else
                {
                    addressPositionTorso.Add(item);
                }
            }

            #endregion

            LastFiveRadioButton.IsChecked = true;
        }

        private void LastFive_Checked(object sender, RoutedEventArgs e)
        {
            var addressPelvisLastFive = addressPositionPelvis.Take(5);
            AddressPelvisItemsControl.ItemsSource = addressPelvisLastFive;
            var addressTorsoLastFive = addressPositionTorso.Take(5);
            AddressTorsoItemsControl.ItemsSource = addressTorsoLastFive;

            var topPelvisLastFive = addressPositionPelvis.Take(5);
            TopPelvisItemsControl.ItemsSource = topPelvisLastFive;
            var topTorsoLastFive = addressPositionTorso.Take(5);
            TopTorsoItemsControl.ItemsSource = topTorsoLastFive;

            var impactPelvisLastFive = addressPositionPelvis.Take(5);
            ImpactPelvisItemsControl.ItemsSource = impactPelvisLastFive;
            var impactTorsoLastFive = addressPositionTorso.Take(5);
            ImpactTorsoItemsControl.ItemsSource = impactTorsoLastFive;

        }

        private void LastTen_Checked(object sender, RoutedEventArgs e)
        {
            var addressPelvisLastTen = addressPositionPelvis.Take(10);
            AddressPelvisItemsControl.ItemsSource = addressPelvisLastTen;
            var addressTorsoLastTen = addressPositionTorso.Take(10);
            AddressTorsoItemsControl.ItemsSource = addressTorsoLastTen;

            var topPelvisLastTen = addressPositionPelvis.Take(10);
            TopPelvisItemsControl.ItemsSource = topPelvisLastTen;
            var topTorsoLastTen = addressPositionTorso.Take(10);
            TopTorsoItemsControl.ItemsSource = topTorsoLastTen;

            var impactPelvisLastTen = addressPositionPelvis.Take(10);
            ImpactPelvisItemsControl.ItemsSource = impactPelvisLastTen;
            var impactTorsoLastTen = addressPositionTorso.Take(10);
            ImpactTorsoItemsControl.ItemsSource = impactTorsoLastTen;
        }

        private void LastFifteen_Checked(object sender, RoutedEventArgs e)
        {
            var addressPelvisLastFifteen = addressPositionPelvis.Take(15);
            AddressPelvisItemsControl.ItemsSource = addressPelvisLastFifteen;
            var addressTorsoLastFifteen = addressPositionTorso.Take(15);
            AddressTorsoItemsControl.ItemsSource = addressTorsoLastFifteen;

            var topPelvisLastFifteen = addressPositionPelvis.Take(15);
            TopPelvisItemsControl.ItemsSource = topPelvisLastFifteen;
            var topTorsoLastFifteen = addressPositionTorso.Take(15);
            TopTorsoItemsControl.ItemsSource = topTorsoLastFifteen;

            var impactPelvisLastFifteen = addressPositionPelvis.Take(15);
            ImpactPelvisItemsControl.ItemsSource = impactPelvisLastFifteen;
            var impactTorsoLastFifteen = addressPositionTorso.Take(15);
            ImpactTorsoItemsControl.ItemsSource = impactTorsoLastFifteen;
        }

        private void All_Checked(object sender, RoutedEventArgs e)
        {
            AddressPelvisItemsControl.ItemsSource = addressPositionPelvis;
            AddressTorsoItemsControl.ItemsSource = addressPositionTorso;

            TopPelvisItemsControl.ItemsSource = addressPositionPelvis;
            TopTorsoItemsControl.ItemsSource = addressPositionTorso;

            ImpactPelvisItemsControl.ItemsSource = addressPositionPelvis;
            ImpactTorsoItemsControl.ItemsSource = addressPositionTorso;
        }
    }
}
