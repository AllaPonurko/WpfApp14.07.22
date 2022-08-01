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

namespace WpfApp14._07._22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            CommandBinding commandBinding1 = new CommandBinding();
            commandBinding1.Command = WindowCommands.PerformanceSumm;
            commandBinding1.Executed += PerformanceSumm_Executed;
            btn_sum.CommandBindings.Add(commandBinding1);
            CommandBinding commandBinding2 = new CommandBinding();
            btn_substruction.CommandBindings.Add(commandBinding2);
            commandBinding2.Command = WindowCommands.PerformanceSubstruction;
            commandBinding2.Executed += PerformanceSubstruction_Executed;
            btn_substruction.CommandBindings.Add(commandBinding2);
            CommandBinding commandBinding3 = new CommandBinding();
            commandBinding3.Command = WindowCommands.PerformanceMultiply;
            commandBinding3.Executed += PerformanceMultiply_Executed;
            btn_multiply.CommandBindings.Add(commandBinding3);
            CommandBinding commandBinding4 = new CommandBinding();
            commandBinding4.Command = WindowCommands.PerformanceDivision;
            commandBinding4.Executed += PerformanceDivision_Executed;
            btn_division.CommandBindings.Add(commandBinding4);
        }

        
        private void PerformanceSumm_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            result = Convert.ToDouble(txtEnter.Text);
            summ = true;
            subtraction = false;
            multiply = false;
            division = false;
            txtEnter.Text = null;
            txtResult.Text += result + btn_sum.Content.ToString();
        }
        private void PerformanceSubstruction_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            result = Convert.ToDouble(txtEnter.Text);
            summ = false;
            subtraction = true;
            multiply = false;
            division = false;
            txtEnter.Text = null;
            txtResult.Text += result + btn_substruction.Content.ToString();
        }
        private void PerformanceMultiply_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            result = Convert.ToDouble(txtEnter.Text);
            summ = false;
            subtraction = false;
            multiply = true;
            division = false;
            txtEnter.Text = null;
            txtResult.Text += result + btn_multiply.Content.ToString();
        }
        private void PerformanceDivision_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            result = Convert.ToDouble(txtEnter.Text);
            summ = false;
            subtraction = false;
            multiply = false;
            division = true;
            txtEnter.Text = null;
            txtResult.Text +=result+ btn_division.Content.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {if(txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text=txtEnter.Text.TrimStart('0');
            }
        if(txtEnter.Text.StartsWith("0,"))
            txtEnter.Text += btn2.Content.ToString();
         else
                txtEnter.Text += btn2.Content.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text = txtEnter.Text.TrimStart('0');
            }
            if (txtEnter.Text.StartsWith("0,"))
                txtEnter.Text += btn3.Content.ToString();
            else
                txtEnter.Text += btn3.Content.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text = txtEnter.Text.TrimStart('0');
            }
            if (txtEnter.Text.StartsWith("0,"))
                txtEnter.Text += btn1.Content.ToString();
            else
                txtEnter.Text += btn1.Content.ToString();

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text = txtEnter.Text.TrimStart('0');
            }
            if (txtEnter.Text.StartsWith("0,"))
                txtEnter.Text += btn4.Content.ToString();
            else
                txtEnter.Text += btn4.Content.ToString();
        }
        bool summ = false;
        bool subtraction = false;
        bool multiply = false;
        bool division = false;
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        double result=0;
        private void btn_sum_Click(object sender, RoutedEventArgs e)
        {
            //result = Convert.ToDouble(txtEnter.Text);
            //summ = true;
            //subtraction = false;
            //multiply = false;
            //division = false;
            //txtEnter.Text = null;
            //txtResult.Text +=result+ btn_sum.Content.ToString();
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            if (summ) 
            { 
                result += Convert.ToDouble(txtEnter.Text);
                txtResult.Text = result.ToString();
            }
            if (subtraction)
            {
                result -= Convert.ToDouble(txtEnter.Text);
                txtResult.Text = result.ToString();
            }
            if (multiply )
            {
                result *= Convert.ToDouble(txtEnter.Text);
                txtResult.Text = result.ToString();
            }
            if (division && Convert.ToDouble(txtEnter.Text) == 0)
            { 
                MessageBox.Show("Ошибка! Деление на ноль!!!");
                txtResult.Text = "Error";
            }
            if (division && Convert.ToDouble(txtEnter.Text) != 0)
            { 
                result /= Convert.ToDouble(txtEnter.Text);
                txtResult.Text = result.ToString();
            }
            
        }

        private void btn_substruction_Click(object sender, RoutedEventArgs e)
        {
            //result = Convert.ToDouble(txtEnter.Text);
            //summ = false;
            //subtraction = true;
            //multiply = false;
            //division = false;
            //txtEnter.Text = null;
            //txtResult.Text +=result+ btn_substruction.Content.ToString();
        }

        private void btn_multiply_Click(object sender, RoutedEventArgs e)
        {
            //result = Convert.ToDouble(txtEnter.Text);
            //summ = false;
            //subtraction = false;
            //multiply = true;
            //division = false;
            //txtEnter.Text = null;
            //txtResult.Text +=result+ btn_multiply.Content.ToString();
        }

        private void btn_division_Click(object sender, RoutedEventArgs e)
        {
            //result = Convert.ToDouble(txtEnter.Text);
            //summ = false;
            //subtraction = false;
            //multiply = false;
            //division = true;
            //txtEnter.Text = null;
            //txtResult.Text +=result+ btn_division.Content.ToString();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text != null) txtEnter.Text = null;
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text != null) txtEnter.Text = null;
            if (txtResult.Text != null) txtResult.Text = null;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            
            txtEnter.Text += btn0.Content.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text = txtEnter.Text.TrimStart('0');
            }
            if (txtEnter.Text.StartsWith("0,"))
                txtEnter.Text += btn5.Content.ToString();
            else
                txtEnter.Text += btn5.Content.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text = txtEnter.Text.TrimStart('0');
            }
            if (txtEnter.Text.StartsWith("0,"))
                txtEnter.Text += btn6.Content.ToString();
            else
                txtEnter.Text += btn6.Content.ToString();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text = txtEnter.Text.TrimStart('0');
            }
            if (txtEnter.Text.StartsWith("0,"))
                txtEnter.Text += btn7.Content.ToString();
            else
                txtEnter.Text += btn7.Content.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text = txtEnter.Text.TrimStart('0');
            }
            if (txtEnter.Text.StartsWith("0,"))
                txtEnter.Text += btn8.Content.ToString();
            else
                txtEnter.Text += btn8.Content.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text.StartsWith("0"))
            {
                txtEnter.Text = txtEnter.Text.TrimStart('0');
            }
            if (txtEnter.Text.StartsWith("0,"))
                txtEnter.Text += btn9.Content.ToString();
            else
                txtEnter.Text += btn9.Content.ToString();
        }

        private void btn__Click(object sender, RoutedEventArgs e)
        {
            if(txtEnter.Text.Length != 0 && txtEnter.Text.Contains(","))
            {
                MessageBox.Show("Ошибка! В десятичное число нельзя вводить ещё один разделитель!");

            }
            else 
            { 
            if (txtEnter.Text.Length != 0)
            txtEnter.Text += ",".ToString();
            if (txtEnter.Text.Length == 0)
                txtEnter.Text += "0,".ToString();
            }
        }

        private void btn_RemoveLast_Click(object sender, RoutedEventArgs e)
        {
            if (txtEnter.Text.Length != 0)
                txtEnter.Text = txtEnter.Text.Remove(txtEnter.Text.Length - 1);
        }

        private void txtEnter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtResult.Text.StartsWith("0,"))
                txtResult.Text = txtEnter.Text;
            if (txtResult.Text.StartsWith("0"))
            {
                txtResult.Text = txtResult.Text.TrimStart('0');
            }
            else
                txtResult.Text = txtEnter.Text;
        }
    }
}
