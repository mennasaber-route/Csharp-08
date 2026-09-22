namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // *******   OOP 02 – Smart Delivery Management System  **********
            //    Part 01 : Theoretical Questions   //

            #region  Question 1

            //a) What is the difference between a class and a struct?

            // A class is a reference type, This means that when you create an instance of a class, it is stored on the heap and accessed through a reference ,Classes can have inheritance and polymorphism, can be null , copied by reference , best for complex data.
            // A struct is a value type , while an instance of a struct is stored on the stack and accessed directly, cannot have inheritance and polymorphism , cannot be null, copied by value, best for simple data.

            #endregion


            #region  Question 2

            //b) Why are classes more suitable than structs for large applications?

            // as classes support inheritance and polymorphism, which are essential for creating complex and extensible systems. and classes are reference types, they are more suitable for large applications because they can be easily managed and manipulated through references,
            // allowing for better memory management and performance.
            // Structs, being value types, can lead to performance issues when used in large applications due to copying overhead and lack of flexibility.


            #endregion


            #region  Question 2-2

            //b) Why are classes more suitable than structs for large applications?


            //a) Which class is the parent class?             Shipment
            //b) Which class is the child class?              ExpressShipment
            //c) What members are inherited by ExpressShipment?              TrackingCode 
            //d) Why is inheritance better than duplicating the same code in multiple classes?       as inheritance allows for code reuse and promotes a hierarchical relationship between classes,
            //making the code more organized, maintainable, and easier to understand. It reduces redundancy and ensures that changes
            //made to the parent class are automatically reflected in the child classes, leading to better consistency and less chance of errors.

            #endregion

            //   Part 02 : Practical   //


            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter center = new DeliveryCenter(centerName);

            Console.WriteLine();
            Console.WriteLine("Standard Shipment ");

            Console.Write("Enter Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Enter Weight: ");
            decimal weight1 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Delivery Fee: ");
            decimal deliveryFee1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Destination:");

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber1 = int.Parse(Console.ReadLine());

            DeliveryAddress address1 =
                new DeliveryAddress(
                    city1,
                    street1,
                    buildingNumber1);

            StandardShipment standardShipment =
                new StandardShipment(
                    trackingCode1,
                    description1,
                    weight1,
                    deliveryFee1,
                    address1);


            Console.WriteLine();
            Console.WriteLine("Express Shipment ");

            Console.Write("Enter Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Enter Weight: ");
            decimal weight2 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Delivery Fee: ");
            decimal deliveryFee2 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Destination:");

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber2 = int.Parse(Console.ReadLine());

            DeliveryAddress address2 =
                new DeliveryAddress(
                    city2,
                    street2,
                    buildingNumber2);

            ExpressShipment expressShipment =
                new ExpressShipment(
                    trackingCode2,
                    description2,
                    weight2,
                    deliveryFee2,
                    address2,
                    extraFee);


            Console.WriteLine();
            Console.WriteLine("International Shipment");

            Console.Write("Enter Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Enter Weight: ");
            decimal weight3 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Delivery Fee: ");
            decimal deliveryFee3 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Enter Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Destination:");

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber3 = int.Parse(Console.ReadLine());

            DeliveryAddress address3 =
                new DeliveryAddress(
                    city3,
                    street3,
                    buildingNumber3);

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    trackingCode3,
                    description3,
                    weight3,
                    deliveryFee3,
                    address3,
                    destinationCountry,
                    customsFee);


            Console.WriteLine();
            Console.WriteLine("Adding Shipments");

            Console.WriteLine(
                $"Standard Shipment Added: " +
                $"{center.AddShipment(standardShipment)}");

            Console.WriteLine(
                $"Express Shipment Added: " +
                $"{center.AddShipment(expressShipment)}");

            Console.WriteLine(
                $"International Shipment Added: " +
                $"{center.AddShipment(internationalShipment)}");


            Console.WriteLine();
            Console.WriteLine("All Shipments");

            center.PrintAllShipments();


            Console.WriteLine();
            Console.Write("Enter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Found");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            Console.WriteLine();
            Console.Write("Enter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();

            bool removed = center.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine("Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            Console.WriteLine();
            Console.WriteLine("Remaining Shipments");

            center.PrintAllShipments();


        }
    }
}
