using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7
{
        public class ExpressShipment : Shipment
        {
            private decimal _extraFee;

            public decimal ExtraFee
            {
                get
                {
                    return _extraFee;
                }

                set
                {
                    if (value >= 0)
                    {
                        _extraFee = value;
                    }
                }
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5) + ExtraFee;
                }
            }

            public ExpressShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination,
                decimal extraFee)
                : base(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    destination)
            {
                ExtraFee = extraFee;
            }
        }
}
