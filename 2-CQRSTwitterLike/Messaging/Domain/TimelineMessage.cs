using System;

namespace Messaging.Domain
{
    public struct TimelineMessage
    {
        private readonly UserId _ownerId;
        private readonly DateTime _publishDate;
        private readonly UserId _authorId;
        private readonly string _content;
        private int _nbRepublish;

        private readonly MessageId _messageId;
        
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", _ownerId, _publishDate, _authorId, _content,
                _nbRepublish);
        }

        public TimelineMessage(MessageId messageId, UserId ownerId, DateTime publishDate, UserId authorId, string content, int nbRepublish)
        {
            _messageId = messageId;
            _ownerId = ownerId;
            _publishDate = publishDate;
            _authorId = authorId;
            _content = content;
            _nbRepublish = nbRepublish;
        }

        public MessageId MessageId
        {
            get { return _messageId; }
        }

        public UserId OwnerId
        {
            get { return _ownerId; }
        }

        public DateTime PublishDate
        {
            get { return _publishDate; }
        }

        public UserId AuthorId
        {
            get { return _authorId; }
        }

        public string Content
        {
            get { return _content; }
        }

        public int NbRepublish
        {
            get { return _nbRepublish; }
        }

        public void IncrementNbRepublish()
        {
            _nbRepublish++;
        }
    }
}