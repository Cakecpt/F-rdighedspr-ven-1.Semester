using System;
using System.Collections.Generic;
using System.Text;

namespace Færdighedsprøven_1.Semester
{
    class badetidsperiode
    {
        public string _Badning;
        public int _Hour;
        public int _Hour2;
        private int _Minutes;
        private int _Minutes2;
        const int Minutes24Hour = 1440;

        public badetidsperiode(string b, int h, int h2, int m, int m2 )
        {
            _Badning = b;
            _Hour = h;
            _Hour = h2;
            _Minutes = m;
            _Minutes2 = m2;
        }
        public badetidsperiode()
        {
            _Minutes = 0;
            _Minutes2 = 0;
        }
        public badetidsperiode(int Minutes)
        {
            _Minutes = (_Minutes + 1) % Minutes24Hour;
            _Minutes2 = (_Minutes2 + 1) % Minutes24Hour;
        }

        public int Hour
        {
            get { return _Minutes / 60; }
            set { _Minutes = Minute + (60 * value); }
        }

        public int Minute
        {
            get { return _Minutes % 60; }
            set { _Minutes = 60 * Hour + value; }
        }
        public int Minute2
        {
            get { return _Minutes2 % 60; }
            set { _Minutes2 = 60 * Hour + value; }
        }
        public int Hour2
        {
            get { return _Minutes2 / 60; }
            set { _Minutes2 = Minute2 + (60 * value); }
        }

        public void PrintTime()
        {
            Console.WriteLine($"{Minute}:{Hour} - {Minute}:{Hour}");
        }

        public badetidsperiode (int hour, int minute)
        {
            _Minutes = hour * 60 + minute;
        }

        public string Badning
        {
            get { return _Badning; }
        }

        Dictionary<string, kreds> Kredser;

        public void LavEnKreds(kreds navn)
        {
            Kredser.Add(navn.id, navn);
        }

        public kreds ReadKredser(string id)
        {
            return Kredser[id];
        }

        public void OpdaterKreds(kreds navn)
        {

        }

        public void SletKreds(kreds navn)
        {

        }

        public override string ToString()
        {
            return $"{_Badning}";
        }


    }

    

}
