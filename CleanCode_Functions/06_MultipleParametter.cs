using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    internal class Functions_03_MultipleParametter
    {
        public static void SendEmail(string from, string to, string subject, string body, bool isHtml)
        {
            // some code to send the email
        }
        #region Argument Objects
        public void SomeFunction()
        {
            Customer customer = new Customer();
            Product product = new Product();
            double price = CalculatePrice(customer, product, 10, false, DeliveryMethod.Prime);

            OrderRequest orderRequest = new OrderRequest(customer, product, 10, false, DeliveryMethod.Prime);
            price = CalculatePrice(orderRequest);

        }

        #region set 1, Multiple Parameters
        public double CalculatePrice(
            Customer customer,
            Product product,
            int quantity,
            bool isGift,
            DeliveryMethod deliveryMethod)
        {
            double discountRate = getDiscountRate(customer, product, quantity, isGift, deliveryMethod);
            double deliveryCost = getDeliveryCost(customer, product, quantity, isGift, deliveryMethod);
            return (quantity * product.Price * discountRate) + deliveryCost;
        }

        private double getDiscountRate(
            Customer customer,
            Product product,
            int quantity,
            bool isGift,
            DeliveryMethod deloveryMethod)
        {
            // Calculate discount
            return 1;
        }

        private double getDeliveryCost(
            Customer customer,
            Product product,
            int quantity,
            bool isGift,
            DeliveryMethod deloveryMethod)
        {
            return 0;
        }
        #endregion

        #region set 2, request object
        public double CalculatePrice(
            OrderRequest request)
        {

            //double discountRate = getDiscountRate(customer, product, quantity, isGift, deloveryMethod);
            //double deliveryCost = getDeliveryCost(customer, product, quantity, isGift, deloveryMethod);
            //return (quantity * product.Price * discountRate) + deliveryCost;

            double discountRate = getDiscountRate(request);
            double deliveryCost = getDeliveryCost(request);
            return (request.CalculateTotalPrice() * discountRate) + deliveryCost;
        }

        private double getDiscountRate(
            OrderRequest request)
        {
            // Calculate discount
            return 1;
        }

        private double getDeliveryCost(
            OrderRequest request)
        {
            return 0;
        }
        #endregion

        #endregion
    }
    public class EmailMessage
    {
        string From { get; set; }
        string To { get; set; }
        string Subject { get; set; }
        string Body { get; set; }
        bool IsHtml { get; set; }
        public EmailMessage(string from, string to, string subject, string body, bool isHtml)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
            IsHtml = isHtml;
        }
        public static void SendEmail(EmailMessage message)
        {
            // some code to send the email
        }
    }
    internal class OrderRequest
    {
        private Customer customer;
        private Product product;
        private int quantity;
        private bool isGift;
        private DeliveryMethod prime;

        public OrderRequest(
            Customer customer,
            Product product,
            int quantity,
            bool isGift,
            DeliveryMethod prime)
        {
            this.customer = customer;
            this.product = product;
            this.quantity = quantity;
            this.isGift = isGift;
            this.prime = prime;
        }

        internal double CalculateTotalPrice()
        {
            return this.quantity * this.product.Price;
        }
    }

    enum DeliveryMethod
    {
        Prime
    }

}