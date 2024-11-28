namespace SafeKittens.Controllers.Godparents.Contracts
{
    public class GodparentRequest
    {
        public string Name { get; set; }
        public string ChosenShelterName { get; set; }
        public string PhoneNumber { get; set; }
        public int SponsoredKittens { get; set; }
        public decimal AmountDonated { get; set; }
        public bool IsActive { get; set; }
    }
}
