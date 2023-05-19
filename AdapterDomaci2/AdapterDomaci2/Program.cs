using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDomaci2
{
    internal class Program
    {
            public static void Main(string[] args)
            {
                // Non-adapted donation Donation

                Donation unknown = new Donation();
                unknown.Display();

                // Adapted donation Donations

                Donation food = new CategoryDonation("food");
                food.Display();

                Donation money = new CategoryDonation("money");
                money.Display();

                Donation clothes = new CategoryDonation("clothes");
                clothes.Display();

                Donation shoes = new CategoryDonation("shoes");
                shoes.Display();

            // Wait for user

            Console.ReadKey();
            }
        }
    }

