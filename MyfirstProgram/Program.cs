using System;
using System.Collections.Generic;
using System.Threading;

namespace MyfirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {/*
            double price = 47.7;
            int b = Convert.ToInt32(price);
            double c = Convert.ToDouble(b)+0.3;

            string s = "h";
            char k = Convert.ToChar(s);
            string bo = "true";
            bool bu = Convert.ToBoolean(bo);

            Console.WriteLine("Jgb");
          
            Console.WriteLine(price);
            Console.WriteLine(price.GetType());
            Console.WriteLine(bu);      
          */

            /*
              Console.WriteLine("Enter your name");
              string name = Console.ReadLine();
              Console.WriteLine("Enter your age");
              int age = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Hello " + name);
              Console.WriteLine("Your are " + age + " years old.");
            */

            /*double rem = 15 / 2;

            double x = 21;
            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(x);
            Console.WriteLine(a + "  " + Math.Floor(b));

            Console.WriteLine(rem+0.5);
            */
            /*
                        //Generating Random Number
                        Random random = new Random();
                        int num1 = random.Next(0, 7);
                        double num2 = random.NextDouble()*100;
                        Console.WriteLine(num1);
                        Console.WriteLine(num2);
            */

            /*
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt((a * b) + (b * b));
            Console.WriteLine("The hypotenuse is: " + c);
            */

            /*
            string fullName = "Jgamer boy";
            fullName = fullName.ToUpper();
            //fullName = fullName.Insert(0,"@");
            //fullName = fullName.Substring(0,5);
            String firstName = fullName.Substring(7,3 ); // 1st argu is the index and 2nd is length of the string;
            Console.WriteLine(firstName);

            string phoneNumber = "+251-929019024";
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine(phoneNumber);
            */
            /*
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            if(name != "")
            {
                Console.WriteLine("Hello " + name + " Welcome");
            }
            else
            {
                Console.WriteLine("You didn't enter any name! enter your name.");
            }
            */
            /*
            Console.WriteLine("Enter number of the day");
            
            int day = Convert.ToInt32(Console.ReadLine());
            
                switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuseday");
                    break;
                default:
                    Console.WriteLine("day of the week");
                    break;
                        
            }    */
            /*
                        Console.WriteLine("Enter the rows");
                        int rows = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the columns");
                        int columns = Convert.ToInt32(Console.ReadLine());


                        for (int i=0; i < rows; i++)
                        {
                            for (int k = 5; k >= i; k--)
                            {
                                Console.Write(" ");
                            }
                            for (int j=0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            for (int h = 1; h <= i; h++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        */

            /*
            //Guessing game
            Random random = new Random();
            int min = 1;
            int max = 100;
            
            int number;
            bool isPlayAgain = true;
            string choose;
            while (isPlayAgain)
            {
            int guess=0;
            int guesses=0;
                Console.WriteLine("Guess a number between 1 - 100");

                number = random.Next(min, max + 1);

                while (guess != number) { 
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine(guess + ": to high");
                } else if (guess < number)
                {
                    Console.WriteLine(guess + ": to low");
                }
                else
                {
                    Console.WriteLine("You Win !!! " + guess + " is the right answer");
                        
                }
                    guesses++;
                }

                Console.WriteLine("Guess: " + guesses);
                Console.WriteLine("Would you like to play again (y/n)");
                choose = Console.ReadLine().ToUpper();
               
                if(choose == "N")
                {
                    isPlayAgain = false;
                    Console.WriteLine("THANKS FOR PLAYING !!!");
                }

            }
            */

            /*
            //ROCK, PAPER , SCISSORS
            bool isPlayAgain = true;
            string player = "";
            string computer = "";
          //string playerChoice = "";
            Random random = new Random();

            while(isPlayAgain)
            {
                Console.WriteLine("Enter ROCK , PAPER , SCISSORS . Enter Q to quit the Game.");
                player = Console.ReadLine();
                player = player.ToUpper();
                if (player == "Q")
                {
                    //isPlayAgain = false;
                    break;
                }

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS" ) {
                    Console.WriteLine("Enter ROCK , PAPER , SCISSORS");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch(random.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("player " + player);
                Console.WriteLine("computer " + computer); 

                switch(computer)
                {
                    case "ROCK":
                        if (player == "ROCK")
                        {
                            Console.WriteLine("It's draw!");
                        }
                        else if (player == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("You loss!");
                        }
                        break;
                    case "PAPER":
                        if (player == "ROCK")
                        {
                            Console.WriteLine("You loss!");
                        }
                        else if (player == "PAPER")
                        {
                            Console.WriteLine("It's draw!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSORS":
                        if (player == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (player == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("It's draw!");
                        }
                        break;
                }
                
            }
            Console.WriteLine("THANKS FOR PLAYING OUR GAME !!!");

            */

