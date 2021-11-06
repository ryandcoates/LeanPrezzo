﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLeanPrezzo
{
  public class Presentation
  {
    public Guid Id { get; set; }
    public string Title { get; set; }

    public string Description { get; set; }

    public int DefaultVotes { get; set; }

    public List<Topic> Topics { get; set; }

    public List<User> Participants { get; set; }

    public Presentation(Guid id, string title, string description, int defaultVotes)
    {
      Id = id;
      Title = title;
      Description = description;
      DefaultVotes = defaultVotes;
      Participants = new List<User>();
      Topics = new List<Topic>();
    }

    public void AddTopic(string topicName, string topicDescription)
    {
      Topic _topic = new Topic(topicName, topicDescription);

      this.Topics.Add(_topic);
    }
    public void AddTopic(Topic topic)
    {
      this.Topics.Add(topic);
    }

    public User AddParticipant(string name)
    {
      var participant = new User(name, this.DefaultVotes);

      this.Participants.Add(participant);

      return participant;
    }

  }
}
