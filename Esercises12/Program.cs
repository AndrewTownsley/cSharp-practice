namespace Esercises12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter a series of numbers seperated by a comma example: 1,2,3,4,5");

            var userNumbers = Console.ReadLine();

            var numbers = userNumbers.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach(var item in numbers)
            {
                var num = Convert.ToInt32(item);
                if (num > max)
                    max = num;
            }
                Console.WriteLine("Max is" + " " + max);







            /*var random = new Random();
            var secretNumber = random.Next(1, 10);

            Console.WriteLine(secretNumber);
            Console.WriteLine("Please Guess A Number Between 1 and 10...");
            var userGuess = int.Parse(Console.ReadLine());

            if (secretNumber == userGuess)
            {
                Console.WriteLine("Correct :)");
            }
            else
                Console.WriteLine("Wrong :(");
*/





            /*Console.WriteLine("Please enter a number to get it's factorial");

            int userNumber = int.Parse(Console.ReadLine());
            int factorial = 1;

            for(int i=1; i <= userNumber; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(" {0}! = {1}", userNumber, factorial);*/







/*
            var count = 0;
            while (true)
            {
                Console.WriteLine("Enter a Number or ok");
                var userInputRaw = Console.ReadLine();
                var userNumber = 0;
                if(userInputRaw.ToLower() != "ok")
                {
                    userNumber= Convert.ToInt32(userInputRaw);
                    count += userNumber;
                } else
                {
                    break;
                }
            Console.WriteLine(count);
                continue;
            }*/

            










      /*      int divideByThree = 0;

            for(int i=1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    divideByThree++;
                }
            }
                    Console.WriteLine(divideByThree);
            */





            /*var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
                *//*                Console.WriteLine(random.Next(1,100));*//*
                buffer[i] = (char)('a' + random.Next(0, 26));
                var password = new string(buffer);
                Console.WriteLine(password);    
            */




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