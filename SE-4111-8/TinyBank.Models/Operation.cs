namespace TinyBank.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public OperationType OperationType { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public DateTime HappendAt { get; set; }
    }
}
