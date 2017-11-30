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
using MaterialDesignThemes.Wpf;
using System.Collections.ObjectModel;

namespace MultiSwingReport_ProtoType.View
{
    /// <summary>
    /// Interaction logic for MultiSwingReport.xaml
    /// </summary>
    public partial class MultiSwingReport : UserControl
    {
        List<SwingResults> addressPositionPelvis = new List<SwingResults>();
        List<SwingResults> addressPositionTorso = new List<SwingResults>();
        List<SwingResults> addressSR = new List<SwingResults>();

        public MultiSwingReport()
        {
            InitializeComponent();

            #region AddressSwingResults
            
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 37, 51), Turn = 9.00, Bend = 21.00, SideBend = -2.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 28, 29), Turn = 4.00, Bend = 21.00, SideBend = -1.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 10, 42), Turn = 5.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 16, 02, 19), Turn = 3.00, Bend = 19.00, SideBend = -2.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 49, 30), Turn = 9.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 37, 20), Turn = 9.00, Bend = 21.00, SideBend = -2.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 15, 29), Turn = 4.00, Bend = 21.00, SideBend = -1.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 15, 02, 42), Turn = 5.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 51, 19), Turn = 3.00, Bend = 19.00, SideBend = -2.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 40, 02), Turn = 9.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 32, 51), Turn = 9.00, Bend = 21.00, SideBend = -2.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 19, 45), Turn = 4.00, Bend = 21.00, SideBend = -1.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 10, 30), Turn = 5.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 14, 02, 00), Turn = 3.00, Bend = 19.00, SideBend = -2.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 49, 30), Turn = 9.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 37, 20), Turn = 9.00, Bend = 21.00, SideBend = -2.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 15, 29), Turn = 4.00, Bend = 21.00, SideBend = -1.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 13, 02, 42), Turn = 5.00, Bend = 20.00, SideBend = -3.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 12, 51, 19), Turn = 3.00, Bend = 19.00, SideBend = -2.00 });
            addressSR.Add(new SwingResults() { Position = "Pelvis", Date = new DateTime(2017, 2, 27, 12, 40, 02), Turn = 9.00, Bend = 20.00, SideBend = -3.00 });

            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 37, 51), Turn = 10.00, Bend = 31.00, SideBend = 11.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 28, 29), Turn = 8.00, Bend = 37.00, SideBend = 10.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 10, 42), Turn = 8.00, Bend = 40.00, SideBend = 9.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 16, 02, 19), Turn = 10.00, Bend = 40.00, SideBend = 11.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 49, 30), Turn = 2.00, Bend = 42.00, SideBend = 10.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 37, 20), Turn = 7.60, Bend = 39.40, SideBend = 10.20 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 15, 29), Turn = 8.00, Bend = 40.00, SideBend = 10.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 15, 02, 42), Turn = 10.00, Bend = 31.00, SideBend = 11.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 51, 19), Turn = 8.00, Bend = 37.00, SideBend = 10.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 40, 02), Turn = 8.00, Bend = 40.00, SideBend = 9.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 32, 51), Turn = 10.00, Bend = 40.00, SideBend = 11.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 19, 45), Turn = 2.00, Bend = 42.00, SideBend = 10.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 10, 30), Turn = 7.60, Bend = 39.40, SideBend = 10.20 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 14, 02, 00), Turn = 8.00, Bend = 40.00, SideBend = 10.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 49, 30), Turn = 10.00, Bend = 31.00, SideBend = 11.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 37, 20), Turn = 8.00, Bend = 37.00, SideBend = 10.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 15, 29), Turn = 8.00, Bend = 40.00, SideBend = 9.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 13, 02, 42), Turn = 10.00, Bend = 40.00, SideBend = 11.00});
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 12, 51, 19), Turn = 2.00, Bend = 42.00, SideBend = 10.00 });
            addressSR.Add(new SwingResults() { Position = "Torso", Date = new DateTime(2017, 2, 27, 12, 40, 02), Turn = 7.60, Bend = 39.40, SideBend = 10.20 });

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
            AddressPelvisDataGrid.ItemsSource = addressPelvisLastFive;
            var addressTorsoLastFive = addressPositionTorso.Take(5);
            AddressTorsoDataGrid.ItemsSource = addressTorsoLastFive;

            var topPelvisLastFive = addressPositionPelvis.Take(5);
            TopPelvisDataGrid.ItemsSource = topPelvisLastFive;
            var topTorsoLastFive = addressPositionTorso.Take(5);
            TopTorsoDataGrid.ItemsSource = topTorsoLastFive;

            var hitPelvisLastFive = addressPositionPelvis.Take(5);
            HitPelvisDataGrid.ItemsSource = hitPelvisLastFive;
            var hitTorsoLastFive = addressPositionTorso.Take(5);
            HitTorsoDataGrid.ItemsSource = hitTorsoLastFive;

        }

        private void LastTen_Checked(object sender, RoutedEventArgs e)
        {
            var addressPelvisLastTen = addressPositionPelvis.Take(10);
            AddressPelvisDataGrid.ItemsSource = addressPelvisLastTen;
            var addressTorsoLastTen = addressPositionTorso.Take(10);
            AddressTorsoDataGrid.ItemsSource = addressTorsoLastTen;

            var topPelvisLastTen = addressPositionPelvis.Take(10);
            TopPelvisDataGrid.ItemsSource = topPelvisLastTen;
            var topTorsoLastTen = addressPositionTorso.Take(10);
            TopTorsoDataGrid.ItemsSource = topTorsoLastTen;

            var hitPelvisLastTen = addressPositionPelvis.Take(10);
            HitPelvisDataGrid.ItemsSource = hitPelvisLastTen;
            var hitTorsoLastTen = addressPositionTorso.Take(10);
            HitTorsoDataGrid.ItemsSource = hitTorsoLastTen;
        }

        private void LastFifteen_Checked(object sender, RoutedEventArgs e)
        {
            var addressPelvisLastFifteen = addressPositionPelvis.Take(15);
            AddressPelvisDataGrid.ItemsSource = addressPelvisLastFifteen;
            var addressTorsoLastFifteen = addressPositionTorso.Take(15);
            AddressTorsoDataGrid.ItemsSource = addressTorsoLastFifteen;

            var topPelvisLastFifteen = addressPositionPelvis.Take(15);
            TopPelvisDataGrid.ItemsSource = topPelvisLastFifteen;
            var topTorsoLastFifteen = addressPositionTorso.Take(15);
            TopTorsoDataGrid.ItemsSource = topTorsoLastFifteen;

            var hitPelvisLastFifteen = addressPositionPelvis.Take(15);
            HitPelvisDataGrid.ItemsSource = hitPelvisLastFifteen;
            var hitTorsoLastFifteen = addressPositionTorso.Take(15);
            HitTorsoDataGrid.ItemsSource = hitTorsoLastFifteen;
        }

        private void All_Checked(object sender, RoutedEventArgs e)
        {
            AddressPelvisDataGrid.ItemsSource = addressPositionPelvis;
            AddressTorsoDataGrid.ItemsSource = addressPositionTorso;

            TopPelvisDataGrid.ItemsSource = addressPositionPelvis;
            TopTorsoDataGrid.ItemsSource = addressPositionTorso;

            HitPelvisDataGrid.ItemsSource = addressPositionPelvis;
            HitTorsoDataGrid.ItemsSource = addressPositionTorso;
        }
    }

    public class SwingResults
    {
        public string Position { get; set; }
        public DateTime Date { get; set; }
        public double Turn { get; set; }
        public double Bend { get; set; }
        public double SideBend { get; set; }
        public double PelvisTurn { get; set; }
        public double PelvisBend { get; set; }
        public double PelvisSideBend { get; set; }
        public double TorsoTurn { get; set; }
        public double TorsoBend { get; set; }
        public double TorsoSideBend { get; set; }
    }

    public class TopSwingResults
    {
        public string Position { get; set; }
        public DateTime Date { get; set; }
        public double Turn { get; set; }
        public double Bend { get; set; }
        public double SideBend { get; set; }
    }

    public class Player {
        public string Name { get; set; }
        public ObservableCollection<SwingResults> SwingResults { get; set; }
    }
}
