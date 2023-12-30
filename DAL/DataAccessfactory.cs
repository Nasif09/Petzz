using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;

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
    }
}
