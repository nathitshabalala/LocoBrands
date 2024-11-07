using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocoBrands_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // User-related operations
        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        User GetUserById(int userId);

        [OperationContract]
        bool CreateUser(string name, string surname, string password, string email, int usertype);

        [OperationContract]
        int LoginUser(string email, string password);

        [OperationContract]
        bool UpdateUser(int userId, string password, string email, int usertype);

        [OperationContract]
        bool DeleteUser(int userId);

        [OperationContract]
        bool IsManager(int userId);

        // Product-related operations
        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        Product GetProductById(int productId);

        [OperationContract]
        bool CreateProduct(string product_name, string description, string category, string brand, decimal price, int stock_quantity, string image);

        [OperationContract]
        bool UpdateProduct(int productId, string product_name, string description, string category, string brand, decimal price, int stock_quantity, string image);

        [OperationContract]
        bool DeleteProduct(int productId);

        [OperationContract]
        List<Product> GetProductByCategory(String category);

        [OperationContract]
        List<Product> GetProductByBrand(String brand);

        // ShoppingCart-related operations
        [OperationContract]
        List<ShoppingCart> GetAllShoppingCarts();

        [OperationContract]
        ShoppingCart GetShoppingCartById(int userId);

        [OperationContract]
        bool CreateShoppingCart(int userId);

        [OperationContract]
        bool UpdateShoppingCart(int cartId);

        [OperationContract]
        bool DeleteShoppingCart(int cartId);

        // Invoice-related operations
        [OperationContract]
        List<Invoice> GetAllInvoices(string userID);

        [OperationContract]
        Invoice GetInvoiceById(int invoiceId);

        [OperationContract]
        bool CreateInvoice(int userId, DateTime invoice_date, decimal total_amount, decimal tax_amount);

        [OperationContract]
        bool UpdateInvoice(int invoiceId, DateTime invoice_date, decimal total_amount, decimal tax_amount, string payment_method);

        [OperationContract]
        bool DeleteInvoice(int invoiceId);

        // CartItems-related operations
        [OperationContract]
        List<CartItem> GetCartItemsByCartId(int cartId);

        [OperationContract]
        bool AddCartItem(int cartId, int productId, int quantity);

        [OperationContract]
        bool UpdateCartItem(int cartItemId, int quantity);

        [OperationContract]
        bool RemoveCartItem(int cartItemId);

        [OperationContract]
        List<Product> GetProductsByPriceLowToHigh();

        [OperationContract]
        List<Product> GetProductsByPriceHighToLow();


    }
}