            // Calculator 

            /*
            double num1;
            double num2;
            int operation ;
            double result;
            do
            {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Calculator program!");
            Console.WriteLine("_______________________________________");
                Console.WriteLine("Enter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplection");
                Console.WriteLine("Enter 4 for divition");
                operation = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter two numbers to perform calculation");
                Console.Write("Enter the first no:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second no:");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine("result: " + result);
                        Console.WriteLine("_______________________________________");

                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine("result: " + result);
                        Console.WriteLine("_______________________________________");

                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine("result: " + result);
                        Console.WriteLine("_______________________________________");

                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine("result: " + num1 / num2);
                            Console.WriteLine("_______________________________________");


                        }
                        else
                            Console.WriteLine("demonitor can't be zero!!!" +
                                "");
                        break;
                    default:
                        Console.WriteLine();
                        break;

                }

                Console.WriteLine("Would like to perform more calculation Y/N");

            } while (Console.ReadLine().ToUpper() =="Y" );
            Console.WriteLine("Bye");
            */

            /*
            String[] Games = { "Resident Evil", "God of War", "GTA", "COD", "Far Cry", "AC" };
            Games[5] = "The Last of Us";

            for(int i=0; i < Games.Length; i++)
            {
                Console.WriteLine(Games[i]);
            }

            //foreach
            foreach(string game in Games)
            {
                Console.WriteLine(game);
            }
            */

            /*
            //invoking a method(function)
            string name = "Ada Wong";
            string gtaname = "Kratos";
            int num = 5;

            gameQuote(name,gtaname,num);
            
            Console.Write("Enter no 1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no 2: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x, y));

            double total = checkOut(3.99, 5.75, 15,1,10.25);
            Console.WriteLine(total);
*/
            /*
            // exception
            //      try     = try some code that is considered "dangerous"
            //      catch   = catches and handles exceptions when they occur we can have multiple catch in one exception
            //      finally = always executes regardless if exception is caught or not

            int x;
            int y;
            double result;
            try {
            Console.Write("Enter num 1: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num 2: ");
            y = Convert.ToInt32(Console.ReadLine());
            result = x / y;
            Console.WriteLine("result: " + result);
            }catch(DivideByZeroException e)
            {
                Console.Write("Zero can't divie a number!");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Enter only number please!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is Wrong!");
            }
            finally {
                Console.WriteLine("Thanks for visiting");
            }
            */

            /*
            //conditional operator = used in conditional assignment if a condition is true/false
            // syntax = (condition) ? x : y

            double temperature ;
            string message;

            Console.WriteLine("Enter the temperature");
            temperature = Convert.ToDouble(Console.ReadLine());
            message = (temperature >= 20) ? "It's warm outside" : "It's cold outside";
            Console.WriteLine(message);
             */

            /*
                        // string interpolation = allows us to insert variables into a string literal
                        // ""        ""         = precede a string literal with $
                        // ""        ""         = {} are placeholders

                        string fName = "JGB";
                        string lName = "Bro";
                        int age = 23;
                        Console.WriteLine($"HI {fName} {lName}. ");
                        Console.WriteLine($"You are {age,-10} Year old.");

            */

            /*
            //multidimensional array
            //GetLength() = to get the length of the inner array

            String[,] parkingLot = { { "Mustang","F-150","Explorer"} ,
                                      {"Corvette", "Camaro" , "Silverado" },
                                      {"Corolla","Camry","Rav4" }
                                    };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";

            for(int i=0; i < parkingLot.GetLength(0); i++)
            {
                Console.Write(i + " Index: ");
                for(int j =0; j < parkingLot.GetLength(0); j++)
                {
                    Console.Write(parkingLot[i,j] + " ");
                }
                
                Console.WriteLine();
            }
            */

