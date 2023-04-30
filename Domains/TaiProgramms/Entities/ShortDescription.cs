using Common.Entities;
using System.Xml.Linq;

namespace TaiProgramms.Entities
{
    public class ShortDescription : ValueObject<ShortDescription>
    {
        public string BriefDescription { get;}

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
