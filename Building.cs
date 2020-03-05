using System;

namespace Planner
{
  public class Building
  {
    // public Building (int stories, double width, double depth) {
    //   Stories = stories;
    //   Width = width;
    //   Depth = depth;
    // }  
    public Building(string address)
    {
      _address = address;
      Construct();
    }

    public void Construct()
    {
      _dateConstructed = DateTime.Now;
    }
    public void Purchase(string owner)
    {
      _owner = owner;
    }

    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }

    private string _designer { get; set; }
    private DateTime _dateConstructed { get; set; }
    private string _address { get; set; }
    private string _owner { get; set; }

    public string Description
    {
      get
      {
        return _address + " has " + Stories;
      }
    }

    public double Volume
    {
      get
      {
        return 3 * Stories * Width * Depth;
      }
    }
  }
}