using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            Building nss = new Building("301 Plus Park Ave")
            {
                Width = 250,
                Depth = 250,
                Stories = 5
            };

            nss.Construct();
            nss.Purchase("Steve");
            // Console.WriteLine (nss.ToString ());

            Building oldNSS = new Building("500 Interstate Blvd S");
            oldNSS.Width = 150;
            oldNSS.Depth = 150;
            oldNSS.Stories = 3;

            oldNSS.Construct();
            oldNSS.Purchase("John");
            // Console.WriteLine (oldNSS.ToString ());

            Building house = new Building("1201 First Str")
            {
                Width = 100,
                Depth = 100,
                Stories = 1
            };

            house.Construct();
            house.Purchase("Mom");
            // Console.WriteLine (house.ToString ());

            City nashville = new City("Nashville", 1800, "John Cooper");

            nashville.AddCityBuilding(nss);
            nashville.AddCityBuilding(oldNSS);
            nashville.AddCityBuilding(house);

            Console.WriteLine($"City: {nashville.CityName}, Mayor: {nashville.MayorName}, Established: {nashville.Year}. City buildings: ");
            foreach (Building building in nashville.CityBuildings)
            {
                Console.WriteLine(building.ToString());
            }

        }
    }
}