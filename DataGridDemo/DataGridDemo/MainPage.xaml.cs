using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.SfDataGrid.XForms;
using System.Globalization;
using Syncfusion.Data;
using System.Diagnostics;
using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;

namespace DataGridDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class CustomStyle : DataGridStyle
    {
        public override GridLinesVisibility GetGridLinesVisibility()
        {
            return GridLinesVisibility.None;
        }
    }
}