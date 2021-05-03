using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLeanPrezzo
{
    public class Topic
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int CurrentVotes { get; private set; }

        public Topic()
        {

        }
        public Topic(string title, string description)
        {
            Title = title;
            Description = description;
            CurrentVotes = 0;
        }

        public void ApplyVote(User user)
        {
            if (user.Votes > 0){
                user.Vote();
                this.CurrentVotes++;
            }
            
        }
    }
}
