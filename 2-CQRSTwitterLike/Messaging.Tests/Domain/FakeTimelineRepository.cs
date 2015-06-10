using System.Collections.Generic;
using Messaging.Domain;

namespace Messaging.Tests.Domain
{
    public class FakeTimelineRepository : ITimelineMessageRepository
    {
        public List<TimelineMessage> Messages = new List<TimelineMessage>();

        public IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i)
        {
            throw new System.NotImplementedException();
        }

        public void Save(TimelineMessage timelineMessage)
        {
            Messages.Add(timelineMessage);
        }
    }
}