using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7
{
        public class InternationalShipment : Shipment
        {
            private string _destinationCountry;
            private decimal _customsFee;

            public string DestinationCountry
            {
                get
                {
                    return _destinationCountry;
                }

                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        _destinationCountry = value;
                    }
                }
            }

            public decimal CustomsFee
            {
                get
                {
                    return _customsFee;
                }

                set
                {
                    if (value >= 0)
                    {
                        _customsFee = value;
                    }
                }
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee
                        + (Weight * 5)
                        + CustomsFee;
                }
            }

            public InternationalShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination,
                string destinationCountry,
                decimal customsFee)
                : base(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    destination)
            {
                DestinationCountry = destinationCountry;
                CustomsFee = customsFee;
            }
        }
}
