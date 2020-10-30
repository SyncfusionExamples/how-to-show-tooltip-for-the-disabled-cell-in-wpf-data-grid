#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;

namespace MasterDetailsViewDemo
{
    public class Employees : INotifyPropertyChanged
    {
        private System.Nullable<int> _OrderID;

        public System.Nullable<int> OrderID
        {
            get { return this._OrderID; }
            set
            {
                this._OrderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        private int _EmployeeID;

        public int EmployeeID
        {
            get { return this._EmployeeID; }
            set
            {
                this._EmployeeID = value;
                RaisePropertyChanged("EmployeeID");
            }
        }

        private string _Name;

        public string Name
        {
            get { return this._Name; }
            set
            {
                this._Name = value;
                RaisePropertyChanged("Name");
            }
        }

        public Employees(int or, int emp, string nam)
        {
            this.EmployeeID = emp;
            this.OrderID = or;
            this.Name = nam;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
