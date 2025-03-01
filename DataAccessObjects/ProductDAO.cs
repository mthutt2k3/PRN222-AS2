using BusinessObjects;

namespace DataAccessObjects
{
    public class ProductDAO
    {

        // Lấy danh sách tất cả sản phẩm
        public static List<Product> GetAllProducts()
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            return _context.Products.ToList();
        }

        // Lấy thông tin sản phẩm theo ID
        public static Product GetProductById(int id)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            return _context.Products.Find(id);
        }

        // Thêm sản phẩm mới
        public static void AddProduct(Product product)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // Cập nhật thông tin sản phẩm
        public static void UpdateProduct(Product product)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        // Xóa sản phẩm theo ID
        public static void DeleteProduct(int id)
        {
            Ass2SignalRRazorPagesContext _context = new Ass2SignalRRazorPagesContext();
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
