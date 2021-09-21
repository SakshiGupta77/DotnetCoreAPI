using System;
namespace UserManagement.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AdditDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IPaddress { get; set; }
    }
}