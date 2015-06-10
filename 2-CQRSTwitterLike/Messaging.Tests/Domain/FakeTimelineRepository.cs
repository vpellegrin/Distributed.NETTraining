using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<TimelineMessage> GetById(MessageId messageId)
        {
            return Messages.Where(x => x.MessageId.Equals(messageId)).ToList();
        }

        public void Remove(TimelineMessage timelineMessage)
        {
            Messages.Remove(timelineMessage);
        }
    }
}