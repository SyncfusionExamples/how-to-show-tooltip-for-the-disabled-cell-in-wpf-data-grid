#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace MasterDetailsViewDemo
{
    public class ViewModel
    {
        public ViewModel()
        {
            OrderInfoRepository order = new OrderInfoRepository();
            OrdersDetails = order.GetOrdersDetails(100);
        }

        public List<OrderInfo> _ordersDetails;

        public List<OrderInfo> OrdersDetails
        {
            get { return _ordersDetails; }
            set { _ordersDetails = value; }
        }
    }
}
