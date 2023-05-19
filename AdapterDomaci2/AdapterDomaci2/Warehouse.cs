namespace AdapterDomaci2
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>

    public class Warehouse
        {
            // The datawarehouse 'legacy API'

            public float GetDontationInterval(string Donation, string point) //get min or max amount of one time donation
            {
                // Max amount donated at one time
                if (point == "X")
                {
                    switch (Donation.ToLower())
                    {
                        case "food": return 1000000;
                        case "money": return 500000000;
                        case "clothes": return 2000000;
                        case "shoes": return 11000000;
                        default: return 10000000;
                    }
                }

                // Min amount donated at one time

                else
                {
                    switch (Donation.ToLower())
                    {
                        case "food": return 200;
                        case "money": return 1000;
                        case "clothes": return 2000;
                        case "shoes":return 1000;
                        default: return 500;
                    }
                }
            }

            public string GetDeliveryProjection(string Donation) //get min days to deliver
            {
                switch (Donation.ToLower())
                {
                    case "food": return "3 days";
                    case "money": return "1 day";
                    case "clothes": return "4 days";
                    case "shoes":return "4 days";
                    default: return "3 days";
                }
            }

            public double GetNoOfCouriers(string Donation) //get number of courriers
            {
                switch (Donation.ToLower())
                {
                    case "food": return 5;
                    case "money": return 1;
                    case "clothes": return 4;
                    case "shoes": return 2;
                    default: return 3;
                }
            }
        }
    }

