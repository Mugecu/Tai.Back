using Tai.Authentications.Interfaces;

namespace Tai.Authentications.Services
{
    public class DateTimeService : IDateTime
    {
        private readonly DateTime _dateTime;

        public DateTimeService(DateTime dateTime)
            => _dateTime = dateTime;

        public DateTime GetDateTimeService()
            => _dateTime;

        public DateTime Now()
            => DateTime.Now;
    }
}
