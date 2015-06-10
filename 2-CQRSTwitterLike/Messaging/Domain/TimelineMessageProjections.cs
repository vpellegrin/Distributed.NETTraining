namespace Messaging.Domain
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
            _timelineMessageRepositoryFake.Save(new TimelineMessage(messagePublished.MessageId, messagePublished.AuthorId, messagePublished.PublishDate, messagePublished.AuthorId, messagePublished.Content, 0));
        }

        public void Handle(MessageRepublished messageRepublished)
        {
            foreach (var timelineMessage in _timelineMessageRepositoryFake.GetById(messageRepublished.MessageId))
            {
                _timelineMessageRepositoryFake.Remove(timelineMessage);
                timelineMessage.IncrementNbRepublish();
                _timelineMessageRepositoryFake.Save(timelineMessage);
            }
        }

        public void Handle(MessageDeleted messageDeleted)
        {

            foreach (var timelineMessage in _timelineMessageRepositoryFake.GetById(messageDeleted.MessageId))
            {
                _timelineMessageRepositoryFake.Remove(timelineMessage);
            }
        }
    }
}