            /*
            //calling class from different class file
            Message.hello();

            //creating new class on the same file and invoking methods and initiating
            //human 1
            Human human1 = new Human("JGB", 22);
            human1.eating();
            human1.year();
            //human 2
            Human human2 = new Human("Jossi", 23);

            human2.eating();
            human2.year();

            //object initiating
            Game game1 = new Game("Activsion", "Call of duty: modern warefare 2", 2013, "Shooting");
            game1.play();

            Game game2 = new Game("Capcom", "Resident evil 4", 2004, "Horror");
            game2.play();
            */

            /*
            //Inheritance class
            Car car1 = new Car();
            Bicycle bicycle = new Bicycle();

            car1.go();
            bicycle.go();

            Console.WriteLine(car1.speed) ;
            Console.WriteLine(car1.wheels);

            */


            //can't be access b/c it's an abstract class
            //Vehicle vehicle = new Vehicle();

            /*
                        //array of objects
                        Car car1 = new Car("Rav4");
                        Car car2 = new Car("hunda");
                        //first way to create array of class
                        /*Car[] garage = new Car[3];
                         garage[1] =  car1 ;
                         garage [2]=  car2 ;
                        *//*
                        //the second easy way
                        Car[] garage = { new Car("Rav4"), new Car("hunda") };
                        foreach(Car car in garage) { 
                        Console.WriteLine(car.model);
                        }
                        */
            /*
             //override
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.sound();
            dog.sound();
*/
            /*
             
            // polymorphism = Greek word tha means to "have many forms"
            //                Objects can be identified by more than one type
            Cat cat = new Cat();
            Dog dog = new Dog();
            Animal[] animals = { cat,dog };
            foreach(Animal animal in animals)
            {
                animal.sound();
            } 
            */
            /*
             * interface example
            Rabbit rabbit = new Rabbit();
            Snake snake = new Snake();
            Fish fish = new Fish();
            fish.hunt();
            fish.flee();
            */

            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size
            //        using System.Collections.Generic;
            /*
            List<string> food = new List<string>();

            food.Add("Kitfo");
            food.Add("Pizza");
            food.Add("Burger");
            food.Add("Tibes");
            // food.Insert(0, "Avocado");
            // food.Remove("Tibes");
            // food.Sort();
            // food.Reverse();
            // food.Clear();
            // Console.WriteLine(food.Count);
            // Console.WriteLine(food.IndexOf("Pizza"));
            // Console.WriteLine(food.LastIndexOf("Burger"));
            // Console.WriteLine(food.Contains("Pizza"));
            foreach(string foods in food)
            {
                Console.WriteLine(foods);
            }
            */

            /*
            List<Player> players = new List<Player>();
            players.Add(new Player("Yosi"));
            players.Add(new Player("Josi"));
            players.Add(new Player("Nati"));

            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }*/

            /*
            // generic = "not specific to a particular dat type"
            //           add <T> to: classes, methods , fields, etc.
            //           allows for code reusability for different data types
            int[] intArr = { 1, 2, 3 };
            double[] doubArr = { 1.0, 2.0, 3.0};
            string[] stringArr = { "1", "2", "3" };
            displayElemnt(intArr);
            displayElemnt(doubArr);
            displayElemnt(stringArr);
            
             */

