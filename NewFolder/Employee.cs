using System;
namespace Storage_App.NewFolder
{
    public class Employee : EntityBase
    {
     // public int Id { get; set; }
        public string? Fullname { get; set; }

        public override string ToString()=> $"Employee Id: {Id}\tFull Name:{Fullname}";
    }
}
