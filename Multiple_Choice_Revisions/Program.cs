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

            //// function created to create more custom feedback
            //static void NoInputChoice()
            //{
            //    Console.WriteLine("You did not input a choice");
            //}


            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //if (name == "")
            //{
            //    NoInputChoice();
            //    name = Console.ReadLine();
            //}


            //Console.WriteLine("How old are you?");
            //var age = Console.ReadLine();
            //if (age == "")
            //{
            //    NoInputChoice();
            //    age = Console.ReadLine();
            //}



            //Console.WriteLine("What month were you born in?");
            //var month = Console.ReadLine();
            //if (month == "")
            //{
            //    NoInputChoice();
            //    month = Console.ReadLine();
            //}


            //Console.WriteLine("What is your favoriot color?");
            //var color = Console.ReadLine();
            //if (color == "")
            //{
            //    NoInputChoice();
            //    color = Console.ReadLine();
            //}


            //Console.WriteLine("Your name is: {0}", name);
            //Console.WriteLine("Your age is: {0}", age);
            //Console.WriteLine("Your birth month is: {0}", month);
            //Console.WriteLine("Your favoriot color is: {0}", color);

            #endregion

            #region Format three


            //// replaced the type void to a type string so it can have a return
            //static string PleaseInputChoice()
            //{
            //    Console.WriteLine("You did not input a choice");
            //    return Console.ReadLine();
            //}


            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //if (name == "")
            //{

            //    name = PleaseInputChoice();
            //}


            //Console.WriteLine("How old are you?");
            //var age = Console.ReadLine();
            //if (age == "")
            //{

            //    age = PleaseInputChoice();
            //}



            //Console.WriteLine("What month were you born in?");
            //var month = Console.ReadLine();
            //if (month == "")
            //{

            //    month = PleaseInputChoice();
            //}


            //Console.WriteLine("What is your favoriot color?");
            //var color = Console.ReadLine();
            //if (color == "")
            //{
            //    color = PleaseInputChoice();
            //}


            //Console.WriteLine("Your name is: {0}", name);
            //Console.WriteLine("Your age is: {0}", age);
            //Console.WriteLine("Your birth month is: {0}", month);
            //Console.WriteLine("Your favoriot color is: {0}", color);


            #endregion

            #region Format Four

            // removed as much as duplicate  code as I could
            static string pleaseInputChoice()
            {
                var answer = Console.ReadLine();
                if (answer == "")
                {
                Console.WriteLine("You did not input a choice");
                return Console.ReadLine();
                }
                return answer;
            }


            Console.WriteLine("What is your name?");
            var name = pleaseInputChoice();

             
            Console.WriteLine("How old are you?");
            var age = pleaseInputChoice();
           
      
            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();
          
              
            Console.WriteLine("What is your favoriot color?");
            var color = pleaseInputChoice();
           
                
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("Your favoriot color is: {0}", color);

            #endregion
        }
    }
}
