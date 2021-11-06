using System;
using System.Collections.Generic;

namespace libLeanPrezzo
{
  public class PresentationSession
  {
    public Guid Id { get; set; }
    public string SessionKey { get; set; }
    public Guid PresentationId { get; set; }
    public Presentation Presentation { get; set; }
    public List<Participant> Participants { get; set; }

    public Participant AddParticipant(string name)
    {
      var participant = new Participant(name, this.Presentation.DefaultVotes);

      this.Participants.Add(participant);

      return participant;
    }
  }
}