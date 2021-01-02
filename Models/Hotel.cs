using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
namespace Hotel.Models
{
    public class Hotel
    {
        public int HotelID { set; get; }
        public string HotelName { set; get; }
        public string location { set ; get; }
        public float ratings { set; get; }

        public Hotel(int HotelID,string HotelName,string location,float ratings)
        {
            this.HotelID = HotelID;
            this.HotelName = HotelName;
            this.location = location;
            this.ratings = ratings;
        }
        public class HotelDBContext : DbContext
        {
            public HotelDBContext()
            { }
            public DbSet<Hotel> Hotels { get; set; }

        }

    }
}
