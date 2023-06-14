using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Boernegruppe
{
        string _id;
        string _name;
        string _aldersgruppe;
        int _antaldeltagere;
        
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Aldersgruppe
        {
            get { return _aldersgruppe; }
            set { _aldersgruppe = value; }
        }

        public int Antaldeltagere
        {
            get { return _antaldeltagere; }
            set { _antaldeltagere = value; }
        }


        public Boernegruppe()
        {
            Id = "";
            Name = "";
            Aldersgruppe = "";
            Antaldeltagere = 0;
        }

        public Boernegruppe(string id, string name, string aldersgruppe, int antaldeltagere)
        {
            Id = id;
            Name = name;
            Aldersgruppe = aldersgruppe;
            Antaldeltagere = antaldeltagere;
        }

        public override string ToString()
        {
            return $"ID:{Id}, GruppeNavn:{Name}, Aldersgruppe:{Aldersgruppe}, Deltagere:{Antaldeltagere}";
        }

    }

}