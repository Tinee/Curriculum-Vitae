using Enums;

namespace Contracts
{
    public class Technician
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        public TechnicianType Type { get; set; }
    }
}
