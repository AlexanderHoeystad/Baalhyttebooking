using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Baalhyttebooking
{
    public class Reservation
    {
        string _id;
        DateTime _tidspunkt;
        Boernegruppe _boernegruppe;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Tidspunkt

        { get { return _tidspunkt; } private set { _tidspunkt = value; } }

        public Boernegruppe Boernegruppe

        { get { return _boernegruppe; } private set { _boernegruppe = value; } }


        public Reservation()
        {
            Id = "";
            Tidspunkt = new DateTime();
            Boernegruppe =  new Boernegruppe();
        }

        public Reservation(string id, DateTime tidspunkt, Boernegruppe boernegruppe)
        {
            Id = id;
            Tidspunkt = tidspunkt;
            Boernegruppe = boernegruppe;

        }

        public override string ToString()
        {
            return $"ID:{Id}, DateTime:{Tidspunkt}, Boernegruppe:{Boernegruppe}";
        }


    }
}
