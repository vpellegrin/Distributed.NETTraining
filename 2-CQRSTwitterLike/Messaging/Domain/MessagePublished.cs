using System;
using Messaging.Domain;

namespace Messaging.Tests.Domain
{
    public struct MessagePublished
    {
        private UserId _authorId;
        private DateTime _publishDate;
        private string _content;

        public MessagePublished(UserId authorId, DateTime publishDate, string content)
        {
            _authorId = authorId;
            _publishDate = publishDate;
            _content = content;
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