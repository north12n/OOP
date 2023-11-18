namespace P06_Interface
{
    //ใส่สิ่งที่จะทำ ตอนตักเตอ
    //กระบวนการทำงาน = เพิ่ม แก้ไข ลบ ค้นหา
    public interface IProductManagement
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
        Product GetProductById(int productId);
        List<Product> GetProductByAny(int number, string keyword);
        void DeleteById(Product product);

    }
}
