using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingLibrary
{
    public class Building
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public List<Apartment> Apartments { get; set; }

        public Building(string address, string description)
        {
            Address = address;
            Description = description;
            Apartments = new List<Apartment>();
        }
        //работу выполнила Корчагина Елизавета

        public void AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
        }
        //работу выполнила Корчагина Елизавета

        public void ShowAll()
        {
            Apartments.Sort();
            foreach (var apartment in Apartments)
            {
                apartment.Show();
            }
        }
    }
    //работу выполнила Корчагина Елизавета
    public class Apartment : IComparable
    {
        public int Number { get; set; }
        public string Owner { get; set; }
        public Apartment(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Apartment apartment = obj as Apartment;
            if (apartment != null)
            {
                return this.Number.CompareTo(apartment.Number);
            }
            else
            {
                throw new ArgumentException("Object is not an Apartment");
            }
        }
        //работу выполнила Корчагина Елизавета
        public void Show()
        {
            Console.WriteLine($"Number: {Number}, Owner: {Owner}");
        }
        //работу выполнила Корчагина Елизавета
    }
}
