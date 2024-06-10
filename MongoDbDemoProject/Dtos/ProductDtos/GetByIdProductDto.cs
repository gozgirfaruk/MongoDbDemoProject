namespace MongoDbDemoProject.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
