using System;

namespace Multiple_Choice_Revisions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Format one

            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //if(name == "")
            //{
            //    Console.WriteLine("You did not input a choice");
            //    name = Console.ReadLine();
            //}


            //Console.WriteLine("How old are you?");
            //var age = Console.ReadLine();
            //if(age == "")
            //{
            //    Console.WriteLine("You did not input a choice");
            //    age = Console.ReadLine();
            //}



            //Console.WriteLine("What month were you born in?");
            //var month = Console.ReadLine();
            //if (month == "")
            //{
            //    Console.WriteLine("You did not input a choice");
            //    month = Console.ReadLine();
            //}


            //Console.WriteLine("What is your favoriot color?");
            //var color = Console.ReadLine();
            //if (color == "")
            //{
            //    Console.WriteLine("You did not input a choice");
            //    color = Console.ReadLine();
            //}


            //Console.WriteLine("Your name is: {0}", name);
            //Console.WriteLine("Your age is: {0}", age);
            //Console.WriteLine("Your birth month is: {0}", month);
            //Console.WriteLine("Your favoriot color is: {0}", color);

            #endregion

            #region Format two

            static void NoInputChoice()
            {
                Console.WriteLine("You did not input a choice");
            }


            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            if (name == "")
            {
                NoInputChoice();
                name = Console.ReadLine();
            }


            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            if (age == "")
            {
                NoInputChoice();
                age = Console.ReadLine();
            }



            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();
            if (month == "")
            {
                NoInputChoice();
                month = Console.ReadLine();
            }


            Console.WriteLine("What is your favoriot color?");
            var color = Console.ReadLine();
            if (color == "")
            {
                NoInputChoice();
                color = Console.ReadLine();
            }


            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("Your favoriot color is: {0}", color);

            #endregion


        }
    }
}
