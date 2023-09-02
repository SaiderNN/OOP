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
using MeasuringDevice;
using DeviceControl;
using FabrikamDevices;
using ContosoDevices;

namespace ООП_4_кв_1._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private IMeasuringDevice device, device2;
        private void CreateInstance_Click(object sender, RoutedEventArgs e)
        {
            if (Metric_ratio.IsChecked == true)
            {
                 device = new MeasureLengthDevice(Units.Metric);
            }
            if (Imperial_ratio.IsChecked == true)
            {
                 device = new MeasureLengthDevice(Units.Imperial);
            }
        }

        private void Start_btn_Click(object sender, RoutedEventArgs e)
        {
            device.StartCollecting();   
        }

        private void Stop_btn_Click(object sender, RoutedEventArgs e)
        {
            device.StopCollecting();
        }

        private void getdata_Click(object sender, RoutedEventArgs e)
        {
            databox.Items.Clear();
            int[] data = device.GetRawData();
            foreach ( int item in data)
            {
                databox.Items.Add(item);
            }

        }

        private void getMetric_Click(object sender, RoutedEventArgs e)
        {
            decimal ImperialValue = device.ImperialValue();
            Metric_lb.Content = ImperialValue.ToString();
        }

        private void getImperial_Click(object sender, RoutedEventArgs e)
        {
            decimal MetricValue = device.MetricValue();
            Imperial_lb.Content = MetricValue.ToString();
        }

        private void Start_btn2_Click(object sender, RoutedEventArgs e)
        {
            device2.StartCollecting();
        }

        private void getMetric2_Click(object sender, RoutedEventArgs e)
        {
            decimal ImperialValue2 = device2.ImperialValue();
            Metric_lb2.Content = ImperialValue2.ToString();
        }

        private void getImperial2_Click(object sender, RoutedEventArgs e)
        {
            decimal MetricValue2 = device2.MetricValue();
            Imperial_lb2.Content = MetricValue2.ToString();
        }

        private void getdata2_Click(object sender, RoutedEventArgs e)
        {
            databox2.Items.Clear();
            int[] data = device2.GetRawData();
            foreach (int item in data)
            {
                databox2.Items.Add(item);
            }

        }

        private void Stop_btn2_Click(object sender, RoutedEventArgs e)
        {
            device2.StopCollecting();
        }

        private void CreateInstance2_Click(object sender, RoutedEventArgs e)
        {
            if (Metric_ratio2.IsChecked == true)
            {
                device2 = new MeasureMassDevice(Units.Metric);
            }
            if (Imperial_ratio2.IsChecked == true)
            {
                device2 = new MeasureMassDevice(Units.Imperial);
            }

        }
    }
}