            /*
            String name = PlanetsRadius.Earth.ToString();
            int rad = (int)PlanetsRadius.Earth;
            Console.WriteLine(rad);
*/
            // thread = an execution path of a program
            //          We cAn use multile threads to perform,
            //          different use multiple threads to perform,
            //          Current thread running is "main" thread
            //          using System.Threading;

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);
            Thread thread1 = new Thread(() => CountDown("hii"));
            Thread thread2 = new Thread(CountUp);

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
            //Console.ReadLine();
            Console.Beep();
        }    
        public static void CountDown(string name)
        {
            for (int i = 10; i >=0; i--)
            {
                Console.WriteLine(i + " :second " + name);
                Thread.Sleep(1000);
            }
        }
        public static void CountUp()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " :second");
                Thread.Sleep(1000);
            }
        }
        //generic
        public static void displayElemnt<Thing>(Thing[] array){
                foreach(Thing item in array){
                    Console.Write(item + " ");
                }
            Console.WriteLine();
            }

        /*
        // params keyword = a method parameter that takes a variable number of arguments.
        //                  the parameter type must be a single - dimensional array

        static double checkOut(params double[] prices)
        {
            double total = 0;
            foreach(double price in prices)
            {
                total += price;
            }
            return total;
        }
        */
        /*
         //A method(function)
            static void gameQuote(string re,string name, int num)
            {
            Console.WriteLine("Leon S.Kenndey... you haven't changed!!!" + re + " is the one who said it.");
            Console.WriteLine("Zeus your son have returned! said by " + name);
            Console.WriteLine("leister molister! said more than: \"" + num + "\" times by Trevor");
            Console.WriteLine("enemy down!");
            Console.WriteLine("Rude boy!");
            Console.WriteLine("kill them i have the instrument to make more ");
            }
       

        static int result(int x,int y)

        {
            return x * y;
        }
        */


    }
    /*
    // static = modifier to declare a static member, which belongs to the class itself
    // static method,class & variable doesn't belong to any object 

    // overloaded constructors = technique to create multiple constructors.
    //                           with a different set of parameters.
    //                           name _ parameters = signature

    class Human{
    
        public string name;
        public int age;

        //constructors
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public void eating()
        {
            Console.WriteLine($"{name} is eating");
        }
        public void year()
        {
            Console.WriteLine($"{name} is {age} year old.");
        }
    }

    class Game
    {
        string company;
        string name;
        int year;
        string kind;

        public  Game(string company, string name, int year, string kind)
        {
            this.company = company;
            this.name = name;
            this.year = year;
            this.kind = kind;
        }
        public void play()
        {
            Console.WriteLine($"Your are playing {name} a {kind} game released on {year} by {company}. ");
        }
    }
}
    */
    // inheritance we can use to the child class like this (child class : parent class )
    
    // abstract classes = modifier that indicates missing components or incomplete implementation
    // parent class
    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        public string model;
        public Car(string model)
        {
            this.model = model;
        }
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    //method overriding = provides a new version of a method inherited from a parent class
    //                    inherited method must be: abstract, virtual, or already overriden
    //                    used with ToString(), polymorphism

    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("The animal said 'brr' ");
        }
    }
    class Cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("The Cat said 'Meow' ");
        }
    }
    class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("The Dog said 'Woof' ");
        }
    }

    //Interface = define a 'Contract' that all classes inheriting from should follow
    //            an interfaces 'what a class should have'
    //            an inheriting class defines 'how it should do it'
    //            benefit = security + multiple inheritance + 'plug-and-play'
    //            methods must not be public 
    interface IPrey
    {
         void flee();
    }
    interface IPredator
    {
         void hunt();
    }
    class Rabbit : IPrey
    {
        public void flee()
        {
            Console.WriteLine("The Rabbit run away");
        }
    }
    class Snake : IPredator
    {
        public void hunt() { 
        Console.WriteLine("The Snake is hunting for food");
        }
    }
    class Fish : IPrey,IPredator
    {
        public void hunt()
        {
            Console.WriteLine("The fish is hunting for food");

        }
        public void flee()
        {
            Console.WriteLine("The fish run away");

        }
    }
    class Player
    {
        public String username;
        public Player(string username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
    class Truck {
        //getters & setters = add security to fields by encapsulation 
        //                    they're accessors found within properties 

        //properties = combine aspects of both fields and methods (share name with a fields)
        //get accessor = used to return the property value 
        //set accessor = used to assign a new value 
        //value keyword = define the value being assigned by the set (parameter)

        private int speed;
        public Truck(int speed)
        {
            Speed = speed; 
        }
        public int Speed {
            get { return speed; }
            set {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
    class Boat { 
    // Auto-Implemented properties = shortcut when no additional logic is required in the property
    //                               you do not have to define a field for a property.
    //                               you only have to write get; end/or set; inside the property
     
        public string Model { get; set; }
        public Boat(string model){
            this.Model = model;
        }
    }

    // enums = special "class" that contains a set of named integer constants.
    //         use enums when you have values that you know will not change,
    //         To get the integer value from an item, you must explicityly convert to an int 

    //         name = integer
    enum Planets
    {
        Mercury =1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    enum PlanetsRadius
    {
        Mercury = 155,
        Venus = 26464,
        Earth = 34864,
        Mars = 44894,
        Jupiter = 5866,
        Saturn = 6486,
        Uranus = 725,
        Neptune = 8712,
        Pluto = 941
    }
}