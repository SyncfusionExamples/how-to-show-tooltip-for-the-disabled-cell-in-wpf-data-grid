#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows;
using System.Windows.Input;
using Syncfusion.UI.Xaml.Grid;

namespace MasterDetailsViewDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Loaded += MainWindow_Loaded;
            //KeyDown += MainWindow_KeyDown;
            // set the customized GridSelectionControllserExt to SfDataGrid.SelectionController
            this.dataGrid.SelectionController = new GridSelectionControllerExt(dataGrid);
            //dataGrid.Loaded += dataGrid_Loaded;
            //dataGrid.PreviewKeyUp += dataGrid_PreviewKeyUp;
            //dataGrid.PreviewKeyDown += dataGrid_PreviewKeyDown;
           

        }

        void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.PreviewKeyDown += dataGrid_PreviewKeyDown;
            dataGrid.Focusable = true;
            this.Focus();
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.PreviewKeyDown += GameScreen_PreviewKeyDown;
            this.Focusable = true;
            this.Focus();

        }

        private void GameScreen_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //Do work
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        void dataGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        void dataGrid_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        private void dataGrid_FilterChanged(object sender, GridFilterEventArgs e)
        {
            try
            {

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }

    public class GridSelectionControllerExt : GridSelectionController
    {
        //Inherits the GridSelectionController Class
        private SfDataGrid grid;

        public GridSelectionControllerExt(SfDataGrid datagrid)
            : base(datagrid)
        {
            grid = datagrid;
        }

        //overriding the ProcessKeyDown Event from GridSelectionController base class
        protected override void ProcessKeyDown(KeyEventArgs args)
        {
            var currentKey = args.Key;
            var arguments = new KeyEventArgs(args.KeyboardDevice, args.InputSource, args.Timestamp, Key.Down)
            {
                RoutedEvent = args.RoutedEvent
            };
            if (currentKey == Key.Down)
            {
                base.ProcessKeyDown(arguments);
                //assinging the state of Tab key Event handling to Enter key
                args.Handled = false;

                return;
            }
            base.ProcessKeyDown(args);
        }
    }
}
