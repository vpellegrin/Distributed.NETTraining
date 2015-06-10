using System;

namespace Messaging.Domain
{
    public struct MessageId
    {
        private readonly string _id;

        public MessageId(string id)
        {
            _id = id;
        }

        public static MessageId Generate()
        {
            return new MessageId(Guid.NewGuid().ToString());
        }
    }
}