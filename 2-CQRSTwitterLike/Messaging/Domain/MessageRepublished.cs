using System;

namespace Messaging.Domain
{
    public struct MessageRepublished
    {
        private readonly UserId _republisherId;
        private MessageId _messageId;

        public MessageRepublished(UserId republisherId, MessageId messageId)
        {
            _republisherId = republisherId;
            _messageId = messageId;
        }

        public MessageId MessageId
        {
            get { return _messageId; }
        }

        public UserId RepublisherId
        {
            get { return _republisherId; }
        }
    }
}