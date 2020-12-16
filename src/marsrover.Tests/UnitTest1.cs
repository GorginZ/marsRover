using System;
using marsrover;
using Xunit;

namespace marsrover.Tests
{
  public class UnitTest1
  {
    [Fact]
    public void WorldOfTraversableTerrain()
    {
      var world = new World(10, 12);
    }
  }
}
