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

        }
    }
}
