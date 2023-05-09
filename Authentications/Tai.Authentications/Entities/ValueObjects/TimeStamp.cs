using Common.Entities;
using Tai.Authentications.Guards;

namespace Tai.Authentications.Entities.ValueObjects
{
    public class TimeStamp : ValueObject<TimeStamp>
    {
        public DateTime CreatedAt { get; }
        public DateTime? UpdatedAt { get; }
        public DateTime LastVisit { get;}
        public DateTime? DeletedAt { get;}
        private TimeStamp() { }
        internal TimeStamp(DateTime createdAt, DateTime? updatedAt, DateTime lastVisit, DateTime? deletedAt)
        {
            CreatedAt = createdAt
                .CheckForCorrectDate(updatedAt.CheckForNullInDate() , "Дата обновления меньше даты создания.")
                .CheckForCorrectDate(lastVisit, "Дата последнего визита меньше даты создания.");

            UpdatedAt = updatedAt;
            LastVisit = lastVisit;
            DeletedAt = deletedAt;
        }

        protected override bool EqualsCore(TimeStamp valueObject)
            => CreatedAt == valueObject.CreatedAt 
                && UpdatedAt == valueObject.UpdatedAt
                && LastVisit == valueObject.LastVisit
                && DeletedAt == valueObject.DeletedAt;

        protected override int GetHashCodeCore()
            => GetHashCode();

        public TimeStamp SetLastVisit(DateTime lastVisit)
            => new TimeStamp(CreatedAt,UpdatedAt,lastVisit, DeletedAt);

        public void SetUpdateAt(DateTime? updateAt)
            => new TimeStamp(CreatedAt, updateAt, LastVisit, DeletedAt);
    }
}
