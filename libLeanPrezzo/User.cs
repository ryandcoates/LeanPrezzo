using System;

namespace libLeanPrezzo
{
    public class User
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public int Votes { get; private set; }

        public User(string name, int votes)
        {
            Id = Guid.NewGuid();
            Name = name;
            Votes = votes;
        }

        public void Vote()
        {
            Votes = Votes -1;
        }
    }
}
