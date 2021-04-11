using System;

namespace Cells_Life
{   


    class Cell
    {
        public string name { set; get; }
        public int width { set; get; }
        public int height { set; get; }
        private bool death { set; get; }
        
        public void Kill_cell(Cell obj)
        {
            obj.name = " ";
            obj.width = 0;
            obj.height = 0;
            obj.death = true;
        }
        public void Born_cell(Cell obj)
        {   
            obj.name = name;
            obj.width = width;
            obj.height = height;
            obj.death = false;
        }
    }
    class Program
    {
        //common variables and data structures 
        int amount_of_cells;
        

        static void Main(string[] args)
        {
            Console.WriteLine("life of cells");
            Cell Antuar = new Cell();
            Antuar.name = "Antuar";
            Antuar.height = 20;
            Antuar.width =  10;
            
        }
    }
}
