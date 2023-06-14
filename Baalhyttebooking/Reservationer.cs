using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Baalhyttebooking
{
   public class Reservationer
    {
        int _id;

        public int Idar
        {
            get { return _id; }
            set { _id = value; }
        }

        Dictionary<int, Reservation> _reservation;

        public Reservationer()
        {
            Idar = 0;
            _reservation = new Dictionary<int, Reservation>();
        }

        public Reservationer(int idar)
        {
            Idar = idar;
            _reservation = new Dictionary<int, Reservation>();
        }

        //public virtual void AddReservation(Reservation reservation)
        //{
        //    _reservation.Add(reservation.Id, reservation);

        //}

        //public void PrintReservation()
        //{
        //    foreach (Reservation.id in _reservation)
        //    {
        //        Console.WriteLine(p);
        //    }


        //    public virtual void DeleteReservation(int id)
        //{
        //    _reservation.Remove(id);
        //}


    }
}
