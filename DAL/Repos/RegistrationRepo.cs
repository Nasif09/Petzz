using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RegistrationRepo : Repo, IRepo<Registration, int, bool>
    {
        public bool Create(Registration obj)
        {
            db.Registrations.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Registrations.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Registration> Read()
        {
            return db.Registrations.ToList();
        }

        public Registration Read(int id)
        {
            return db.Registrations.Find(id);
        }

        public bool Update(Registration obj)
        {
            var ex = Read(obj.UID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
