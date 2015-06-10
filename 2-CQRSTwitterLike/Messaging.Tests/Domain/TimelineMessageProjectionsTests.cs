using System;
using Messaging.Domain;
using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageProjectionsTests
    {
        [Test]
        public void WhenHandleMessagePublished_ThenTimelineMessageIsSavedForAuthor()
        {
            var messageId = MessageId.Generate();
            var authorId = new UserId("cb@plip.com");
            var publishDate = DateTime.Now;
            var content = "hello world";
            var messagePublished = new MessagePublished(messageId, authorId, publishDate, content);
            // FakeTimelineRepository is a fake implementation of interface for tests purpose only -> keep it in test assembly
            var timelineMessageRepositoryFake = new FakeTimelineRepository();
            var timelineMessageProjections = new TimelineMessageProjections(timelineMessageRepositoryFake);

            timelineMessageProjections.Handle(messagePublished);

            var expectedTimelineMessage = new TimelineMessage(messageId, authorId, publishDate, authorId, content, 0);
            Check.That(timelineMessageRepositoryFake.Messages).ContainsExactly(expectedTimelineMessage);
        }

        [Test]
        public void GivenExisingTimelineMessage_WhenHandleMessageRepublished_ThenTimelineMessageNbRepublishIsIncremented()
        {
            var authorId = new UserId();
            var publishDate = DateTime.Now;
            var content = "hello world";
            var messageId = MessageId.Generate();
            var existingTimelineMessage = new TimelineMessage(messageId, authorId, publishDate, authorId, content, 0);
            var timelineMessageRepositoryFake = new FakeTimelineRepository();
            timelineMessageRepositoryFake.Messages.Add(existingTimelineMessage);
            var timelineMessageProjections = new TimelineMessageProjections(timelineMessageRepositoryFake);
            var republisherId = new UserId("cb@plip.com");
            var messageRepublished = new MessageRepublished(republisherId, messageId);

            timelineMessageProjections.Handle(messageRepublished);

            var expectedTimelineMessage = new TimelineMessage(messageId, authorId, publishDate, authorId, content, 1);
            Check.That(timelineMessageRepositoryFake.Messages).ContainsExactly(expectedTimelineMessage);
        }
    }
}
