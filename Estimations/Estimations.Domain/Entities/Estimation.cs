using Common.Entities;
using Estimations.Domain.Entities.ValueObjects;

namespace Estimations.Domain.Entities
{
    public class Estimation : AggregateRoot
    {
        public Guid ProgrammId { get; set; }
        internal Guid UserId { get; set; }
        internal Evaluation Evaluation { get; set; }
        internal Feedback? Feedback { get; set; }
    }
}
