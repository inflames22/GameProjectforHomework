using System;
using GameProject.Abstract;

namespace GameProject.Entity
{
    public class Campaing:IEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
        public  DateTime DateOfStart { get; set; }
        public DateTime DateOfFinish { get; set; }
    }
}