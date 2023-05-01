using Tai.Authentications.Interfaces;

namespace Tai.Authentications.Services
{
    internal class DateTimeService : IDateTime
    {
        private readonly DateTime _dateTime;

        public DateTimeService(DateTime dateTime)
            => _dateTime = dateTime;

        public DateTime GetDateTimeService()
            => _dateTime;
    }
}
