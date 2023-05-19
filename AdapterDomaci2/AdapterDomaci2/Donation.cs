namespace AdapterDomaci2
{
    /// <summary>
    /// The 'Target' class
    /// </summary>

    public class Donation //donacija
        {
            protected float minDonation;
            protected float maxDonation;
            protected double NoOfCouriers;
            protected string deliveryProjection;

            public virtual void Display()
            {
                Console.WriteLine("\nDonation: Unknown ------ ");
            }
        }
    }

