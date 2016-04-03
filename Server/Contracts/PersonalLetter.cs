using Enums;

namespace Contracts
{
    public class PersonalLetter
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Company Company { get; set; }
        public User ContactPerson { get; set; }
        public int LoginCount { get; set; }
        public bool Active { get; set; }
        public Permission Permission { get; set; }
    }
}
