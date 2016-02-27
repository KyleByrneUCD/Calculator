using System;
using System.Windows;
using System.Windows.Input;

namespace EPCONCalculator
{
    #region MainWindow Class
    public partial class MainWindow : Window
    {
        private CalculatorViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new CalculatorViewModel();
            this.DataContext = _vm;
        }

        #region Number ButtonClick Events
        private void Click1(object sender, RoutedEventArgs e)
        {
            _vm.Click1();
        }
        private void Click2(object sender, RoutedEventArgs e)
        {
            _vm.Click2();
        }
        private void Click3(object sender, RoutedEventArgs e)
        {
            _vm.Click3();
        }
        private void Click4(object sender, RoutedEventArgs e)
        {
            _vm.Click4();
        }
        private void Click5(object sender, RoutedEventArgs e)
        {
            _vm.Click5();
        }
        private void Click6(object sender, RoutedEventArgs e)
        {
            _vm.Click6();
        }
        private void Click7(object sender, RoutedEventArgs e)
        {
            _vm.Click7();
        }
        private void Click8(object sender, RoutedEventArgs e)
        {
            _vm.Click8();
        }
        private void Click9(object sender, RoutedEventArgs e)
        {
            _vm.Click9();
        }
        private void Click0(object sender, RoutedEventArgs e)
        {
            _vm.Click0();
        }
        private void ClickDecimal(object sender, RoutedEventArgs e)
        {
            _vm.ClickDecimal();
        }
        #endregion

        #region Operator ButtonClick Events
        private void ClickPlus(object sender, RoutedEventArgs e)
        {
            _vm.ClickPlus();
        }
        private void ClickMinus(object sender, RoutedEventArgs e)
        {
            _vm.ClickMinus();
        }
        private void ClickMult(object sender, RoutedEventArgs e)
        {
            _vm.ClickMult();
        }
        private void ClickDivide(object sender, RoutedEventArgs e)
        {
            _vm.ClickDivide();
        }
        private void ClickEquals(object sender, RoutedEventArgs e)
        {
            _vm.ClickEquals();
        }
        private void ClickMakeNegative(object sender, RoutedEventArgs e)
        {
            _vm.ClickMakeNegative();
        }
        private void ClickClearAll(object sender, RoutedEventArgs e)
        {
            _vm.ClickClearAll();
        }
        private void ClickClearScreen(object sender, RoutedEventArgs e)
        {
            _vm.ClickClearScreen();
        }
        private void ClickBackSpace(object sender, RoutedEventArgs e)
        {
            _vm.ClickBackSpace();
        }
        #endregion

        #region Extended Functionaluty Click Events
        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            _vm.Sqrt_Click();
        }
        private void Pi_Click(object sender, RoutedEventArgs e)
        {
            _vm.Pi_Click();
        }
        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            _vm.Percent_Click();
        }
        private void Square_Click(object sender, RoutedEventArgs e)
        {
            _vm.Square_Click();
        }
        #endregion

        #region Helper Methods
        private void CheckifEmpty(String tempS)
        {
            _vm.CheckifEmpty(tempS);
        }
        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            _vm.MoveWindow();
        }
        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            _vm.CloseButton_MouseEnter();
        }
        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            _vm.CloseButton_MouseLeave();
        }
        private void MinimizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            _vm.MinimizeButton_MouseEnter();
        }
        private void MinimizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            _vm.MinimizeButton_MouseLeave();
        }
        private void CloseButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _vm.CloseButton_MouseLeftButtonUp();
        }
        private void MinimizeButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _vm.MinimizeButton_MouseLeftButtonUp();
        }
        private void MenuIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            _vm.MenuIcon_MouseEnter();
        }
        private void MenuIcon_MouseLeave(object sender, MouseEventArgs e)
        {
            _vm.MenuIcon_MouseLeave();
        }
        private void ViewMode_MouseEnter(object sender, MouseEventArgs e)
        {
            _vm.ViewMode_MouseEnter();
        }
        private void Standard_MouseEnter(object sender, MouseEventArgs e)
        {
            _vm.Standard_MouseEnter();
        }
        private void Expanded_MouseEnter(object sender, MouseEventArgs e)
        {
            _vm.Expanded_MouseEnter();
        }
        private void ViewMode_MouseLeave(object sender, MouseEventArgs e)
        {
            _vm.ViewMode_MouseLeave();
        }
        private void Standard_MouseLeave(object sender, MouseEventArgs e)
        {
            _vm.Standard_MouseLeave();
        }
        private void Expanded_MouseLeave(object sender, MouseEventArgs e)
        {
            _vm.Expanded_MouseLeave();
        }
        private void StandardView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _vm.StandardView_MouseLeftButtonDown();
        }
        private void ExtraFunctionView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _vm.ExtraFunctionView_MouseLeftButtonDown();
        }
        private void MenuIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _vm.MenuIcon_MouseLeftButtonDown();
        }
        private void Previous_Operand(String tempS)
        {
            _vm.Previous_Operand(tempS);
        }
        private void CheckCurrentValue()
        {
            _vm.CheckCurrentValue();
        }
        private void RemovePercentSymbol()
        {
            _vm.RemovePercentSymbol();
        }
        private void AddPercentSymbol()
        {
            _vm.AddPercentSymbol();
        }
        private Boolean ContainsSuperScript()
        {
            return _vm.ContainsSuperScript();
        }
        private void RemoveZeroWhenSqrt()
        {
            _vm.RemoveZeroWhenSqrt();
        }
        #endregion

        #region Keydown Events
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            _vm.Window_KeyUp(e);
        }
        #endregion
    }
    #endregion
}
