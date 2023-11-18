namespace P06_Interface
{
    //ใส่สิ่งที่จะทำ ตอนตักเตอ
    public interface IProductManagement
    {
        void AddProduct(Product product);
        List<Product> GetProducts();

    }
}
