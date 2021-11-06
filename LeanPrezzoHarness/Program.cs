using System;
using System.Text.Json;
using libLeanPrezzo;

namespace LeanPrezzoHarness
{
  class Program
  {
    static void Main(string[] args)
    {
      Presentation Prezzo = new Presentation(Guid.NewGuid(), "Test Presentation", "This is a Test Presentation", 5);

      Prezzo.AddTopic("Topic1", "Default Topic");
      Prezzo.AddTopic("Topic2", "Another Topic");

      Console.WriteLine("What is your name? ");
      string userName = Console.ReadLine();

      User user = Prezzo.AddParticipant(userName);

      Console.WriteLine("Welcome {0}, you have {1} vote(s) remaining", user.Name, user.Votes);

      Console.WriteLine("The Presentation has {0} Topics", Prezzo.Topics.Count);

      Console.WriteLine("Do you want to add a topic? if so Press (A)");
      var addTopic = Console.ReadLine();
      if (addTopic.ToString().ToUpper() == "A")
      {
        Prezzo.AddTopic("Topic3", "Yet another topic, the third in fact!");
        Console.WriteLine("The Presentation has {0} Topics", Prezzo.Topics.Count);
      }

      while (user.Votes > 0)
      {
        var option = 1;
        foreach (Topic topic in Prezzo.Topics)
        {

          Console.WriteLine("{0}) {1} - {2} with {3} votes", option, topic.Title, topic.Description, topic.CurrentVotes);
          option++;
        }

        Console.WriteLine("Enter a number to vote for a topic");
        var voteOnTopic = Console.ReadLine();
        int voteOnTopicInt = Convert.ToInt32(voteOnTopic);

        Prezzo.Topics[voteOnTopicInt - 1].ApplyVote(user);
        Console.WriteLine("You have {0} votes left, {1}", user.Votes, user.Name);
      }

      Console.WriteLine(JsonSerializer.Serialize(Prezzo));

    }
  }
}
