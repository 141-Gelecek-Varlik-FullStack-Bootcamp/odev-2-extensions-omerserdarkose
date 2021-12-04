using Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class Extensions
    {
        //belirtilen formatlama islemini yapan extension
        public static string ContactInfo(this ICustomer customer)
        {
            return "Customer_Name: " + customer.FirstName + " " + customer.LastName + "\n" + "" +
                "Customer_PhoneNumber: +90" + customer.PhoneNumber;
        }

        //reflection ile nesnenin tipini donduren extension method
        public static string InstanceType(this ICustomer instance)
        {
            Type type = instance.GetType();
            return type.ToString();
        }
    }
}
