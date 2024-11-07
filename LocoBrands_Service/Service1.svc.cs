using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocoBrands_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public bool AddCartItem(int cartId, int productId, int quantity)
        {
            try
            {
                // Create a new CartItem entity
                var newCartItem = new CartItem
                {
                    cart_id = cartId,
                    product_id = productId,
                    quantity = quantity
                };

                // Add the new CartItem to the database
                db.CartItems.InsertOnSubmit(newCartItem);

                // Save changes to the database
                db.SubmitChanges();

                // Return the cartitem_id of the newly created cart item
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                // Handle exceptions, log errors, etc.
                return false; // Return a negative value to indicate failure
            }
        }

        public bool CreateInvoice(int userId, DateTime invoice_date, decimal total_amount, decimal tax_amount)
        {
            try
            {
                // Create a new Invoice entity
                var newInvoice = new Invoice
                {
                    user_id = userId,
                    invoice_date = invoice_date,
                    total_amount = total_amount,
                    tax_amount = tax_amount
                };

                // Add the new Invoice to the database
                db.Invoices.InsertOnSubmit(newInvoice);

                // Save changes to the database
                db.SubmitChanges();

                // Return the invoice_id of the newly created invoice
                return true;
            }
            catch (Exception ex)
            {

                // Handle exceptions, log errors, etc.
                ex.GetBaseException();
                return false; // Return a negative value to indicate failure
            }
        }


        public Product GetProductById(int productId)
        {
            var originalProduct = db.Products.SingleOrDefault(p => p.product_id == productId);

            if (originalProduct != null)
            {
                // Create a copy of the product entity
                var productCopy = new Product
                {
                    product_id = originalProduct.product_id,
                    product_name = originalProduct.product_name,
                    description = originalProduct.description,
                    price = originalProduct.price,
                    stock_quantity = originalProduct.stock_quantity,
                    category = originalProduct.category,
                    brand = originalProduct.brand,
                    image = originalProduct.image
                };

                return productCopy;
            }

            return null; // Product not found
        }


        public ShoppingCart GetShoppingCartById(int userId)
        {
            var originalShoppingCart = db.ShoppingCarts.SingleOrDefault(cart => cart.user_id == userId);

            if (originalShoppingCart != null)
            {
                // Create a copy of the shopping cart entity
                var shoppingCartCopy = new ShoppingCart
                {
                    cart_id = originalShoppingCart.cart_id,
                    user_id = originalShoppingCart.user_id,
                };

                return shoppingCartCopy;
            }

            return null; // Shopping cart not found
        }


        public User GetUserById(int userId)
        {
            var originalUser = db.Users.SingleOrDefault(u => u.user_id == userId);

            if (originalUser != null)
            {
                // Create a copy of the user entity
                var userCopy = new User
                {
                    user_id = originalUser.user_id,
                    password = originalUser.password,
                    email = originalUser.email,
                    usertype = originalUser.usertype,
                    name = originalUser.name,
                    surname = originalUser.surname
                };

                return userCopy;
            }

            return null; // User not found
        }


        //Method for checking if the user is a manager
        public bool IsManager(int userId)
        {
            var systemUser = (from u in db.Users where u.user_id.Equals(userId) select u).FirstOrDefault();

            int manager = 2;

            if (systemUser != null)
            {
                if (manager.Equals(systemUser.usertype))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }

        public int LoginUser(string email, string password)
        {
            var sysUser = (from s in db.Users
                           where s.email.Equals(email) && s.password.Equals(password)
                           select s).FirstOrDefault();

            if (sysUser != null)
            {
                return sysUser.user_id;

            }
            else
            {
                return 0;
            }
        }

        public bool RemoveCartItem(int cartItemId)
        {
            var cartItemToRemove = db.CartItems.SingleOrDefault(item => item.cartitem_id == cartItemId);

            if (cartItemToRemove != null)
            {
                db.CartItems.DeleteOnSubmit(cartItemToRemove);
                db.SubmitChanges(); // Save changes to the database
                return true; // Removal successful
            }

            return false; // Cart item not found
        }


        public bool UpdateCartItem(int cartItemId, int quantity)
        {
            var cartItemToUpdate = db.CartItems.SingleOrDefault(item => item.cartitem_id == cartItemId);

            if (cartItemToUpdate != null)
            {
                // Update the cart item quantity
                cartItemToUpdate.quantity = quantity;
                db.SubmitChanges(); // Save changes to the database
                return true; // Update successful
            }

            return false; // Cart item not found
        }


        public bool UpdateInvoice(int invoiceId, DateTime invoice_date, decimal total_amount, decimal tax_amount, string payment_method)
        {
            var invoiceToUpdate = db.Invoices.SingleOrDefault(inv => inv.invoice_id == invoiceId);

            if (invoiceToUpdate != null)
            {
                // Update the invoice properties
                invoiceToUpdate.invoice_date = invoice_date;
                invoiceToUpdate.total_amount = total_amount;
                invoiceToUpdate.tax_amount = tax_amount;
                db.SubmitChanges(); // Save changes to the database
                return true; // Update successful
            }

            return false; // Invoice not found
        }


        public bool UpdateProduct(int productId, string product_name, string description, string category, string brand, decimal price, int stock_quantity, string image)
        {
            var productToUpdate = db.Products.SingleOrDefault(p => p.product_id == productId);

            if (productToUpdate != null)
            {
                // Update the product properties
                productToUpdate.product_name = product_name;
                productToUpdate.description = description;
                productToUpdate.category = category;
                productToUpdate.brand = brand;
                productToUpdate.price = price;
                productToUpdate.stock_quantity = stock_quantity;
                productToUpdate.image = image;

                db.SubmitChanges(); // Save changes to the database
                return true; // Update successful
            }

            return false; // Product not found
        }

        public bool UpdateShoppingCart(int cartId)
        {
            var shoppingCartToUpdate = db.ShoppingCarts.SingleOrDefault(cart => cart.cart_id == cartId);

            if (shoppingCartToUpdate != null)
            {
                // Update the shopping cart 

                db.SubmitChanges(); // Save changes to the database
                return true; // Update successful
            }

            return false; // Shopping cart not found
        }

        public bool UpdateUser(int userId, string password, string email, int usertype)
        {
            var userToUpdate = db.Users.SingleOrDefault(u => u.user_id == userId);

            if (userToUpdate != null)
            {
                // Update the user properties
                userToUpdate.password = password;
                userToUpdate.email = email;
                userToUpdate.usertype = usertype;

                db.SubmitChanges(); // Save changes to the database
                return true; // Update successful
            }

            return false; // User not found
        }

        //Method for creating a product
        public bool CreateProduct(string product_name, string description, string category, string brand, decimal price, int stock_quantity, string image)
        {
            var systemProduct = (from p in db.Products where p.product_name.Equals(product_name) select p).FirstOrDefault();

            if (systemProduct == null)
            {
                var addProduct = new Product
                {
                    product_name = product_name,
                    description = description,
                    category = category,
                    brand = brand,
                    price = price,
                    stock_quantity = stock_quantity,
                    image = image
                };

                db.Products.InsertOnSubmit(addProduct);

                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool CreateShoppingCart(int userId)
        {
            try
            {
                // Create a new ShoppingCart entity
                var newShoppingCart = new ShoppingCart
                {
                    user_id = userId
                };

                // Add the new ShoppingCart to the database
                db.ShoppingCarts.InsertOnSubmit(newShoppingCart);

                // Save changes to the database
                db.SubmitChanges();

                // Success
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                // Handle exceptions, log errors, etc.
                return false; // Return 0 value to indicate failure
            }
        }


        //Method for creating a user
        public bool CreateUser(string name, string surname, string password, string email, int usertype)
        {
            var newUser = new User
            {
                name = name,
                surname = surname,
                password = password,
                email = email,
                usertype = usertype
            };

            db.Users.InsertOnSubmit(newUser);
            try
            {
                db.SubmitChanges();
                CreateShoppingCart(newUser.user_id);
                return true;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }

        }

        public bool DeleteInvoice(int invoiceId)
        {
            var invoiceToDelete = db.Invoices.SingleOrDefault(inv => inv.invoice_id == invoiceId);

            if (invoiceToDelete != null)
            {
                db.Invoices.DeleteOnSubmit(invoiceToDelete);
                db.SubmitChanges(); // Save changes to the database
                return true; // Deletion successful
            }

            return false; // Invoice not found
        }


        public bool DeleteProduct(int productId)
        {
            var productToDelete = db.Products.SingleOrDefault(p => p.product_id == productId);

            if (productToDelete != null)
            {
                db.Products.DeleteOnSubmit(productToDelete);
                db.SubmitChanges(); // Save changes to the database
                return true; // Deletion successful
            }

            return false; // Product not found
        }


        public bool DeleteShoppingCart(int cartId)
        {
            var shoppingCartToDelete = db.ShoppingCarts.SingleOrDefault(cart => cart.cart_id == cartId);

            if (shoppingCartToDelete != null)
            {
                db.ShoppingCarts.DeleteOnSubmit(shoppingCartToDelete);
                db.SubmitChanges(); // Save changes to the database
                return true; // Deletion successful
            }

            return false; // Shopping cart not found
        }


        public bool DeleteUser(int userId)
        {
            var userToDelete = db.Users.SingleOrDefault(u => u.user_id.Equals(userId));

            if (userToDelete != null)
            {
                db.Users.DeleteOnSubmit(userToDelete);
                db.SubmitChanges(); // Save changes to the database
                return true; // Deletion successful
            }

            return false; // User not found
        }


        public List<Invoice> GetAllInvoices(string userID)
        {
            
            dynamic invoices = (from i in db.Invoices where i.user_id.Equals(userID) select i).DefaultIfEmpty();
            List<Invoice> invoicesCopy = new List<Invoice>();

            if (invoices != null)
            {
                foreach (Invoice v in invoices)
                {
                    var newinvoice = new Invoice
                    {
                        invoice_id = v.invoice_id,
                        user_id = v.user_id,
                        invoice_date = v.invoice_date,
                        total_amount = v.total_amount,
                        tax_amount = v.tax_amount,
                    };

                    invoicesCopy.Add(newinvoice);
                }

                return invoicesCopy;
            }
            else
            {
                return null;
            }
        }


        public List<Product> GetAllProducts()
        {
            List<Product> productsCopy = new List<Product>();

            foreach (var originalProduct in db.Products.ToList())
            {
                var productCopy = new Product
                {
                    product_id = originalProduct.product_id,
                    product_name = originalProduct.product_name,
                    description = originalProduct.description,
                    brand = originalProduct.brand,
                    image = originalProduct.image,
                    price = originalProduct.price,
                    stock_quantity = originalProduct.stock_quantity,
                    category = originalProduct.category,
                };

                productsCopy.Add(productCopy);
            }

            return productsCopy;
        }


        public List<ShoppingCart> GetAllShoppingCarts()
        {
            List<ShoppingCart> shoppingCartsCopy = new List<ShoppingCart>();

            foreach (var originalCart in db.ShoppingCarts.ToList())
            {
                var cartCopy = new ShoppingCart
                {
                    cart_id = originalCart.cart_id,
                    user_id = originalCart.user_id,
                };

                shoppingCartsCopy.Add(cartCopy);
            }

            return shoppingCartsCopy;
        }


        public List<User> GetAllUsers()
        {
            List<User> usersCopy = new List<User>();

            foreach (var originalUser in db.Users.ToList())
            {
                var userCopy = new User
                {
                    user_id = originalUser.user_id,
                    password = originalUser.password,
                    email = originalUser.email,
                    name = originalUser.name,
                    surname = originalUser.surname,
                    usertype = originalUser.usertype,
                };

                usersCopy.Add(userCopy);
            }

            return usersCopy;
        }


        public List<CartItem> GetCartItemsByCartId(int cartId)
        {
            List<CartItem> cartItemsCopy = new List<CartItem>();

            foreach (var originalCartItem in db.CartItems.Where(ci => ci.cart_id == cartId).ToList())
            {
                var cartItemCopy = new CartItem
                {
                    cartitem_id = originalCartItem.cartitem_id,
                    cart_id = originalCartItem.cart_id,
                    product_id = originalCartItem.product_id,
                    quantity = originalCartItem.quantity
                };

                cartItemsCopy.Add(cartItemCopy);
            }

            return cartItemsCopy;
        }


        public Invoice GetInvoiceById(int invoiceId)
        {

            var originalInvoice = db.Invoices.SingleOrDefault(inv => inv.invoice_id == invoiceId);

            if (originalInvoice != null)
            {
                // Create a copy of the invoice entity
                var invoiceCopy = new Invoice
                {
                    invoice_id = originalInvoice.invoice_id,
                    user_id = originalInvoice.user_id,
                    invoice_date = originalInvoice.invoice_date,
                    total_amount = originalInvoice.total_amount,
                    tax_amount = originalInvoice.tax_amount,
                };

                return invoiceCopy;
            }

            return null; // Invoice not found
        }

        public List<Product> GetProductByCategory(string category)
        {
            //Create a list of products
            var prods = new List<Product>();

            var sysProduct = (from s in db.Products where
                             s.category.Equals(category) select s).DefaultIfEmpty();
		
		    //For each user in 
		    //Create a filtered user
		    foreach(Product p in sysProduct)
            {
                var filteredProd = new Product
                {
                    product_id = p.product_id,
                    product_name = p.product_name,
                    description = p.description,
                    brand = p.brand,
                    image = p.image,
                    price = p.price,
                    stock_quantity = p.stock_quantity,
                    category = p.category,

                };

                prods.Add(filteredProd);
            }

            return prods;
        }

        public List<Product> GetProductByBrand(string brand)
        {
            // Use LINQ to retrieve products matching the specified brand
            var productsQuery = (from p in db.Products
                                 where p.brand.Equals(brand)
                                 select new
                                 {
                                     p.product_id,
                                     p.product_name,
                                     p.description,
                                     p.brand,
                                     p.image,
                                     p.price,
                                     p.stock_quantity,
                                     p.category
                                 }).ToList();

            // Convert the anonymous type to a list of Product objects
            var products = productsQuery
                .Select(p => new Product
                {
                    product_id = p.product_id,
                    product_name = p.product_name,
                    description = p.description,
                    brand = p.brand,
                    image = p.image,
                    price = p.price,
                    stock_quantity = p.stock_quantity,
                    category = p.category
                })
                .ToList();

            return products;
        }


        public List<Product> GetProductsByPriceLowToHigh()
        {
            // Use LINQ to retrieve products sorted by price in ascending order (low to high)
            var productsQuery = (from p in db.Products
                                 orderby p.price
                                 select new
                                 {
                                     p.product_id,
                                     p.product_name,
                                     p.description,
                                     p.brand,
                                     p.image,
                                     p.price,
                                     p.stock_quantity,
                                     p.category
                                 }).ToList();

            // Convert the anonymous type to a list of Product objects
            var products = productsQuery
                .Select(p => new Product
                {
                    product_id = p.product_id,
                    product_name = p.product_name,
                    description = p.description,
                    brand = p.brand,
                    image = p.image,
                    price = p.price,
                    stock_quantity = p.stock_quantity,
                    category = p.category
                })
                .ToList();

            return products;
        }

        public List<Product> GetProductsByPriceHighToLow()
        {
            // Use LINQ to retrieve products sorted by price in descending order (high to low)
            var productsQuery = (from p in db.Products
                                 orderby p.price descending
                                 select new
                                 {
                                     p.product_id,
                                     p.product_name,
                                     p.description,
                                     p.brand,
                                     p.image,
                                     p.price,
                                     p.stock_quantity,
                                     p.category
                                 }).ToList();

            // Convert the anonymous type to a list of Product objects
            var products = productsQuery
                .Select(p => new Product
                {
                    product_id = p.product_id,
                    product_name = p.product_name,
                    description = p.description,
                    brand = p.brand,
                    image = p.image,
                    price = p.price,
                    stock_quantity = p.stock_quantity,
                    category = p.category
                })
                .ToList();

            return products;
        }

    }
}
