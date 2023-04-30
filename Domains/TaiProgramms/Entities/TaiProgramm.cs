using Common.Entities;

namespace TaiProgramms.Entities
{
    public class TaiProgramm : Entity
    {
        public Title Title { get; private set; }
        public ShortDescription ShortDescription { get; private set; }
        public Description Description { get; private set; }

    }
}
