using System.ComponentModel.DataAnnotations;

namespace newHouseCommittee.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public int Month { get; set; }
        public int Year { get; set; }
        public Tenant Tenant { get; set; }
    }
}
