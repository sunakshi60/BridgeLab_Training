using System;

namespace PracticeProblems
{
    class Order
    {
        private int OrderId;
        private string OrderDate;

        public Order(int orderId,string orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual void GetOrderStatus()
        {
            Console.WriteLine("Order Placed");
            Console.WriteLine($"Order ID : {OrderId}");
            Console.WriteLine($"Order Date : {OrderDate}");
        }
    }

    class ShippedOrder : Order
    {
        private string TrackingNumber;

        public ShippedOrder(int orderId, string orderDate, string trackingNumber) : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override void GetOrderStatus()
        {
            base.GetOrderStatus();
            Console.WriteLine("Status : Shipped");
            Console.WriteLine($"Tracking Number : {TrackingNumber}");
        }
    }

    class DeliveredOrder : ShippedOrder
    {
        private string DeliveryDate;

        public DeliveredOrder(int orderId,string orderDate,string trackingNumber,string deliveryDate) : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override void GetOrderStatus()
        {
            base.GetOrderStatus();
            Console.WriteLine("Status : Delivered");
            Console.WriteLine($"Delivery Date : {DeliveryDate}");
        }
    }
}