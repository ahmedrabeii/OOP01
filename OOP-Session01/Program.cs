using OOP_Session01;

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

        }
    }
}
