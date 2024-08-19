using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace JamsBudgeteer
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

        // minimizes window using WindowState
        private void MinimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Allows user to drag window for bound location (currently top row)
        private void DragMe(object sender, MouseButtonEventArgs e)
        {

            try
            {
                DragMove();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        // Closes window
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Navigate to the PaymentsWindow
        private void GoToPayments(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var newForm = new PaymentsWindow();
                newForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        // Navigate to the InvomeWindow
        private void GoToIncome(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var newForm = new IncomeWindow(); // create new form
                newForm.Show(); // show the new form
                this.Close(); // close current form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
