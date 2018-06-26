namespace PingPong
{
  public class PingPongGenerator
  {
    public bool IsPingPong(int number)
    {
      if (number % 3 == 0 && number % 5 == 0)
      {
        return true;
      }
      else if (number % 3 == 0)
      {
        return true;
      }
      else if (number % 5 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public int PingPongCounter(int number)
    {
      for(int i = 1; i <= number; i++)
      {
        IsPingPong(i);
      }
    }
  }
}
