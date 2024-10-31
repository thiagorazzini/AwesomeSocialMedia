using AwesomeSocialMedia.Users.Core.Events;

namespace AwesomeSocialMedia.Users.Core.Entities
{
    public class AggregateRoot : BaseEntity
    {
        public AggregateRoot()
            :base()
        {
            Events = new List<IEvent>();
        }

        public List<IEvent> Events { get; private set; }
    }
}
