using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;

namespace EPCONCalculator
{
    #region INotifyPropertyChanged & variables
    // move over to new class
    public class CurrentModel : INotifyPropertyChanged
    {
        private Double windowHeight = 350;
        private String history = "";
        private String screen = "0";
        private String closeIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Close Gray(small).png";
        private String minimizeIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\Minimize Icon Gray.png";
        private String menuIconSource = @"C:\Users\Kyle\Desktop\EPCON Work\EPCONCalculator\EPCONCalculator\Resources\MenuIcon.png";
        private Decimal currentValue = 0;
        private Brush modeColor = Brushes.Black;
        private Brush standardViewColor = Brushes.Black;
        private Brush expandedViewColor = Brushes.Black;
        private Visibility menuVisibility = Visibility.Collapsed;
        private Visibility extraFunctionsVisibility = Visibility.Collapsed;

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
        #endregion

    }
}