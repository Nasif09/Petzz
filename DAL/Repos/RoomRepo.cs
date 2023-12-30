using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RoomRepo : Repo, IRepo<Room, int, bool>
    {
        public bool Create(Room obj)
        {
            db.Rooms.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Rooms.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Room> Read()
        {
            return db.Rooms.ToList();
        }

        public Room Read(int id)
        {
            return db.Rooms.Find(id);
        }

        public bool Update(Room obj)
        {
            var ex = Read(obj.RoomID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

