namespace marsrover
{
  public class World
  {
    private TerrainType[,] _grid;

    public World(int rowDimension, int columnDimension)
    {
      _grid = new TerrainType[rowDimension, columnDimension];
    }
  }
}