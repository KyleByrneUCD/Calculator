using System;
using System.Drawing;
using System.Windows;
using System.Windows.Input;

namespace EPCONCalculator
{
    public class CalculatorViewModel : CurrentModel
    {
        private Boolean PercentSymbol_Present = false;
        private Boolean WhipeData = false;
        private String PreviousAnswer = "0";

        public CalculatorViewModel()
        {

        }
        #region Number ButtonClick Events
        public void Click1()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "1";
            AddPercentSymbol();

        }
        public void Click2()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "2";
            AddPercentSymbol();
        }
        public void Click3()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "3";
            AddPercentSymbol();
        }
        public void Click4()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "4";
            AddPercentSymbol();
        }
        public void Click5()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "5";
            AddPercentSymbol();
        }
        public void Click6()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "6";
            AddPercentSymbol();
        }
        public void Click7()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "7";
            AddPercentSymbol();
        }
        public void Click8()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "8";
            AddPercentSymbol();
        }
        public void Click9()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "9";
            AddPercentSymbol();
        }
        public void Click0()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen += "0";
            AddPercentSymbol();
        }
        public void ClickDecimal()
        {
            RemovePercentSymbol();
            RemoveZeroWhenSqrt();
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen.Contains("."))
            {
                return;
            }
            if (Screen == "0" || Screen == "")
            {
                Screen = "0";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "0";
                History = "";
                WhipeData = false;
            }
            Screen += ".";
            AddPercentSymbol();
        }
        #endregion
        
        #region Operator ButtonClick Events
        public void ClickPlus()
        {
            decimal temp;
            Boolean sqrtCompleted = false;
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
                return;
            }
            if (Screen == "0" || Screen == "-0")
            {
                if (History != "")
                {
                    Screen = "Undefined";
                }
                return;
            }
            if (Screen == "")
            {
                if (History.Contains("+"))
                {
                    History = History.Replace("+", "-");
                }
                else if (History.Contains("*"))
                {
                    History = History.Replace("*", "-");
                }
                else if (History.Contains("/"))
                {
                    History = History.Replace("/", "-");
                }
                return;
            }
            else if (WhipeData == true)
            {
                History = Screen;
                Screen = "";
                WhipeData = false;
            }
            if (Screen.Contains("%"))
            {
                CheckCurrentValue();
                History = Convert.ToString(CurrentValue);
                Screen = "";
            }
            if (Screen.Contains("√"))
            {
                History = Screen;
                History = History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(History);
                    if (value < 0)
                    {
                        Screen = "Undefined";
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        CurrentValue = Convert.ToDecimal(value);
                        Screen = "";
                        sqrtCompleted = true;
                    }
                }
                catch
                {
                    Screen = Screen.Replace("√", "");
                    CheckCurrentValue();
                }

            }
            if (Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                Screen = Convert.ToString(CurrentValue);
            }
            String tempS;
            try
            {
                if (sqrtCompleted == true)
                {
                    sqrtCompleted = false;
                    History = Convert.ToString(CurrentValue);
                    History += " + ";
                    Screen = "";
                    return;
                }
                History += Screen;
                CurrentValue = Convert.ToDecimal(History);
                History += " + ";
                Screen = "";
            }
            catch
            {
                tempS = Convert.ToString(CurrentValue);
                History = History.Replace(tempS, "");
                CheckifEmpty(tempS);
                if (History.Contains("+"))
                {
                    History = History.Replace(" + ", "");
                    if (ContainsSuperScript())
                    {

                    }
                    else if (History.StartsWith("-"))
                    {
                        History = History.Replace("-", "");
                        temp = Convert.ToDecimal(History) * -1;
                        CurrentValue += temp;
                    }
                    else
                    {
                        temp = Convert.ToDecimal(History);
                        CurrentValue += temp;
                    }
                }
                else if (History.Contains(" - "))
                {
                    History = History.Replace(" - ", "");
                    if (History.StartsWith("-"))
                    {
                        History = History.Replace("-", "");
                        temp = Convert.ToDecimal(History) * -1;
                        CurrentValue -= temp;
                    }
                    else
                    {
                        temp = Convert.ToDecimal(History);
                        CurrentValue -= temp;
                    }
                }
                else if (History.Contains("*"))
                {
                    History = History.Replace(" * ", "");
                    if (History.StartsWith("-"))
                    {
                        History = History.Replace("-", "");
                        temp = Convert.ToDecimal(History) * -1;
                        CurrentValue *= temp;
                    }
                    else
                    {
                        temp = Convert.ToDecimal(History);
                        CurrentValue *= temp;
                    }
                }
                else if (History.Contains("/"))
                {
                    History = History.Replace(" / ", "");
                    if (Screen == "0" || Screen == "-0")
                    {
                        Screen = "Undefined";
                        return;
                    }
                    if (History.StartsWith("-"))
                    {

                        History = History.Replace("-", "");
                        temp = Convert.ToDecimal(History) * -1;
                        CurrentValue /= temp;
                    }
                    else
                    {
                        temp = Convert.ToDecimal(History);
                        CurrentValue /= temp;
                    }
                }
                else
                {
                    return;
                }
                History = Convert.ToString(CurrentValue);
                History += " + ";
                Screen = "";

            }

        }
        public void ClickMinus()
        {
            Boolean sqrtCompleted = false;
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
                return;
            }
            if (Screen == "")
            {
                if (History.Contains("+"))
                {
                    History = History.Replace("+", "-");
                }
                else if (History.Contains("*"))
                {
                    History = History.Replace("*", "-");
                }
                else if (History.Contains("/"))
                {
                    History = History.Replace("/", "-");
                }
                return;
            }
            else if (WhipeData == true)
            {
                History = Screen;
                Screen = "";
                WhipeData = false;
            }
            if (Screen.Contains("%"))
            {
                CheckCurrentValue();
                History = Convert.ToString(CurrentValue);
                Screen = "";
            }
            if (Screen.Contains("√"))
            {
                History = Screen;
                History = History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(History);
                    if (value < 0)
                    {
                        Screen = "Undefined";
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        CurrentValue = Convert.ToDecimal(value);
                        Screen = "";
                        sqrtCompleted = true;
                    }
                }
                catch
                {
                    Screen = Screen.Replace("√", "");
                    CheckCurrentValue();
                }
            }
            if (Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                Screen = Convert.ToString(CurrentValue);
            }
            String tempS;
            try
            {
                if (sqrtCompleted == true)
                {
                    sqrtCompleted = false;
                    History = Convert.ToString(CurrentValue);
                    History += " - ";
                    Screen = "";
                    return;
                }
                History += Screen;
                CurrentValue = Convert.ToDecimal(History);
                History += " - ";
                Screen = "";
            }
            catch
            {
                tempS = Convert.ToString(CurrentValue);
                History = History.Replace(tempS, "");
                CheckifEmpty(tempS);
                Previous_Operand(tempS);
                History = Convert.ToString(CurrentValue);
                History += " - ";
                Screen = "";
            }

        }
        public void ClickMult()
        {
            Boolean sqrtCompleted = false;
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
                return;
            }
            if (Screen == "")
            {
                if (History.Contains(" - "))
                {
                    History = History.Replace("-", "*");
                }
                else if (History.Contains("+"))
                {
                    History = History.Replace("+", "*");
                }
                else if (History.Contains("/"))
                {
                    History = History.Replace("/", "*");
                }
                else
                {
                    return;
                }
                return;
            }
            else if (WhipeData == true)
            {
                History = Screen;
                Screen = "";
                WhipeData = false;
            }
            if (Screen.Contains("%"))
            {
                CheckCurrentValue();
                History = Convert.ToString(CurrentValue);
                Screen = "";

            }
            if (Screen.Contains("√"))
            {
                History = Screen;
                History = History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(History);
                    if (value < 0)
                    {
                        Screen = "Undefined";
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        CurrentValue = Convert.ToDecimal(value);
                        Screen = "";
                        sqrtCompleted = true;
                    }
                }
                catch
                {
                    Screen = Screen.Replace("√", "");
                    CheckCurrentValue();
                }
            }
            if (Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                Screen = Convert.ToString(CurrentValue);
            }
            decimal temp;
            String tempS;
            try
            {
                if (sqrtCompleted == true)
                {
                    sqrtCompleted = false;
                    History = Convert.ToString(CurrentValue);
                    History += " * ";
                    Screen = "";
                    return;
                }
                History += Screen;
                CurrentValue = Convert.ToDecimal(History);
                History += " * ";
                Screen = "";
            }
            catch
            {
                tempS = Convert.ToString(CurrentValue);
                History = History.Replace(tempS, "");
                CheckifEmpty(tempS);
                Previous_Operand(tempS);
                temp = Convert.ToDecimal(History);
                History = Convert.ToString(CurrentValue);
                History += " * ";
                Screen = "";
            }

        }
        public void ClickDivide()
        {
            Boolean sqrtCompleted = false;
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
                return;
            }
            if (Screen == "")
            {
                if (History.Contains(" - "))
                {
                    History = History.Replace("-", "/");
                }
                else if (History.Contains("+"))
                {
                    History = History.Replace("+", "/");
                }
                else if (History.Contains("*"))
                {
                    History = History.Replace("*", "/");
                }
                else
                {
                    return;
                }
                return;
            }
            else if (WhipeData == true)
            {
                History = Screen;
                Screen = "";
                WhipeData = false;
            }
            if (Screen.Contains("%"))
            {
                CheckCurrentValue();
                History = Convert.ToString(CurrentValue);
                Screen = "";
            }
            if (Screen.Contains("√"))
            {
                History = Screen;
                History = History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(History);
                    if (value < 0)
                    {
                        Screen = "Undefined";
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        CurrentValue = Convert.ToDecimal(value);
                        Screen = "";
                        sqrtCompleted = true;
                    }
                }
                catch
                {

                    Screen = Screen.Replace("√", "");
                    CheckCurrentValue();

                }
            }
            if (Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                Screen = Convert.ToString(CurrentValue);
            }
            decimal temp;
            String tempS;
            try
            {
                if (sqrtCompleted == true)
                {
                    sqrtCompleted = false;
                    History = Convert.ToString(CurrentValue);
                    History += " / ";
                    Screen = "";
                    return;
                }
                History += Screen;
                CurrentValue = Convert.ToDecimal(History);
                History += " / ";
                Screen = "";
            }
            catch
            {
                tempS = Convert.ToString(CurrentValue);
                History = History.Replace(tempS, "");
                if (History == " + " || History == " * " || History == " / " || History == " - ")
                {
                    History += tempS;
                }
                Previous_Operand(tempS);
                temp = Convert.ToDecimal(History);
                History = Convert.ToString(CurrentValue);
                History += " / ";
                Screen = "";
            }
        }
        public void ClickEquals()
        {
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
                return;
            }
            if (Screen.Contains(" / "))
            {
                Screen = Screen.Replace(" / ", "");
                CurrentValue = Convert.ToDecimal(Screen);
                if (CurrentValue == 0)
                {

                }

                Screen += " / ";
            }
            if (Screen.Contains(" / "))
            {
                Screen = Screen.Replace(" / ", "");
                CurrentValue = Convert.ToDecimal(Screen);
                if (CurrentValue == 0)
                {

                }

                Screen += " / ";
            }
            if (Screen.Contains("√"))
            {
                History = Screen;
                History = History.Replace("√", "");
                try
                {
                    double value = Convert.ToDouble(History);
                    if (value < 0)
                    {
                        Screen = "Undefined";
                        WhipeData = true;
                        return;
                    }
                    else
                    {

                        value = Math.Sqrt(value);
                        CurrentValue = Convert.ToDecimal(value);
                        Screen = Convert.ToString(CurrentValue);
                        WhipeData = true;
                        return;
                    }
                }
                catch
                {
                    if (History.Equals(""))
                    {
                        return;
                    }
                    Screen = Screen.Replace("√", "");
                    CheckCurrentValue();
                }
            }
            if (Screen.Contains("%"))
            {
                //History = Screen;
                CheckCurrentValue();
                Screen = Convert.ToString(CurrentValue);
                WhipeData = true;
                return;
            }
            if (Screen.Contains("\xB2"))
            {
                CheckCurrentValue();
                Screen = Convert.ToString(CurrentValue);
                WhipeData = true;
                return;
            }
            if (History == "")
            {
                WhipeData = true;
                return;
            }
            decimal temp;
            String tempS;
            History += Screen;
            tempS = Convert.ToString(CurrentValue);
            History = History.Replace(tempS, "");
            CheckifEmpty(tempS);
            Previous_Operand(tempS);
            temp = Convert.ToDecimal(History);
            History = Convert.ToString(CurrentValue);
            Screen = History;
            PreviousAnswer = Screen;
            History = "";
            WhipeData = true;
        }
        public void ClickMakeNegative()
        {
            if (Screen.StartsWith("-"))
            {
                Screen = Screen.Remove(0, 1);
            }
            else
            {
                Screen = Screen.Insert(0, "-");
            }
        }
        public void ClickClearAll()
        {
            History = "";
            Screen = "0";
        }
        public void ClickClearScreen()
        {
            Screen = "0";
        }
        public void ClickBackSpace()
        {
            try
            {
                Screen = Screen.Remove(Screen.Length - 1);
            }
            catch { }

        }
        #endregion

        #region Extended Functionality

        public void Square_Click()
        {
            if (Screen.Contains("\xB2"))
            {
                return;
            }
            Screen += "\xB2";
        }
        public void Pi_Click()
        {
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen == "0")
            {
                Screen = "";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            if (Screen.Contains("."))
            {
                CheckCurrentValue();
                double PIAdded = Convert.ToDouble(CurrentValue) + 3.1415926535897932384626433832;
                CurrentValue = Convert.ToDecimal(PIAdded);
                Screen = Convert.ToString(CurrentValue);

            }
            else
            {

                Screen += "3.1415926535897932384626433832";
            }
        }
        public void Percent_Click()
        {
            if (Screen == "Undefined")
            {
                Screen = "";
                History = "";
            }
            if (Screen.Contains("%"))
            {
                return;
            }
            if (Screen == "0" || Screen == "")
            {
                Screen = "0";
            }
            else if (Screen == "-0")
            {
                Screen = "-";
            }
            if (WhipeData == true)
            {
                Screen = "0";
                History = "";
                WhipeData = false;
            }
            Screen += "%";
        }
        public void Sqrt_Click()
        {
            if (Screen == "Undefined")
            {

                Screen = "";
                History = "";
            }
            if (Screen.Contains("√"))
            {
                return;
            }
            if (WhipeData == true)
            {
                Screen = "";
                History = "";
                WhipeData = false;
            }
            Screen = Screen.Insert(0, "√");
        }
        #endregion

        #region Helper Methods
        public void CheckifEmpty(String tempS)
        {
            if (History == " + " || History == " * " || History == " / " || History == " - ")
            {
                History += tempS;
            }
        }
        //public void MoveWindow()
        //{
        //    try
        //    {
        //        DragMove();
        //    }
        //    catch { }
        //}
        public void CloseButton_MouseEnter()
        {
            CloseIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Close (Small).png";
        }
        public void CloseButton_MouseLeave()
        {
            CloseIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Close Gray(small).png";
        }
        public void MinimizeButton_MouseEnter()
        {
            MinimizeIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Minimize Icon.png";
        }
        public void MinimizeButton_MouseLeave()
        {
            MinimizeIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Minimize Icon Gray.png";
        }
        public void CloseButton_MouseLeftButtonUp()
        {
            Application.Current.MainWindow.Close();
        }
        public void MinimizeButton_MouseLeftButtonUp()
        {
           Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        public void MenuIcon_MouseEnter()
        {
            MenuIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\MenuIcon (Light).png";
        }
        public void MenuIcon_MouseLeave()
        {
            MenuIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\MenuIcon.png";
        }
        public void ViewMode_MouseEnter()
        {
            ModeColor = Brushes.DarkGray;
        }
        public void Standard_MouseEnter()
        {
            StandardViewColor = Brushes.DarkGray;
        }
        public void Expanded_MouseEnter()
        {
            ExpandedViewColor = Brushes.DarkGray;
        }
        public void ViewMode_MouseLeave()
        {
            ModeColor = Brushes.Black;
        }
        public void Standard_MouseLeave()
        {
            StandardViewColor = Brushes.Black;
        }
        public void Expanded_MouseLeave()
        {
            ExpandedViewColor = Brushes.Black;
        }
        public void StandardView_MouseLeftButtonDown()
        {
            if (ExtraFunctionsVisibility == Visibility.Visible)
            {
                WindowHeight /= 1.12941475827;
            }
            ExtraFunctionsVisibility = Visibility.Collapsed;
            MenuVisibility = Visibility.Collapsed;
        }
        public void ExtraFunctionView_MouseLeftButtonDown()
        {
            if (ExtraFunctionsVisibility == Visibility.Collapsed)
            {
                WindowHeight *= 1.12941475827;

            }
            ExtraFunctionsVisibility = Visibility.Visible;
            MenuVisibility = Visibility.Collapsed;
        }
        public void MenuIcon_MouseLeftButtonDown()
        {
            if (MenuVisibility == Visibility.Collapsed)
            {
                MenuVisibility = Visibility.Visible;
            }
            else
            {
                MenuVisibility = Visibility.Collapsed;
            }
        }
        public void Previous_Operand(String tempS)
        {
            decimal temp;
            if (History.Contains("+"))
            {
                History = History.Replace(" + ", "");
                if (History.StartsWith("-"))
                {
                    History = History.Replace("-", "");
                    temp = Convert.ToDecimal(History) * -1;
                    CurrentValue += temp;
                }
                else
                {
                    temp = Convert.ToDecimal(History);
                    CurrentValue += temp;
                }
            }
            else if (History.Contains(" - "))
            {
                History = History.Replace(" - ", "");
                if (History.StartsWith("-"))
                {
                    History = History.Replace("-", "");
                    temp = Convert.ToDecimal(History) * -1;
                    CurrentValue -= temp;
                }
                else
                {
                    temp = Convert.ToDecimal(History);
                    CurrentValue -= temp;
                }
            }
            else if (History.Contains("*"))
            {
                History = History.Replace(" * ", "");
                if (History.StartsWith("-"))
                {
                    History = History.Replace("-", "");
                    temp = Convert.ToDecimal(History) * -1;
                    CurrentValue *= temp;
                }
                else
                {
                    temp = Convert.ToDecimal(History);
                    CurrentValue *= temp;
                }
            }
            else if (History.Contains("/"))
            {
                History = History.Replace(" / ", "");
                History = History.Replace(" / ", "");
                if (Screen == "0" || Screen == "-0")
                {
                    Screen = "Undefined";
                    return;
                }
                if (History.StartsWith("-"))
                {
                    History = History.Replace("-", "");
                    temp = Convert.ToDecimal(History) * -1;
                    CurrentValue /= temp;
                }
                else
                {
                    temp = Convert.ToDecimal(History);
                    CurrentValue /= temp;
                }
            }
            else
            {
                History = "";
                return;
            }
        }
        public void CheckCurrentValue()
        {
            double sqrtholder;
            if (Screen.Contains(" + "))
            {
                Screen = Screen.Replace(" + ", "");
                sqrtholder = Convert.ToDouble(Screen);
                sqrtholder = Math.Sqrt(sqrtholder);
                CurrentValue = Convert.ToDecimal(sqrtholder);
                Screen = Convert.ToString(sqrtholder);
                Screen += " + ";
            }
            else if (Screen.Contains(" - "))
            {
                Screen = Screen.Replace(" - ", "");
                sqrtholder = Convert.ToDouble(Screen);
                sqrtholder = Math.Sqrt(sqrtholder);
                CurrentValue = Convert.ToDecimal(sqrtholder);
                Screen = Convert.ToString(sqrtholder);
                Screen += " - ";
            }
            else if (Screen.Contains(" * "))
            {
                Screen = Screen.Replace(" * ", "");
                sqrtholder = Convert.ToDouble(Screen);
                sqrtholder = Math.Sqrt(sqrtholder);
                CurrentValue = Convert.ToDecimal(sqrtholder);
                Screen = Convert.ToString(sqrtholder);
                Screen += " * ";
            }
            else if (Screen.Contains(" / "))
            {
                Screen = Screen.Replace(" / ", "");
                sqrtholder = Convert.ToDouble(Screen);
                sqrtholder = Math.Sqrt(sqrtholder);
                CurrentValue = Convert.ToDecimal(sqrtholder);
                Screen = Convert.ToString(sqrtholder);
                Screen += " / ";
            }
            else if (Screen.Contains("\xB2"))
            {
                Screen = Screen.Replace("\xB2", "");
                if (Screen.StartsWith("-"))
                {
                    Screen = Screen.Replace("-", "");
                    CurrentValue = Convert.ToDecimal(Screen);
                    CurrentValue *= CurrentValue;
                    Screen.Insert(0, "-");
                }
                else
                {
                    CurrentValue = Convert.ToDecimal(Screen);
                    CurrentValue *= CurrentValue;
                }
                Screen += "\xB2";
            }
            else if (Screen.Contains("√"))
            {
                Screen = Screen.Replace("√", "");
                if (Screen.StartsWith("-"))
                {
                    Screen = Screen.Replace("-", "");
                    CurrentValue = Convert.ToDecimal(Screen);
                    CurrentValue *= CurrentValue;
                    Screen.Insert(0, "-");
                }
                else
                {
                    CurrentValue = Convert.ToDecimal(Screen);
                    double temp = Convert.ToDouble(CurrentValue);
                    CurrentValue = Convert.ToDecimal(Math.Sqrt(temp));
                }
                Screen += "√";
            }

            else
            {
                if (Screen.StartsWith("-"))
                {
                    Screen = Screen.Replace("-", "");
                    if (Screen.Contains("%"))
                    {
                        Screen = Screen.Replace("%", "");
                        CurrentValue = Convert.ToDecimal(Screen);
                        CurrentValue = (CurrentValue / 100);
                        CurrentValue *= -1;
                    }
                    else
                    {
                        CurrentValue = Convert.ToDecimal(Screen) * -1;
                        Screen.Insert(0, "-");
                    }

                }
                else
                {
                    if (Screen.Contains("%"))
                    {
                        Screen = Screen.Replace("%", "");
                        CurrentValue = Convert.ToDecimal(Screen);
                        CurrentValue = (CurrentValue / 100);
                    }
                    else
                    {
                        CurrentValue = Convert.ToDecimal(Screen);
                    }

                }

            }
        }
        public void RemovePercentSymbol()
        {
            if (Screen.Contains("%"))
            {
                Screen = Screen.Replace("%", "");
                PercentSymbol_Present = true;
            }
        }
        public void AddPercentSymbol()
        {
            if (PercentSymbol_Present == true)
            {
                Screen += "%";
                PercentSymbol_Present = false;
            }
        }
        public Boolean ContainsSuperScript()
        {
            decimal temp;
            CheckCurrentValue();
            temp = CurrentValue;
            if (Screen.Contains("\xB2"))
            {
                if (History.StartsWith("-"))
                {
                    History.Remove(0);
                }
                History = History.Replace("\xB2", "");
                CurrentValue = temp + Convert.ToDecimal(History);

                return true;
            }
            return false;
        }
        public void RemoveZeroWhenSqrt()
        {
            try
            {
                String HoldString = Screen;
                HoldString = HoldString.Replace("√", "");
                try { HoldString = HoldString.Replace("-", ""); }
                catch { };
                decimal temp = Convert.ToDecimal(HoldString);
                if (temp == 0)
                {
                    Screen = Screen.Replace("0", "");
                }

            }
            catch { }
        }
        #endregion

        #region Keydown Events
        public void Window_KeyUp(KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                if (e.Key == Key.D8)
                {
                    ClickMult();
                }
                else if (e.Key == Key.OemPlus)
                {
                    ClickPlus();
                }
                else if (e.Key == Key.OemMinus)
                {
                    ClickMinus();
                }
            }
            else if (e.Key == Key.OemQuestion)
            {
                ClickDivide();
            }
            else if (e.Key == Key.OemMinus)
            {
                ClickMinus();
            }
            else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                Click0();
            }
            else if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                Click1();
            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                Click2();
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                Click3();
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                Click4();
            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                Click5();
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                Click6();
            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                Click7();
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                Click8();
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                Click9();
            }
            else if (e.Key == Key.Back)
            {
                ClickBackSpace();
            }
            else if (e.Key == Key.Add)
            {
                ClickPlus();
            }
            else if (e.Key == Key.Subtract)
            {
                ClickMinus();
            }
            else if (e.Key == Key.Multiply)
            {
                ClickMult();
            }
            else if (e.Key == Key.Divide)
            {
                ClickDivide();
            }
            else if (e.Key == Key.Enter)
            {
                ClickEquals();
            }
            else if (e.Key == Key.OemPlus)
            {
                ClickEquals();
            }
            else if (e.Key == Key.OemPeriod || e.Key == Key.Decimal)
            {
                ClickDecimal();
            }
        }
        #endregion
    }
}
