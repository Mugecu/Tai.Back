using Common.Entities;

namespace Tai.Authentications.Entities.ValueObjects
{
    public class TimeStamp : ValueObject<TimeStamp>
    {
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; private set; }
        public DateTime LastVisiit { get; private set; }
        public DateTime DeletedAt { get; private set; }

        protected override bool EqualsCore(TimeStamp valueObject)
            => CreatedAt == valueObject.CreatedAt 
                && UpdatedAt == valueObject.UpdatedAt
                && LastVisiit == valueObject.LastVisiit
                && DeletedAt == valueObject.DeletedAt;

        protected override int GetHashCodeCore()
            => this.GetHashCode();
    }
}
