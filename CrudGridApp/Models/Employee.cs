namespace CrudGridApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Position { get; set; }

        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Total => Quantity * Rate;

    }
}
