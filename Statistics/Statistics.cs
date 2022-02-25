using System;
using System.Collections.Generic;

namespace Statistics
{
  public class StatsComputer
  {
    public Stats CalculateStatistics(List<float> numbers)
    {
      Stats objStats=new Stats();
      objStats.average=numbers.average()
      objStats.max = numbers.max();
      objStats.min = numbers.min();
      return objStats
    }
  }
  public class Stats
  {
    private double average;
    private double max;
    private double min;

  }
}
