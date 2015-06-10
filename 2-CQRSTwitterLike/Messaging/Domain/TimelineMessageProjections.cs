using Messaging.Domain;

namespace Messaging.Tests.Domain
{
    public class TimelineMessageProjections
    {
        private readonly ITimelineMessageRepository _timelineMessageRepositoryFake;

        public TimelineMessageProjections(ITimelineMessageRepository timelineMessageRepositoryFake)
        {
            _timelineMessageRepositoryFake = timelineMessageRepositoryFake;
        }

        public void Handle(MessagePublished messagePublished)
        {
            _timelineMessageRepositoryFake.Save(new TimelineMessage(messagePublished.AuthorId, messagePublished.PublishDate, messagePublished.AuthorId, messagePublished.Content, 0));
        }
    }
}