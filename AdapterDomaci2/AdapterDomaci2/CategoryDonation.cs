namespace AdapterDomaci2
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>

    public class CategoryDonation : Donation //KategorizovanaDonacija
        {
            private string donation;
            private Warehouse warehouse;

            // Constructor

            public CategoryDonation(string donation)
            {
                this.donation = donation;
            }

            public override void Display()
            {
                // The Adaptee

                warehouse = new Warehouse();
                maxDonation = warehouse.GetDontationInterval(donation, "X");
                minDonation = warehouse.GetDontationInterval(donation, "N");
                
                NoOfCouriers = warehouse.GetNoOfCouriers(donation);
                deliveryProjection = warehouse.GetDeliveryProjection(donation);

                Console.WriteLine("\nDonation: {0} ------ ", donation);
                Console.WriteLine(" To be delivered in: {0} ", deliveryProjection);
                Console.WriteLine(" To be delivered by : {0} couriers", NoOfCouriers);
                Console.WriteLine(" The max amount that can be donated at one time: {0}", maxDonation);
                Console.WriteLine(" The min amount that can be donated: {0}", minDonation);
            }
        }
    }

