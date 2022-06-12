namespace Esercises12
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
                /*                Console.WriteLine(random.Next(1,100));*/
                buffer[i] = (char)('a' + random.Next(0, 26));
                var password = new string(buffer);
                Console.WriteLine(password);    
            




           /* while (true)
            {
                Console.Write("Enter your Name...");
                var nameInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(nameInput))
                {
                    Console.WriteLine("@Echo" + " " + nameInput);
                    continue;
                }
            }*/


            // While Loop
         /*   var i = 0;

            while(i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }*/

            // foreach Loop

            /*var stockArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach( var num in stockArray)
            {
                if(num % 2 == 0)
                Console.WriteLine(num);
            }*/


            // foreach Loop
          /*  var userName = "Othello Ferrari";

            foreach(var character in userName)
            {
                Console.WriteLine(character);
            }*/



          /*  for (var i = 0; i < userName.Length; i++)
            {
                Console.WriteLine(userName[i]);
            }*/



        /*    Console.WriteLine("Enter Speed Limit:  ");
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
                Console.WriteLine("Suspended :o");*/


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