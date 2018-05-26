namespace QTickWPF.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string LocationDescription { get; set; }
        public string LocationContact { get; set; }

        public int LocationTypeId { get; set; }
        public LocationType LocationType { get; set; }
    }
}
