using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using DAL.Repos.Hostel;

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
        public static IAuth<bool> AuthData()
        {
            return new RegistrationRepo();
        }
        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
        public static IRepo<Booking, int, bool> BookingData()
        {
            return new BookingRepo();
        }
    }
}
