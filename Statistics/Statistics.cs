using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
  public class StatsComputer:Stats
  {
    
    public Stats CalculateStatistics(List<double> numbers)
    {
      Stats s = new Stats();
      if (numbers.Count > 0)
      {
      
        average = numbers.Average();
        max = numbers.Max();
        min = numbers.Min();
      }
     
     return s;
    }
  }
  public class Stats
  {
   public double average=Double.NaN;
   public double max= Double.NaN;
   public double min= Double.NaN;

  }
  public interface IAlerter
  {
    void Alert();
  }
  public class EmailAlert : IAlerter
  {
    public bool emailSent = false;


    public void Alert()
    {
      emailSent = true;
    }
  }

  public class LEDAlert : IAlerter
  {
    public bool ledGlows = false;
    public void Alert()
    {
      ledGlows = true;
    }
  }

 
  public class StatsAlerter
  {
    private double threshold;
    private IAlerter[] alerters;

   public StatsAlerter(double maxThreshold,IAlerter[] alerter)
   {
     threshold = maxThreshold;
     alerters = alerter;

   }
   public void checkAndAlert(List<double> numbers)
    {
      if (numbers.Max() > threshold)
      {
        foreach (var alert in alerters)
        {
          alert.Alert();

        }
      }
    }
  }
}
