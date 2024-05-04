namespace JWTTokenAuthenicationProj.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int VendorId { get; set; }
    }
}
