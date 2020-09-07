namespace LeaderboardPro.Data
{
    public class Address
    {
        public long Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
