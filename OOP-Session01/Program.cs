using OOP_Session01;
using System.Data.SqlTypes;
using static OOP_Session01.shipment;


namespace OOPSession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 01 : Theoretical Questions
            #region Question1
            //answer a:
            //DeliveryAddress address1 = new DeliveryAddress();

            //address1.City = "New York";
            //address1.Street = "5th Avenue";

            //DeliveryAddress address2 = address1;

            //address2.Street = "Broadway";

            //Console.WriteLine(address1.Street);
            //Console.WriteLine(address2.Street);

            // When a 'DeliveryAddress' variable is copied to another variable,
            // a copy of the value is made.Modifying the copy does not affect the original variable,
            // because it's a struct(value type)

            //answer b:
            //Customer customer1 = new Customer();
            //customer1.Name="Ahmed";

            //Customer customer2 = customer1;
            //customer2.Name = "Mohamed";

            //Console.WriteLine(customer1.Name);
            //Console.WriteLine(customer2.Name);

            //If `Customer` is a class, it is a reference type. When we copy it to another variable,
            //we copy the reference, not the actual object. This means both variables point to the same object,
            //so modifying one variable will also affect the original object
            #endregion

            #region Question2
            //shipment shipment1=new shipment();
            //shipment1.setDescribtion("this is a shipment");
            //shipment1.setWeight(1); 
            //shipment1.setDeliveryFee(10);

            //Console.WriteLine(shipment1.getDescribtion());
            //Console.WriteLine(shipment1.getWeight());
            //Console.WriteLine(shipment1.getDeliveryFee());
            #endregion

            #region Part 02 :Practical 

            //       DeliveryCenter center = new DeliveryCenter();


            //       for (int i = 0; i < 3; i++)
            //       {
            //           Console.WriteLine($"Enter data for Shipment {i + 1}");

            //           Console.Write("Tracking Code: ");
            //           string trackingCode = Console.ReadLine();

            //           Console.Write("Description: ");
            //           string description = Console.ReadLine();

            //           Console.Write("Weight: ");
            //           double weight = double.Parse(Console.ReadLine());

            //           Console.Write("Delivery Fee: ");
            //           decimal deliveryFee = decimal.Parse(Console.ReadLine());

            //           Console.Write("City: ");
            //           string city = Console.ReadLine();

            //           Console.Write("Street: ");
            //           string street = Console.ReadLine();

            //           Console.Write("Building Number: ");
            //           int buildingNumber = int.Parse(Console.ReadLine());

            //           // Create Delivery Address
            //           DeliveryAddress address =
            //               new DeliveryAddress(city, street, buildingNumber);

            //           // Create Shipment
            //           Shipment shipment = new Shipment(
            //            trackingCode,
            //            description,
            //            weight,
            //            deliveryFee,
            //            address);


            //           // Add Shipment to Delivery Center
            //           bool added = center.AddShipment(shipment);

            //           if (added)
            //           {
            //               Console.WriteLine("Shipment added successfully.");
            //           }
            //           else
            //           {
            //               Console.WriteLine("Delivery Center is full.");
            //           }

            //           Console.WriteLine();
            //       }

            //       // Print the 3 shipments using integer indexer
            //       Console.WriteLine("========== All Shipments ==========");

            //       for (int i = 0; i < 3; i++)
            //       {
            //           center[i].PrintShipment();
            //           Console.WriteLine("----------------------------");
            //       }

            //       // Search for shipment
            //       Console.Write("Enter Tracking Code to search: ");
            //       string searchCode = Console.ReadLine();

            //       Shipment foundShipment = center[searchCode];

            //       // Print found shipment
            //       if (!string.IsNullOrEmpty(foundShipment.TrackingCode))
            //       {
            //           Console.WriteLine("========== Shipment Found ==========");
            //           foundShipment.PrintShipment();
            //       }
            //       else
            //       {
            //           Console.WriteLine("Shipment not found.");
            //       }

            //       // Demonstrate DeliveryAddress copy behavior
            //       Console.WriteLine();
            //       Console.WriteLine("========== Delivery Address Copy Test ==========");

            //       DeliveryAddress address1 =
            //           new DeliveryAddress("Fayoum", "Main Street", 10);

            //       DeliveryAddress address2 = address1;

            //       // Modify the copy
            //       address2 =
            //           new DeliveryAddress("Giza", "Nile Street", 20);

            //       Console.WriteLine("Original Address:");
            //       Console.WriteLine(address1.GetFullAddress());

            //       Console.WriteLine("Copied Address:");
            //       Console.WriteLine(address2.GetFullAddress());
            #endregion
        }
    }


    }


