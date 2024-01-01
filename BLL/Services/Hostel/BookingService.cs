using AutoMapper;
using BLL.DTOs;
using BLL.DTOs.Hostel;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Hostel
{
    public class BookingService
    {

        public static List<BookingDTO> Get()
        {
            var data = DataAccessFactory.BookingData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<BookingDTO>>(data);
        }
        public static List<RoomDTO> Checkavailability(CheckAvailabilityDTO c)
        {
            var data = DataAccessFactory.BranchData().Read();
            var locationData = data.Where(d => d.Branchname.Equals(c.Branchname)).SingleOrDefault();
            //var roomData = locationData.SelectMany(l=> l.Rooms).ToList();
            var roomData = DataAccessFactory.RoomData().Read().Where(d => d.BranchID.Equals(locationData.BranchID)).ToList();
            var Bookingdata = new List<Room>();

            foreach (var room in roomData)
            {
                bool flag = true;
                foreach (var booking in room.Bookings)
                {

                    if (

                        (booking.StartDate <= c.StartDate && booking.EndDate >= c.StartDate)

                        || (booking.StartDate <= c.EndDate && booking.EndDate >= c.EndDate)

                        || (booking.StartDate >= c.StartDate && booking.EndDate <= c.EndDate)
                    )
                    {
                        flag = false;
                    }

                }
                if (flag)
                {
                    Bookingdata.Add(room);
                }
            }
            if (roomData.Count == 0)
            {
                return null;
            }
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Room, RoomDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<RoomDTO>>(Bookingdata);
        }

        public static bool Add(BookingDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BookingDTO, Booking>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Booking>(c);
            return DataAccessFactory.BookingData().Create(data);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.BookingData().Delete(id);
        }
        public static bool Update(int id, BookingDTO updatedBooking)
        {
            var bookingToUpdate = DataAccessFactory.BookingData().Read(id);

            if (bookingToUpdate != null)
            {
                bookingToUpdate.RoomID = updatedBooking.RoomID;
                bookingToUpdate.StartDate = updatedBooking.StartDate;
                bookingToUpdate.EndDate = updatedBooking.EndDate;
                return DataAccessFactory.BookingData().Update(bookingToUpdate);
            }

            return false;
        }

    }
}
