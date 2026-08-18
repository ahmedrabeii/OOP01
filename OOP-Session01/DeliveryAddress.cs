using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Session01
{
    #region Question1
    //public struct DeliveryAddress
    //{
    //    public string City;
    //    public string Street;
    //}


    //public class Customer
    //{
    //    public string Name;
    //}
    #endregion

    #region Question2
    public struct shipment
    {
        //answer a:

        //public string describtion;
        //public double weight;
        //public decimal DeliveryFee;

        //first problem: All fields are public, so they can be accessed and modified directly from outside the struct.

        //second problem: There is no data validation, so invalid values such as a negative weight or delivery fee can be assigned.

        //third problem: The internal data is not protected, because any code can change the fields without any control.

        //-------------------------
        //answer b: 

        //private string describtion;
        //private double weight;
        //private decimal DeliveryFee;

        //public void setDescribtion(string describtion)
        //{
        //    this.describtion = describtion;
        //}

        //public string getDescribtion()
        //{
        //    return describtion;
        //}


        //public void setWeight(double weight)
        //{
        //    if (weight >= 0)
        //    {
        //        this.weight = weight;
        //    }
        //}
        //public double getWeight()
        //{
        //    return weight;
        //}


        //public void setDeliveryFee(decimal DeliveryFee)
        //{
        //    if (DeliveryFee >= 0)
        //    {
        //        this.DeliveryFee = DeliveryFee;
        //    }
        //}
        //public decimal getDeliveryFee()
        //{
        //    return DeliveryFee;
        //}
    #endregion


    #region Part 02 : Practical

        public struct DeliveryAddress
        {
            public string city;
            public string street;
            public int buildingNumber;
            public DeliveryAddress(string city, string street, int buildingNumber)
            {
                this.city = city;
                this.street = street;
                this.buildingNumber = buildingNumber;
            }

            public string GetFullAddress()
            {
                return $"{buildingNumber} {street}, {city}";
            }

        }
        #endregion
    }
}
