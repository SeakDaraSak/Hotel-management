using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLib.Extensions
{
    public static class ProductExtensions
    {
        public static BookingResponse ToResponse(this Booking Bk)
        {
            return new BookingResponse()
            {
                Id = Bk.Id,
                fullName = Bk.fullName,
                Gender=Bk.Gender,
                Phone = Bk.Phone,
                RoomNo= Bk.RoomNo,
                RoomType=Bk.RoomType,
                Date= Bk.Date,
            };
        }
        public static Booking ToEntity(this BookingCreateReq req)
        {
            return new Booking()
            {
                Id = Guid.NewGuid().ToString(),
                fullName = req.fullName,
                Gender= req.Gender,
                Phone = req.Phone,
                RoomNo = req.RoomNo,
                RoomType=req.RoomType,
                Date= req.Date,
            };
        }
        public static void Copy(this Booking Bk, BookingUpdateReq req)
        {
            Bk.fullName =  req.fullName;
            Bk.Gender=req.Gender;
            Bk.Phone = req.Phone;
            Bk.RoomNo= req.RoomNo;
            Bk.RoomType=req.RoomType;
            Bk.Date= req.Date;
        }
        public static Booking Clone(this Booking Bk)
        {
            return new Booking()
            {
                Id = Bk.Id,
                fullName = Bk.fullName,
                Gender = Bk.Gender,
                Phone = Bk.Phone,
                RoomNo= Bk.RoomNo,
                RoomType=Bk.RoomType,
                Date= Bk.Date,
            };
        }
        public static void Copy(this Booking Bk, Booking other)
        {
            Bk.Id = other.Id;
            Bk.fullName = other.fullName;
            Bk.Gender = other.Gender;
            Bk.Phone = other.Phone;
            Bk.RoomNo = other.RoomNo;
            Bk.RoomType= other.RoomType;
            Bk.Date = other.Date;
        }
    }
}
