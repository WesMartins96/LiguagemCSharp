using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioResolvido_TryCatch.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservation()
        {
            
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //pegamos a duracao entre a entrada(checkIn) e a saida(CheckOut)
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

        }

        public override string ToString()
        {
            return string.Format($"Reservation: Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights");
        }


    }
}
