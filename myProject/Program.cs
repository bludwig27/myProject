using System;

namespace myProject
{
    class museum
    {
        class display
        {
            string _name;
            string _type;
            string _creator;
            static int _collection = 0;

            public display()
            {
                _name = "";
                _type = "";
                _creator = "";
            }
            public display(string name, string type, string creator)
            {
                _name = name;
                _type = type;
                _creator = creator;
            }
            public string getName()
            {
                return _name;
            }
            public string getType()
            {
                return _type;
            }
            public string getCreator()
            {
                return _creator;
            }
            public int getColl()
            {
                return _collection;
            }
            public void setCreator(string creator)
            {
                _creator = creator;
            }
            public void setType(string type)
            {
                _type= type;
            }
            public void setName(string name)
            {
                _name= name;
            }
            public void setColl()
            {
                _collection++;
            }
        }
        static void Main(string[] args)
        {
            display dis1 = new display();
            dis1.setColl();
            dis1.setName("Mona Lisa");
            dis1.setType("Painting");
            dis1.setCreator("Leonardo Da Vinci");

            display dis2 = new display();
            dis2.setColl();
            Console.WriteLine("Please enter the new museum display's name: ");
            dis2.setName((Console.ReadLine()));
            Console.WriteLine("Please enter the new display's type (sculpture, photograph, etc): ");
            dis2.setType(Console.ReadLine());
            Console.WriteLine("Please enter the new display's creator: ");
            dis2.setCreator(Console.ReadLine());

            display dis3 = new display("David", "Sculpture", "Michelangelo");
            dis3.setColl();
            Console.WriteLine();

            Console.WriteLine("Please enter another new museum display's name: ");
            string tempName = Console.ReadLine();
            Console.WriteLine("Please enter the new display's type (sculpture, photograph, etc): ");
            string tempType = Console.ReadLine();
            Console.WriteLine("Please enter the new display's creator: ");
            string tempCreator = Console.ReadLine();
            display bk4 = new display(tempName, tempType, tempCreator);
            bk4.setColl();

            Console.WriteLine();
            Console.WriteLine($"The museum contains {dis1.getColl()} displays.");
            showDisplays(dis1);
            showDisplays(dis2);
            showDisplays(dis3);
            showDisplays(bk4);
        }


        static void showDisplays(display dis)
        {
            Console.WriteLine("Current museum displays:");
            Console.WriteLine($"ID#: {dis.getName()}");
            Console.WriteLine($"Title: {dis.getType()}");
            Console.WriteLine($"Author: {dis.getCreator()}");
        }

    }
}