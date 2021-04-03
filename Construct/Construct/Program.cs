using System;

namespace Construct
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Array_of_names = new string[10]; // declare new array and init it

            //init object 
            Building House = new Building();
            House.Name = "Gilwash";
            House.Height = 123;
            House.Width = 200;
            House.Lengthwise = 10;
            House.GetSize();
            Console.WriteLine();
        }
    }

    class Building
    {
        int width;
        int height;

        //variables which we will use when we inited object  Width , Height
        public int Width
            {
            get { return width; }
            set { width = value;  }
            }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        //short method of decloration 

        public int Lengthwise { get; set; }

        public string Name { get; set; }

        public int GetSize()
        {
            int size = width * height * Lengthwise;
            return size;
        }
    }
}
