using Common.Entities;
using System.Xml.Linq;

namespace TaiProgramms.Domain
{
    public class ShortDescription : ValueObject<ShortDescription>
    {
        public string BriefDescription { get; init; }

        public ShortDescription(string briefDescription)
        {
            BriefDescription = (string.IsNullOrEmpty(briefDescription) || string.IsNullOrWhiteSpace(briefDescription))
                ? throw new Exception("Заполните краткое описание программы.")
                : briefDescription;
        }

        protected override bool EqualsCore(ShortDescription valueObject)
            => BriefDescription == valueObject.BriefDescription;

        protected override int GetHashCodeCore()
            => BriefDescription.GetHashCode();
    }
}
