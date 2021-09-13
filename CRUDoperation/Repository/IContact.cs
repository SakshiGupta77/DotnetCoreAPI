using CRUDoperation.Models;
using System.Collections.Generic;
namespace CRUDoperation.Repository
{
    public interface IContact
    {
        void Add(Contacts contacts);
        List<Contacts> GetAll();
        Contacts Find(int Eid);
        void Update(Contacts contacts);
        void Remove(int Eid);
    }
}