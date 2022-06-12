namespace Esercises12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Speed Limit:  ");
            var limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Speed of Vehicle: ");
            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed <= limit)
            {
                Console.WriteLine("Legal");
            }
            else if (speed - limit > 4 && speed - limit <= 9)
            {
                Console.WriteLine("5 over, 1 Point :(");
            }
            else if (speed - limit > 9 && speed - limit <= 12)
            {
                Console.WriteLine("2 Points :<");
            }
            else if (speed - limit > 12)
                Console.WriteLine("Suspended :o");


            /*       Console.WriteLine("Please Height then Width of Image...");
                   var height = Convert.ToInt32(Console.ReadLine());
                   var width= Convert.ToInt32(Console.ReadLine());

                   if (height > width)
                   {
                       Console.WriteLine("Portrait");
                   }
                   else
                       Console.WriteLine("Landscape");*/



            /*      Console.WriteLine("Please Enter 2 numbers...");
                  var userNumber1 = Convert.ToInt32(Console.ReadLine());
                  var userNumber2 = Convert.ToInt32(Console.ReadLine());

                  if(userNumber1 > userNumber2)
                  {
                      Console.WriteLine(userNumber1);
                  } else
                      Console.WriteLine(userNumber2);*/



            /*  Console.WriteLine("Enter a number Please...");
              var userNumber = Convert.ToInt32(Console.ReadLine());
              if(userNumber >= 1 && userNumber <= 10)
              {
                  Console.WriteLine("Correct Number");
              } else
                  Console.WriteLine("            Console.ReadLine();
  Incorrect :(");*/
        }
    }
}