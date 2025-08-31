namespace TinyBank.Service.Dtos.Accounts
{
    public record AccountForCreatingDto
    {
        public string Iban { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public string Destination { get; set; }
    }
}
