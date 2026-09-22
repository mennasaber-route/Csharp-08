using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7
{
    public class Shipment
    {
        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;

        public string TrackingCode
        {
            get
            {
                return _trackingCode;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public decimal Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return _deliveryFee;
            }

            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination
        {
            get;
            set;
        }

        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            _trackingCode = "Unknown";
            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;

            Destination =
                new DeliveryAddress("Unknown", "Unknown", 0);

            TrackingCode = trackingCode;
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            _trackingCode = "Unknown";
            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;

            Destination = destination;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine(
                $"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine(
                $"Estimated Cost: {EstimatedCost}");
        }
    }


}
