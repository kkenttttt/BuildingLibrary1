using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingLibrary;

namespace BuildingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Ленина, 15", "Жилой дом");
            //работу выполнила Корчагина Елизавета
            building.AddApartment(new Apartment(1, "John Doe"));
            building.AddApartment(new Apartment(2, "Jane Doe"));
            building.AddApartment(new Apartment(3, "Jim Smith"));
            building.ShowAll();
            Console.ReadKey(); //работу выполнила Корчагина Елизавета

        }
    }
}