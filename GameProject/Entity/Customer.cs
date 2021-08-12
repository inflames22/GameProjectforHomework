using System;
using GameProject.Abstract;

namespace GameProject.Entity
{
  public  class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        
    }
}