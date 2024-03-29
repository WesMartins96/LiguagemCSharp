﻿using DesafioResolvido_TryCatch.Entities.Exceptions;
using System;

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
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date");
            }

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
            DateTime now = DateTime.Now;
            if (checkOut < now || checkIn < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            throw null;

        }

        public override string ToString()
        {
            return string.Format($"Reservation: Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights");
        }


    }
}
