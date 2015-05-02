using Microsoft.Phone.Controls;

namespace CarVoter
{
    public partial class MainPage 
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
         
    }
}