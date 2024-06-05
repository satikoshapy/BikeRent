using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BikeRent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Company _company;

        private BitmapImage _maleBikeImage;
        private BitmapImage _femaleBikeImage;
        private BitmapImage _electricalImage;
        
        public MainWindow()
        {
            InitializeComponent();

            _maleBikeImage = ImageUtils.CreateBitmapImage("Images/MaleBike.png");
            _femaleBikeImage = ImageUtils.CreateBitmapImage("Images/FemaleBike.png");
            _electricalImage = ImageUtils.CreateBitmapImage("Images/Electrical.png");

            _company = new Company();
            
            BindCurrentBike(_company.CurrentBike);
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            _company.Next();
            BindCurrentBike(_company.CurrentBike);
        }

        private void BindCurrentBike(BikeBase bike)
        {
            // ToDo:
            //  - Place info on the screen
            //  - look at the screenshots to know exactly what and when

            idTextBlock.Text = "00" + bike.Id;
            brandTextBlock.Text = bike.Brand;
            typeTextBlock.Text = bike.Type;
            descriptionTextBlock.Text = bike.Description;
            maintenanceProgressBar.Maximum = bike.KmPerMaintenanceCycle;
            maintenanceProgressBar.Value = bike.TotalDistance;
            maintenanceTextBlock.Text = bike.TotalDistance + " / " + bike.KmPerMaintenanceCycle + " km";
            genderImage.Source = GetBikeImageBy(bike.Gender);
            if (bike is EBike ebike)
            {
                electricalImage.Source = _electricalImage;
                batteryTextBlock.Text = ebike.BatteryCapacity + " Wh";
            }
            else
            {
                electricalImage.Visibility = Visibility.Collapsed;
                batteryTextBlock.Text = "";
            }
            rentOrReturnButton.DataContext = bike;
            rentOrReturnButton.Click += RentOrReturnButton_Click;
        }

        private void RentOrReturnButton_Click(object sender, RoutedEventArgs e)
        {
            

            Button clickedItem = sender as Button;

            Bike bike = clickedItem.DataContext as Bike;

            RentalWindow rentalWindow = new RentalWindow(bike);
            rentalWindow.Show();

        }

        private BitmapImage GetBikeImageBy(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return _maleBikeImage;
            }
            else
            {
                return _femaleBikeImage;
            }
        }

        

        private void exportItem_Click(object sender, RoutedEventArgs e)
        {
            // ToDo
            //  Create a report on the desktop of the current user
            //  report name: e.g. Bike_003.html (use Id property)
            //  Use CreateReport from ReportUtils   
        }

        private void exitItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
