using System;

namespace Messaging.Domain
{
    public struct MessagePublished
    {
        private readonly MessageId _messageId;
        private UserId _authorId;
        private DateTime _publishDate;
        private string _content;

        public MessagePublished(MessageId messageId, UserId authorId, DateTime publishDate, string content)
        {
            _messageId = messageId;
            _authorId = authorId;
            _publishDate = publishDate;
            _content = content;
        }

        public MessageId MessageId
        {
            get { return _messageId; }
        }

        public UserId AuthorId
        {
            get { return _authorId; }
        }

        public DateTime PublishDate
        {
            get { return _publishDate; }
        }

        public string Content
        {
            get { return _content; }
        }
    }
}