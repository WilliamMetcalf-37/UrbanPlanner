using System;
using System.Collections.Generic;
namespace Planner
{

  public class City
  {

    public City(string cityName, int year, string mayorName)
    {
      CityName = cityName;
      Year = year;
      MayorName = mayorName;
    }

    public int Year { get; private set; }
    public string CityName { get; private set; }
    public string MayorName { get; private set; }

    public List<Building> CityBuildings { get; private set; } = new List<Building>();

    public void AddCityBuilding(Building building)
    {
      CityBuildings.Add(building);
    }

  }
}