using System;
using System.ComponentModel;

namespace Enum
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisterAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Prints "RegisterAirMail
            Console.WriteLine((ShippingMethod)2);
            
            var method = ShippingMethod.Express;

            //prints "3"
            Console.WriteLine((int)method);

            //prints "Express"
            Console.WriteLine(method);

            //convert an external number to an Enum-> Cast to convert an int to a shipping method
            //prints "Express"
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //Explicity convert enum to a string
            //prints "Express"
            Console.WriteLine(method.ToString());

            //convert an external string to a shipping method and see if it exists
            //prints "Express"
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)System.Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

            //Check if the method exists
            //prints "This type is defined: RegularAirMail"
            var method1 = 1;
            if (System.Enum.IsDefined(typeof(ShippingMethod), method1))
            {
                Console.WriteLine("This type is defined: {0}", (ShippingMethod)method1);
            }
            else
            {
                Console.WriteLine("that method doesn't exist");
            }

            //Check if the method 5 exists in the Enum "Shipping Method"
            //prints "that method doesn't exist"
            var method5 = 5;
            if (System.Enum.IsDefined(typeof(ShippingMethod), method5))
            {
                Console.WriteLine("This type is defined: {0}", (ShippingMethod)method5);
            }
            else
            {
                Console.WriteLine("that method doesn't exist");
                //throw new InvalidEnumArgumentException("ShippingMethod", method5, typeof(ShippingMethod));
            }

        }
            
            
    }
}
