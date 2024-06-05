using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string MemoryNum;
        private string State;

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            DisplayNum = "";
            MemoryShown = "";
            MemoryNum = "";
            State = "idle";
        }

        private string displayNum;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string DisplayNum
        {
            get { return displayNum; }
            set 
            { 
                displayNum = value;
                OnPropertyChanged();
            }
        }

        private string memoryShown;

        public string MemoryShown
        {
            get { return memoryShown; }
            set 
            {
                memoryShown = value;
                OnPropertyChanged();
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            MemoryNum = DisplayNum;
            MemoryShown = MemoryNum + " +";
            DisplayNum = "";
            State = "plus";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            MemoryNum = DisplayNum;
            MemoryShown = MemoryNum + " -";
            DisplayNum = "";
            State = "minus";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            MemoryNum = DisplayNum;
            MemoryShown = MemoryNum + " x";
            DisplayNum = "";
            State = "multiply";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            MemoryNum = DisplayNum;
            MemoryShown = MemoryNum + " /";
            DisplayNum = "";
            State = "divide";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "9";
        }


        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += "0";
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum += ".";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if ( State == "plus")
            {
                DisplayNum = Math.Round((decimal.Parse(MemoryNum) + decimal.Parse(DisplayNum)), 3).ToString();
            }
            else if (State == "minus")
            {
                DisplayNum = Math.Round((decimal.Parse(MemoryNum) - decimal.Parse(DisplayNum)), 3).ToString();
            }
            else if (State == "multiply")
            {
                DisplayNum = Math.Round((decimal.Parse(MemoryNum) * decimal.Parse(DisplayNum)), 3).ToString();
            }
            else
            {
                DisplayNum = Math.Round((decimal.Parse(MemoryNum) / decimal.Parse(DisplayNum)), 3).ToString();
            }
            MemoryShown = "";
        }

        private void AC_Click(object sender, RoutedEventArgs e)
        {
            DisplayNum = "";
            MemoryNum = "";
            MemoryShown = "";
        }
    }
}