using CRUDoperation.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUDoperation.Repository
{
    public class ContactRepository : IContact
    {
     List<Contacts> listContact = new List<Contacts>();
     void IContact.Add(Contacts contacts)
     {
         listContact.Add(contacts);
     }
     Contacts IContact.Find(int Eid)
     {
        var contact = listContact.Where(ctr=>ctr.EmployeeID==Eid).SingleOrDefault();
        return contact;
     }
     List<Contacts> IContact.GetAll()
     {
        listContact.Add(new Contacts{
            EmployeeID = 123,
            EmployeeName = "Sakshi",
            Employeephone = 987
         });
         listContact.Add(new Contacts{
            EmployeeID = 456,
            EmployeeName = "Gupta",
            Employeephone = 654
         });
         return listContact;
     }

     void IContact.Remove(int Eid)
     {
        var contactRemove =  listContact.Where(ctr=>ctr.EmployeeID==Eid).SingleOrDefault();
        if(contactRemove!=null)
        {
            listContact.Remove(contactRemove);
        }
     }

     void IContact.Update(Contacts contacts)
     {
        var contactUpdate =  listContact.Where(ctr=>ctr.EmployeeID==Eid).SingleOrDefault();
        if(contactUpdate!=null)
        {
            contactUpdate.
        }
     }
    }
}