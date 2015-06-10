using System.Collections.Generic;

namespace Messaging.Domain
{
    public interface ITimelineMessageRepository
    {
        IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i);
        
        void Save(TimelineMessage timelineMessage);
        
        IEnumerable<TimelineMessage> GetById(MessageId messageId);
        
        void Remove(TimelineMessage timelineMessage);
    }
}