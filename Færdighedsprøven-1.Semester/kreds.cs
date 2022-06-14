using System;
using System.Collections.Generic;
using System.Text;

namespace Færdighedsprøven_1.Semester
{
   public class kreds
    {


        private string _navn;
        private string _ID;
        private string _Adresse;
        private int _Deltagere;

        public kreds(string navn, string id, string A, int D)
        {
            _navn = navn;
            _ID = id;
            _Adresse = A;
            _Deltagere = D;
        }
        public string Navn
        {
            get { return _navn; }
        }

        public string id
        {
            get; private set;
        }

        public string A
        {
            get { return _Adresse; }
        }

        public int D
        {
            get { return _Deltagere; }
        }

        public override string ToString()
        {
            return $"Kreds Navn {Navn} Adresse {A} ID {id} Deltagere {D}";
        }


    }
}
