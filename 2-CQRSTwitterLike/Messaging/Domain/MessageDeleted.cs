namespace Messaging.Domain
{
    public struct MessageDeleted
    {
        private MessageId _messageId;

        public MessageDeleted(MessageId messageId)
        {
            _messageId = messageId;
        }

        public MessageId MessageId
        {
            get { return _messageId; }
        }
    }
}