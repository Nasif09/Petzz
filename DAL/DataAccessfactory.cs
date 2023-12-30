using DAL.Interfaces;
using DAL.Models;
using DAL.Models.Shop;
using DAL.Repos;
using DAL.Repos.Shop;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Branch, int, bool> BranchData()
        {
            return new BranchRepo();
        }

        public static IRepo<Room, int, bool> RoomData()
        {
            return new RoomRepo();
        }

        public static IRepo<Registration, int, bool> RegistrationData()
        {
            return new RegistrationRepo();
        }


        public static IRepo<Category, int, bool> CategoryData()
        {
            return new CategoryRepo();
        }

        public static IRepo<Product, int, bool> ProductData()
        {
            return new ProductRepo();
        }

        public static IRepo<Order, int, bool> OrderData()
        {
            return new OrderRepo();
        }

        public static IRepo<Order_status, int, bool> OrderStatusData() {
         return new Order_statusRepo();
        
        }







    }
}
