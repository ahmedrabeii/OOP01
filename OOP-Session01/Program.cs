using OOP_Session01;

namespace OOPSession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 01 : Theoretical Questions
            #region Question1
            //DeliveryAddress address1 = new DeliveryAddress();

            //address1.City = "New York";
            //address1.Street = "5th Avenue";

            //DeliveryAddress address2 = address1;

            //address2.Street = "Broadway";

            //Console.WriteLine(address1.Street);
            //Console.WriteLine(address2.Street);

            //answer: 
            // When a DeliveryAddress variable is copied to another variable,
            // a copy of the value is made.Modifying the copy does not affect the original variable,
            // because it's a struct(value type)
            #endregion
        }
    }
}
