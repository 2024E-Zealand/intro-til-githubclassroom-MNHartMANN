using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Marcus
    {
        private string _Navn;
        private string _Efternavn;
        private int _Alder;

        public string Navn { get => _Navn; set => _Navn = value; }
        public string Efternavn { get => _Efternavn; set => _Efternavn = value; }
        public int Alder { get => _Alder; set => _Alder = value; }

        public Marcus(string navn, string efternavn, int alder)
        {
            Navn = navn;
            Efternavn = efternavn;
            Alder = alder;
        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Efternavn)}={Efternavn}, {nameof(Alder)}={Alder.ToString()}}}";
        }
    }
}
