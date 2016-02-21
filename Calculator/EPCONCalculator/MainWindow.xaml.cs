using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace EPCONCalculator
{
    #region INotifyPropertyChanged & variables
    public class CurrentModel : INotifyPropertyChanged
    {
        private Double windowHeight;
        private String history;
        private String screen;
        private String closeIconSource;
        private String minimizeIconSource;
        private String menuIconSource;
        private Decimal currentValue;
        private Brush modeColor;
        private Brush standardViewColor;
        private Brush expandedViewColor;
        private Visibility menuVisibility;
        private Visibility extraFunctionsVisibility;

        public Double WindowHeight
        {
            get { return windowHeight; }
            set
            {
                if (windowHeight != value)
                {
                    windowHeight = value;
                    OnPropertyChanged("WindowHeight");
                }
            }
        }
        public String History
        {
            get { return history; }
            set
            {
                if (history != value)
                {
                    history = value;
                    OnPropertyChanged("History");
                }
            }
        }
        public String Screen
        {
            get { return screen; }
            set
            {
                if (screen != value)
                {
                    screen = value;
                    OnPropertyChanged("Screen");
                }
            }
        }
        public String CloseIconSource
        {
            get { return closeIconSource; }
            set
            {
                if (closeIconSource != value)
                {
                    closeIconSource = value;
                    OnPropertyChanged("CloseIconSource");
                }
            }
        }
        public String MinimizeIconSource
        {
            get { return minimizeIconSource; }
            set
            {
                if (minimizeIconSource != value)
                {
                    minimizeIconSource = value;
                    OnPropertyChanged("MinimizeIconSource");
                }
            }
        }
        public String MenuIconSource
        {
            get { return menuIconSource; }
            set
            {
                if (menuIconSource != value)
                {
                    menuIconSource = value;
                    OnPropertyChanged("MenuIconSource");
                }
            }
        }
        public Brush ModeColor
        {
            get { return modeColor; }
            set
            {
                if (modeColor != value)
                {
                    modeColor = value;
                    OnPropertyChanged("ModeColor");
                }
            }
        }
        public Brush StandardViewColor
        {
            get { return standardViewColor; }
            set
            {
                if (standardViewColor != value)
                {
                    standardViewColor = value;
                    OnPropertyChanged("StandardViewColor");
                }
            }
        }
        public Brush ExpandedViewColor
        {
            get { return expandedViewColor; }
            set
            {
                if (expandedViewColor != value)
                {
                    expandedViewColor = value;
                    OnPropertyChanged("ExpandedViewColor");
                }
            }
        }
        public Decimal CurrentValue
        {
            get { return currentValue; }
            set
            {
                if (currentValue != value)
                {
                    currentValue = value;
                    OnPropertyChanged("CurrentValue");
                }
            }
        }
        public Visibility MenuVisibility
        {
            get { return menuVisibility; }
            set
            {
                if (menuVisibility != value)
                {
                    menuVisibility = value;
                    OnPropertyChanged("MenuVisibility");
                }
            }
        }
        public Visibility ExtraFunctionsVisibility
        {
            get { return extraFunctionsVisibility; }
            set
            {
                if (extraFunctionsVisibility != value)
                {
                    extraFunctionsVisibility = value;
                    OnPropertyChanged("ExtraFunctionsVisibility");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
    #endregion

    #region MainWindow Class
    public partial class MainWindow : Window
    {
        private CurrentModel currentModel;
        private Boolean WhipeData = false;
        private String PreviousAnswer = "0";
        private Boolean PercentSymbol_Present = false;
        public MainWindow()
        {
            InitializeComponent();
            currentModel = new CurrentModel();
            currentModel.History = "";
            currentModel.Screen = "0";
            currentModel.CloseIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Close Gray(small).png";
            currentModel.MinimizeIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Minimize Icon Gray.png";
            currentModel.MenuIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\MenuIcon.png";
            currentModel.CurrentValue = 0;
            currentModel.ModeColor = Brushes.Black;
            currentModel.StandardViewColor = Brushes.Black;
            currentModel.ExpandedViewColor = Brushes.Black;
            currentModel.MenuVisibility = Visibility.Collapsed;
            currentModel.ExtraFunctionsVisibility = Visibility.Collapsed;
            currentModel.WindowHeight = 350;
            DataContext = currentModel;
        }

        #region Number ButtonClick Events
        private void Click1(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "1";
            AddPercentSymbol();

        }
        private void Click2(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "2";
            AddPercentSymbol();
        }
        private void Click3(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "3";
            AddPercentSymbol();
        }
        private void Click4(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "4";
            AddPercentSymbol();
        }
        private void Click5(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "5";
            AddPercentSymbol();
        }
        private void Click6(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "6";
            AddPercentSymbol();
        }
        private void Click7(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "7";
            AddPercentSymbol();
        }
        private void Click8(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "8";
            AddPercentSymbol();
        }
        private void Click9(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "9";
            AddPercentSymbol();
        }
        private void Click0(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "0";
            AddPercentSymbol();
        }
        private void ClickDecimal(object sender, RoutedEventArgs e)
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen.Contains("."))
            {
                return;
            }
            if (currentModel.Screen == "0" || currentModel.Screen == "")
            {
                currentModel.Screen = "0";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "0";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += ".";
            AddPercentSymbol();
        }
        #endregion

        #region Operator ButtonClick Events
        private void ClickPlus(object sender, RoutedEventArgs e)
        {
            decimal temp;
            Boolean sqrtCompleted = false;
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
                return;
            }
            if (currentModel.Screen == "0" || currentModel.Screen == "-0")
            {
                if (currentModel.History != "")
                {
                    currentModel.Screen = "Undefined";
                }
                return;
            }
            if (currentModel.Screen == "")
            {
                if (currentModel.History.Contains("+"))
                {
                    currentModel.History = currentModel.History.Replace("+", "-");
                }
                else if (currentModel.History.Contains("*"))
                {
                    currentModel.History = currentModel.History.Replace("*", "-");
                }
                else if (currentModel.History.Contains("/"))
                {
                    currentModel.History = currentModel.History.Replace("/", "-");
                }
                return;
            }
            else if (WhipeData == true)
            {
                currentModel.History = currentModel.Screen;
                currentModel.Screen = "";
                WhipeData = false;
            }
            if (currentModel.Screen.Contains("%"))
            {
                CheckCurrentValue();
                currentModel.History = Convert.ToString(currentModel.CurrentValue);
                currentModel.Screen = "";
            }
            if (currentModel.Screen.Contains("√"))
            {
                currentModel.History = currentModel.Screen;
                currentModel.History = currentModel.History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(currentModel.History);
                    if (value < 0)
                    {
                        currentModel.Screen = "Undefined";
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        currentModel.CurrentValue = Convert.ToDecimal(value);
                        currentModel.Screen = "";
                        sqrtCompleted = true;
                    }
                }
                catch
                {
                    currentModel.Screen = currentModel.Screen.Replace("√", "");
                    CheckCurrentValue();
                }

            }
            if (currentModel.Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                currentModel.Screen = Convert.ToString(currentModel.CurrentValue);
            }
            String tempS;
            try
            {
                if (sqrtCompleted == true)
                {
                    sqrtCompleted = false;
                    currentModel.History = Convert.ToString(currentModel.CurrentValue);
                    currentModel.History += " + ";
                    currentModel.Screen = "";
                    return;
                }
                currentModel.History += currentModel.Screen;
                currentModel.CurrentValue = Convert.ToDecimal(currentModel.History);
                currentModel.History += " + ";
                currentModel.Screen = "";
            }
            catch
            {
                tempS = Convert.ToString(currentModel.CurrentValue);
                currentModel.History = currentModel.History.Replace(tempS, "");
                CheckifEmpty(tempS);
                if (currentModel.History.Contains("+"))
                {
                    currentModel.History = currentModel.History.Replace(" + ", "");
                    if(ContainsSuperScript())
                    {

                    }
                    else if (currentModel.History.StartsWith("-"))
                    {
                        currentModel.History = currentModel.History.Replace("-", "");
                        temp = Convert.ToDecimal(currentModel.History) * -1;
                        currentModel.CurrentValue += temp;
                    }
                    else
                    {
                        temp = Convert.ToDecimal(currentModel.History);
                        currentModel.CurrentValue += temp;
                    }
                }
                else if (currentModel.History.Contains(" - "))
                {
                    currentModel.History = currentModel.History.Replace(" - ", "");
                    if (currentModel.History.StartsWith("-"))
                    {
                        currentModel.History = currentModel.History.Replace("-", "");
                        temp = Convert.ToDecimal(currentModel.History) * -1;
                        currentModel.CurrentValue -= temp;
                    }
                    else
                    {
                        temp = Convert.ToDecimal(currentModel.History);
                        currentModel.CurrentValue -= temp;
                    }
                }
                else if (currentModel.History.Contains("*"))
                {
                    currentModel.History = currentModel.History.Replace(" * ", "");
                    if (currentModel.History.StartsWith("-"))
                    {
                        currentModel.History = currentModel.History.Replace("-", "");
                        temp = Convert.ToDecimal(currentModel.History) * -1;
                        currentModel.CurrentValue *= temp;
                    }
                    else
                    {
                        temp = Convert.ToDecimal(currentModel.History);
                        currentModel.CurrentValue *= temp;
                    }
                }
                else if (currentModel.History.Contains("/"))
                {
                    currentModel.History = currentModel.History.Replace(" / ", "");
                    if (currentModel.Screen == "0" || currentModel.Screen == "-0")
                    {
                        currentModel.Screen = "Undefined";
                        return;
                    }
                    if (currentModel.History.StartsWith("-"))
                    {

                        currentModel.History = currentModel.History.Replace("-", "");
                        temp = Convert.ToDecimal(currentModel.History) * -1;
                        currentModel.CurrentValue /= temp;
                    }
                    else
                    {
                        temp = Convert.ToDecimal(currentModel.History);
                        currentModel.CurrentValue /= temp;
                    }
                }
                else
                {
                    return;
                }
                currentModel.History = Convert.ToString(currentModel.CurrentValue);
                currentModel.History += " + ";
                currentModel.Screen = "";

            }

        }
        private void ClickMinus(object sender, RoutedEventArgs e)
        {
            Boolean sqrtCompleted = false;
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
                return;
            }
            if (currentModel.Screen == "")
            {
                if (currentModel.History.Contains("+"))
                {
                    currentModel.History = currentModel.History.Replace("+", "-");
                }
                else if (currentModel.History.Contains("*"))
                {
                    currentModel.History = currentModel.History.Replace("*", "-");
                }
                else if (currentModel.History.Contains("/"))
                {
                    currentModel.History = currentModel.History.Replace("/", "-");
                }
                return;
            }
            else if (WhipeData == true)
            {
                currentModel.History = currentModel.Screen;
                currentModel.Screen = "";
                WhipeData = false;
            }
            if (currentModel.Screen.Contains("%"))
            {
                CheckCurrentValue();
                currentModel.History = Convert.ToString(currentModel.CurrentValue);
                currentModel.Screen = "";
            }
            if (currentModel.Screen.Contains("√"))
            {
                currentModel.History = currentModel.Screen;
                currentModel.History = currentModel.History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(currentModel.History);
                    if (value < 0)
                    {
                        currentModel.Screen = "Undefined";
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        currentModel.CurrentValue = Convert.ToDecimal(value);
                        currentModel.Screen = "";
                        sqrtCompleted = true;
                    }
                }
                catch
                {
                    currentModel.Screen = currentModel.Screen.Replace("√", "");
                    CheckCurrentValue();
                }
            }
            if (currentModel.Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                currentModel.Screen = Convert.ToString(currentModel.CurrentValue);
            }
            String tempS;
            try
            {
                if (sqrtCompleted == true)
                {
                    sqrtCompleted = false;
                    currentModel.History = Convert.ToString(currentModel.CurrentValue);
                    currentModel.History += " - ";
                    currentModel.Screen = "";
                    return;
                }
                currentModel.History += currentModel.Screen;
                currentModel.CurrentValue = Convert.ToDecimal(currentModel.History);
                currentModel.History += " - ";
                currentModel.Screen = "";
            }
            catch
            {
                tempS = Convert.ToString(currentModel.CurrentValue);
                currentModel.History = currentModel.History.Replace(tempS, "");
                CheckifEmpty(tempS);
                Previous_Operand(tempS);
                currentModel.History = Convert.ToString(currentModel.CurrentValue);
                currentModel.History += " - ";
                currentModel.Screen = "";
            }

        }
        private void ClickMult(object sender, RoutedEventArgs e)
        {
            Boolean sqrtCompleted = false;
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
                return;
            }
            if (currentModel.Screen == "")
            {
                if (currentModel.History.Contains(" - "))
                {
                    currentModel.History = currentModel.History.Replace("-", "*");
                }
                else if (currentModel.History.Contains("+"))
                {
                    currentModel.History = currentModel.History.Replace("+", "*");
                }
                else if (currentModel.History.Contains("/"))
                {
                    currentModel.History = currentModel.History.Replace("/", "*");
                }
                else
                {
                    return;
                }
                return;
            }
            else if (WhipeData == true)
            {
                currentModel.History = currentModel.Screen;
                currentModel.Screen = "";
                WhipeData = false;
            }
            if(currentModel.Screen.Contains("%"))
            {
                CheckCurrentValue();
                currentModel.History = Convert.ToString(currentModel.CurrentValue);
                currentModel.Screen = "";

            }
            if (currentModel.Screen.Contains("√"))
            {
                currentModel.History = currentModel.Screen;
                currentModel.History = currentModel.History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(currentModel.History);
                    if (value < 0)
                    {
                        currentModel.Screen = "Undefined";
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        currentModel.CurrentValue = Convert.ToDecimal(value);
                        currentModel.Screen = "";
                        sqrtCompleted = true;
                    }
                }
                catch
                {
                    currentModel.Screen = currentModel.Screen.Replace("√", "");
                    CheckCurrentValue();
                }
            }
            if (currentModel.Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                currentModel.Screen = Convert.ToString(currentModel.CurrentValue);
            }
            decimal temp;
            String tempS;
            try
            {
                if (sqrtCompleted == true)
                {
                    sqrtCompleted = false;
                    currentModel.History = Convert.ToString(currentModel.CurrentValue);
                    currentModel.History += " * ";
                    currentModel.Screen = "";
                    return;
                }
                currentModel.History += currentModel.Screen;
                currentModel.CurrentValue = Convert.ToDecimal(currentModel.History);
                currentModel.History += " * ";
                currentModel.Screen = "";
            }
            catch
            {
                tempS = Convert.ToString(currentModel.CurrentValue);
                currentModel.History = currentModel.History.Replace(tempS, "");
                CheckifEmpty(tempS);
                Previous_Operand(tempS);
                temp = Convert.ToDecimal(currentModel.History);
                currentModel.History = Convert.ToString(currentModel.CurrentValue);
                currentModel.History += " * ";
                currentModel.Screen = "";
            }

        }
        private void ClickDivide(object sender, RoutedEventArgs e)
        {
            Boolean sqrtCompleted = false;
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
                return;
            }
            if (currentModel.Screen == "")
            {
                if (currentModel.History.Contains(" - "))
                {
                    currentModel.History = currentModel.History.Replace("-", "/");
                }
                else if (currentModel.History.Contains("+"))
                {
                    currentModel.History = currentModel.History.Replace("+", "/");
                }
                else if (currentModel.History.Contains("*"))
                {
                    currentModel.History = currentModel.History.Replace("*", "/");
                }
                else
                {
                    return;
                }
                return;
            }
            else if (WhipeData == true)
            {
                currentModel.History = currentModel.Screen;
                currentModel.Screen = "";
                WhipeData = false;
            }
            if (currentModel.Screen.Contains("%"))
            {
                CheckCurrentValue();
                currentModel.History = Convert.ToString(currentModel.CurrentValue);
                currentModel.Screen = "";
            }
            if (currentModel.Screen.Contains("√"))
            {
                currentModel.History = currentModel.Screen;
                currentModel.History = currentModel.History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(currentModel.History);
                    if (value < 0)
                    {
                        currentModel.Screen = "Undefined";
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        currentModel.CurrentValue = Convert.ToDecimal(value);
                        currentModel.Screen = "";
                        sqrtCompleted = true;
                    }
                }
                catch
                {
                    
                    currentModel.Screen = currentModel.Screen.Replace("√", "");
                    CheckCurrentValue();

                }
            }
            if (currentModel.Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                currentModel.Screen = Convert.ToString(currentModel.CurrentValue);
            }
            decimal temp;
            String tempS;
            try
            {
                if (sqrtCompleted == true)
                {
                    sqrtCompleted = false;
                    currentModel.History = Convert.ToString(currentModel.CurrentValue);
                    currentModel.History += " / ";
                    currentModel.Screen = "";
                    return;
                }
                currentModel.History += currentModel.Screen;
                currentModel.CurrentValue = Convert.ToDecimal(currentModel.History);
                currentModel.History += " / ";
                currentModel.Screen = "";
            }
            catch
            {
                tempS = Convert.ToString(currentModel.CurrentValue);
                currentModel.History = currentModel.History.Replace(tempS, "");
                if (currentModel.History == " + " || currentModel.History == " * " || currentModel.History == " / " || currentModel.History == " - ")
                {
                    currentModel.History += tempS;
                }
                Previous_Operand(tempS);
                temp = Convert.ToDecimal(currentModel.History);
                currentModel.History = Convert.ToString(currentModel.CurrentValue);
                currentModel.History += " / ";
                currentModel.Screen = "";
            }
        }
        private void ClickEquals(object sender, RoutedEventArgs e)
        {
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
                return;
            }
            if (currentModel.Screen.Contains(" / "))
            {
                currentModel.Screen = currentModel.Screen.Replace(" / ", "");
                currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                if(currentModel.CurrentValue == 0)
                {

                }
              
                currentModel.Screen += " / ";
            }
            if (currentModel.Screen.Contains(" / "))
            {
                currentModel.Screen = currentModel.Screen.Replace(" / ", "");
                currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                if (currentModel.CurrentValue == 0)
                {

                }

                currentModel.Screen += " / ";
            }
            if (currentModel.Screen.Contains("√"))
            {
                currentModel.History = currentModel.Screen;
                currentModel.History = currentModel.History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(currentModel.History);
                    if (value < 0)
                    {
                        currentModel.Screen = "Undefined";
                        WhipeData = true;
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        currentModel.CurrentValue = Convert.ToDecimal(value);
                        currentModel.Screen = Convert.ToString(currentModel.CurrentValue);
                        WhipeData = true;
                        return;
                    }
                }
                catch
                {
                    if(currentModel.History.Equals(""))
                    {
                        return;
                    }
                    currentModel.Screen = currentModel.Screen.Replace("√", "");
                    CheckCurrentValue();
                }
            }
            if(currentModel.Screen.Contains("%"))
            {
                //currentModel.History = currentModel.Screen;
                CheckCurrentValue();
                currentModel.Screen = Convert.ToString(currentModel.CurrentValue);
                WhipeData = true;
                return;
            }
            if (currentModel.Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                currentModel.Screen = Convert.ToString(currentModel.CurrentValue);
                WhipeData = true;
                return;
            }
            if(currentModel.History == "")
            {
                WhipeData = true;
                return;
            }
            decimal temp;
            String tempS;
            currentModel.History += currentModel.Screen;
            tempS = Convert.ToString(currentModel.CurrentValue);
            currentModel.History = currentModel.History.Replace(tempS, "");
            CheckifEmpty(tempS);
            Previous_Operand(tempS);
            temp = Convert.ToDecimal(currentModel.History);
            currentModel.History = Convert.ToString(currentModel.CurrentValue);
            currentModel.Screen = currentModel.History;
            PreviousAnswer = currentModel.Screen;
            currentModel.History = "";
            WhipeData = true;
        }
        private void ClickMakeNegative(object sender, RoutedEventArgs e)
        {
            if (currentModel.Screen.StartsWith("-"))
            {
                currentModel.Screen = currentModel.Screen.Remove(0, 1);
            }
            else
            {
                currentModel.Screen = currentModel.Screen.Insert(0, "-");
            }
        }
        private void ClickClearAll(object sender, RoutedEventArgs e)
        {
            currentModel.History = "";
            currentModel.Screen = "0";
        }
        private void ClickClearScreen(object sender, RoutedEventArgs e)
        {
            currentModel.Screen = "0";
        }
        private void ClickBackSpace(object sender, RoutedEventArgs e)
        {
            try
            {
                currentModel.Screen = currentModel.Screen.Remove(currentModel.Screen.Length - 1);
            }
            catch { }

        }
        #endregion

        #region Extended Functionaluty Click Events
        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen.Contains("√"))
            {
                return;
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen = currentModel.Screen.Insert(0, "√");
        }
        private void Pi_Click(object sender, RoutedEventArgs e)
        {
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen == "0")
            {
                currentModel.Screen = "";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "";
                currentModel.History = "";
                WhipeData = false;
            }
            if(currentModel.Screen.Contains("."))
            {
                CheckCurrentValue();
                double PIAdded = Convert.ToDouble(currentModel.CurrentValue) + 3.1415926535897932384626433832;
                currentModel.CurrentValue = Convert.ToDecimal(PIAdded);
                currentModel.Screen = Convert.ToString(currentModel.CurrentValue);

            }
            else
            {

                currentModel.Screen += "3.1415926535897932384626433832";
            }
        }
        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            if (currentModel.Screen == "Undefined")
            {
                currentModel.Screen = "";
                currentModel.History = "";
            }
            if (currentModel.Screen.Contains("%"))
            {
                return;
            }
            if (currentModel.Screen == "0" || currentModel.Screen == "")
            {
                currentModel.Screen = "0";
            }
            else if (currentModel.Screen == "-0")
            {
                currentModel.Screen = "-";
            }
            if (WhipeData == true)
            {
                currentModel.Screen = "0";
                currentModel.History = "";
                WhipeData = false;
            }
            currentModel.Screen += "%";
        }
        private void Square_Click(object sender, RoutedEventArgs e)
        {
            if (currentModel.Screen.Contains("\xB2"))
            {
                return;
            }
            currentModel.Screen += "\xB2";
        }
        #endregion

        #region Helper Methods
        private void CheckifEmpty(String tempS)
        {
            if (currentModel.History == " + " || currentModel.History == " * " || currentModel.History == " / " || currentModel.History == " - ")
            {
                currentModel.History += tempS;
            }
        }
        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch { }
        }
        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            currentModel.CloseIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Close (Small).png";
        }
        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            currentModel.CloseIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Close Gray(small).png";
        }
        private void MinimizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            currentModel.MinimizeIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Minimize Icon.png";
        }
        private void MinimizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            currentModel.MinimizeIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Minimize Icon Gray.png";
        }
        private void CloseButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void MinimizeButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void MenuIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            currentModel.MenuIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\MenuIcon (Light).png";
        }
        private void MenuIcon_MouseLeave(object sender, MouseEventArgs e)
        {
            currentModel.MenuIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\MenuIcon.png";
        }
        private void ViewMode_MouseEnter(object sender, MouseEventArgs e)
        {
            currentModel.ModeColor = Brushes.DarkGray;
        }
        private void Standard_MouseEnter(object sender, MouseEventArgs e)
        {
            currentModel.StandardViewColor = Brushes.DarkGray;
        }
        private void Expanded_MouseEnter(object sender, MouseEventArgs e)
        {
            currentModel.ExpandedViewColor = Brushes.DarkGray;
        }
        private void ViewMode_MouseLeave(object sender, MouseEventArgs e)
        {
            currentModel.ModeColor = Brushes.Black;
        }
        private void Standard_MouseLeave(object sender, MouseEventArgs e)
        {
            currentModel.StandardViewColor = Brushes.Black;
        }
        private void Expanded_MouseLeave(object sender, MouseEventArgs e)
        {
            currentModel.ExpandedViewColor = Brushes.Black;
        }
        private void StandardView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentModel.ExtraFunctionsVisibility == Visibility.Visible)
            {
                currentModel.WindowHeight /= 1.12941475827;
            }
            currentModel.ExtraFunctionsVisibility = Visibility.Collapsed;
            currentModel.MenuVisibility = Visibility.Collapsed;
        }
        private void ExtraFunctionView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentModel.ExtraFunctionsVisibility == Visibility.Collapsed)
            {
                currentModel.WindowHeight *= 1.12941475827;

            }
            currentModel.ExtraFunctionsVisibility = Visibility.Visible;
            currentModel.MenuVisibility = Visibility.Collapsed;
        }
        private void MenuIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentModel.MenuVisibility == Visibility.Collapsed)
            {
                currentModel.MenuVisibility = Visibility.Visible;
            }
            else
            {
                currentModel.MenuVisibility = Visibility.Collapsed;
            }
        }
        private void Previous_Operand(String tempS)
        {
            decimal temp;
            if (currentModel.History.Contains("+"))
            {
                currentModel.History = currentModel.History.Replace(" + ", "");
                if (currentModel.History.StartsWith("-"))
                {
                    currentModel.History = currentModel.History.Replace("-", "");
                    temp = Convert.ToDecimal(currentModel.History) * -1;
                    currentModel.CurrentValue += temp;
                }
                else
                {
                    temp = Convert.ToDecimal(currentModel.History);
                    currentModel.CurrentValue += temp;
                }
            }
            else if (currentModel.History.Contains(" - "))
            {
                currentModel.History = currentModel.History.Replace(" - ", "");
                if (currentModel.History.StartsWith("-"))
                {
                    currentModel.History = currentModel.History.Replace("-", "");
                    temp = Convert.ToDecimal(currentModel.History) * -1;
                    currentModel.CurrentValue -= temp;
                }
                else
                {
                    temp = Convert.ToDecimal(currentModel.History);
                    currentModel.CurrentValue -= temp;
                }
            }
            else if (currentModel.History.Contains("*"))
            {
                currentModel.History = currentModel.History.Replace(" * ", "");
                if (currentModel.History.StartsWith("-"))
                {
                    currentModel.History = currentModel.History.Replace("-", "");
                    temp = Convert.ToDecimal(currentModel.History) * -1;
                    currentModel.CurrentValue *= temp;
                }
                else
                {
                    temp = Convert.ToDecimal(currentModel.History);
                    currentModel.CurrentValue *= temp;
                }
            }
            else if (currentModel.History.Contains("/"))
            {
                currentModel.History = currentModel.History.Replace(" / ", "");
                currentModel.History = currentModel.History.Replace(" / ", "");
                if (currentModel.Screen == "0" || currentModel.Screen == "-0")
                {
                    currentModel.Screen = "Undefined";
                    return;
                }
                if (currentModel.History.StartsWith("-"))
                {
                    currentModel.History = currentModel.History.Replace("-", "");
                    temp = Convert.ToDecimal(currentModel.History) * -1;
                    currentModel.CurrentValue /= temp;
                }
                else
                {
                    temp = Convert.ToDecimal(currentModel.History);
                    currentModel.CurrentValue /= temp;
                }
            }
            else
            {
                currentModel.History = "";
                return;
            }
        }
        private void CheckCurrentValue()
        {
            double sqrtholder;
            if (currentModel.Screen.Contains(" + "))
            {
                currentModel.Screen = currentModel.Screen.Replace(" + ", "");
                sqrtholder = Convert.ToDouble(currentModel.Screen);
                sqrtholder = Math.Sqrt(sqrtholder);
                currentModel.CurrentValue = Convert.ToDecimal(sqrtholder);
                currentModel.Screen = Convert.ToString(sqrtholder);
                currentModel.Screen += " + ";
            }
            else if (currentModel.Screen.Contains(" - "))
            {
                currentModel.Screen = currentModel.Screen.Replace(" - ", "");
                sqrtholder = Convert.ToDouble(currentModel.Screen);
                sqrtholder = Math.Sqrt(sqrtholder);
                currentModel.CurrentValue = Convert.ToDecimal(sqrtholder);
                currentModel.Screen = Convert.ToString(sqrtholder);
                currentModel.Screen += " - ";
            }
            else if (currentModel.Screen.Contains(" * "))
            {
                currentModel.Screen = currentModel.Screen.Replace(" * ", "");
                sqrtholder = Convert.ToDouble(currentModel.Screen);
                sqrtholder = Math.Sqrt(sqrtholder);
                currentModel.CurrentValue = Convert.ToDecimal(sqrtholder);
                currentModel.Screen = Convert.ToString(sqrtholder);
                currentModel.Screen += " * ";
            }
            else if (currentModel.Screen.Contains(" / "))
            {
                currentModel.Screen = currentModel.Screen.Replace(" / ", "");
                sqrtholder = Convert.ToDouble(currentModel.Screen);
                sqrtholder = Math.Sqrt(sqrtholder);
                currentModel.CurrentValue = Convert.ToDecimal(sqrtholder);
                currentModel.Screen = Convert.ToString(sqrtholder);
                currentModel.Screen += " / ";
            }
            else if (currentModel.Screen.Contains("\xB2"))
            {
                currentModel.Screen = currentModel.Screen.Replace("\xB2", "");
                if (currentModel.Screen.StartsWith("-"))
                {
                    currentModel.Screen = currentModel.Screen.Replace("-", "");
                    currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                    currentModel.CurrentValue *= currentModel.CurrentValue;
                    currentModel.Screen.Insert(0, "-");
                }
                else
                {
                    currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                    currentModel.CurrentValue *= currentModel.CurrentValue;
                }
                currentModel.Screen += "\xB2";
            }
            else if (currentModel.Screen.Contains("√"))
            {
                currentModel.Screen = currentModel.Screen.Replace("√", "");
                if (currentModel.Screen.StartsWith("-"))
                {
                    currentModel.Screen = currentModel.Screen.Replace("-", "");
                    currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                    currentModel.CurrentValue *= currentModel.CurrentValue;
                    currentModel.Screen.Insert(0, "-");
                }
                else
                {
                    currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                    double temp = Convert.ToDouble(currentModel.CurrentValue);
                    currentModel.CurrentValue = Convert.ToDecimal(Math.Sqrt(temp));
                }
                currentModel.Screen += "√";
            }

            else
            {
                if(currentModel.Screen.StartsWith("-"))
                {
                    currentModel.Screen = currentModel.Screen.Replace("-", "");
                    if (currentModel.Screen.Contains("%"))
                    {
                        currentModel.Screen = currentModel.Screen.Replace("%", "");
                        currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                        currentModel.CurrentValue = (currentModel.CurrentValue / 100);
                        currentModel.CurrentValue *= -1;
                    }
                    else
                    {
                        currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen) * -1;
                        currentModel.Screen.Insert(0, "-");
                    }
                  
                }
                else
                {
                    if (currentModel.Screen.Contains("%"))
                    {
                        currentModel.Screen = currentModel.Screen.Replace("%", "");
                        currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                        currentModel.CurrentValue = (currentModel.CurrentValue / 100);
                    }
                    else
                    {
                        currentModel.CurrentValue = Convert.ToDecimal(currentModel.Screen);
                    }
                        
                }

            }
        }
        private void RemovePercentSymbol()
        {
            if(currentModel.Screen.Contains("%"))
            {
                currentModel.Screen = currentModel.Screen.Replace("%", "");
                PercentSymbol_Present = true;
            }
        }
        private void AddPercentSymbol()
        {
            if (PercentSymbol_Present == true)
            {
                currentModel.Screen += "%";
                PercentSymbol_Present = false;
            }
        }
        private Boolean ContainsSuperScript()
        {
            decimal temp;
            CheckCurrentValue();
            temp = currentModel.CurrentValue;
             if (currentModel.Screen.Contains("\xB2"))
             {
                if(currentModel.History.StartsWith("-"))
                {
                    currentModel.History.Remove(0);
                }
                currentModel.History = currentModel.History.Replace("\xB2", "");
                currentModel.CurrentValue = temp + Convert.ToDecimal(currentModel.History);
                
                return true;
            }
            return false;
        }
        private void RemoveZeroWhenSqrt()
        {
            try
            {
                String HoldString = currentModel.Screen;
                HoldString = HoldString.Replace("√", "");
                try { HoldString = HoldString.Replace("-", ""); }
                catch { };
                decimal temp = Convert.ToDecimal(HoldString);
                if (temp == 0)
                {
                    currentModel.Screen = currentModel.Screen.Replace("0", "");
                }

            }
            catch { }
        }
        #endregion

        #region Keydown Events
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                if (e.Key == Key.D8)
                {
                    ClickMult(null, null);
                }
                else if (e.Key == Key.OemPlus)
                {
                    ClickPlus(null, null);
                }
                else if (e.Key == Key.OemMinus)
                {
                    ClickMinus(null, null);
                }
            }
            else if (e.Key == Key.OemQuestion)
            {
                ClickDivide(null, null);
            }
            else if (e.Key == Key.OemMinus)
            {
                ClickMinus(null, null);
            }
            else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                Click0(null, null);
            }
            else if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                Click1(null, null);
            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                Click2(null, null);
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                Click3(null, null);
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                Click4(null, null);
            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                Click5(null, null);
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                Click6(null, null);
            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                Click7(null, null);
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                Click8(null, null);
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                Click9(null, null);
            }
            else if (e.Key == Key.Back)
            {
                ClickBackSpace(null, null);
            }
            else if (e.Key == Key.Add)
            {
                ClickPlus(null, null);
            }
            else if (e.Key == Key.Subtract)
            {
                ClickMinus(null, null);
            }
            else if (e.Key == Key.Multiply)
            {
                ClickMult(null, null);
            }
            else if (e.Key == Key.Divide)
            {
                ClickDivide(null, null);
            }
            else if (e.Key == Key.Enter)
            {
                ClickEquals(null, null);
            }
            else if (e.Key == Key.OemPlus)
            {
                ClickEquals(null, null);
            }
            else if (e.Key == Key.OemPeriod || e.Key == Key.Decimal)
            {
                ClickDecimal(null, null);
            }
        }
        #endregion
    }
    #endregion

}
