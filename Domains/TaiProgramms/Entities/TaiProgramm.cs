using Common.Entities;
using TaiProgramms.Entities.ValueObjects;

namespace TaiProgramms.Entities
{
    public class TaiProgramm :AggregateRoot
    {
        public Title Title { get; private set; }
        public ShortDescription ShortDescription { get; private set; }
        public Description Description { get; private set; }

        public TaiProgramm(Title title, ShortDescription shortDescription, Description description)
        {            
            Title = title;
            ShortDescription = shortDescription;
            Description = description;
        }

        public void ChangeProgrammName(string title)
            => Title = new Title(title);

        public void ChangeShortDescription(string shortDescription)
            => ShortDescription = new ShortDescription(shortDescription);

        public void ChangeDescription(string description)
            => Description = new Description(description);

        // добавить монаду Options или MayBe. 
        public TaiProgramm UpdateProgramm(string title, string shortDescription, string descripton)
        {
            ChangeProgrammName(title);
            ChangeShortDescription(shortDescription);
            ChangeDescription(descripton);
            return this;
        }
    }
}
