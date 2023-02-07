using System;

namespace _06._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Notebook notebook = new Notebook("probook",2599);


            notebook.Brand = "HP";
            notebook.Model = "probook";
            notebook.Price = 2599;

            var showinfo = notebook.ShowInfo();
            Console.WriteLine(showinfo);
        }
    }
}
