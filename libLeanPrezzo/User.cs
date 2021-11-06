using System;

namespace libLeanPrezzo
{
  public class User
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
  }

  public class Participant : User
  {
    public Participant(string name, int defaultVotes)
    {
      Id = Guid.NewGuid();
      Name = name;
      DefaultVotes = defaultVotes;
    }

    public int Votes { get; private set; } = 5;
    public int DefaultVotes { get; }

    public void Vote()
    {
      Votes = Votes - 1;
    }
  }
}
