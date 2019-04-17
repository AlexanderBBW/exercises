using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using Model;
namespace Controler
{
    public class Controler1
    {
        public List<string> LadeKunden()
        {
            List<string> kunden = Model.Model.LadeKunde();
            List<string> kunden1 = View.View.LadeKunden();
            
            return kunden1;
        }
        public List<string> KundeSpeicher(List<string> kunde, int personalausweisnummer)
        {
            List<string> kundespeichern = Model.Model.KundeSpeichern();
            List<string> kundenspeichern = View.View.KundenSpeichern();
            return kundenspeichern;
        }
        public List<string> KundeLöschen(int personalausweisnummer)
        {
            List<string> kundelöschen = Model.Model.KundeLöschen();
            List<string> kundelöschen1 = View.View.KundeLöschen();
            return kundelöschen1;
        }
        public List<string> HoleObjekte()
        {
            List<string> objekt = Model.Model.HoleObjekte();
            List<string> objekt1 = View.View.HoleObjekte();
            return objekt1;  
        }
        public List<string> HoleAusleihObjekte()
        {
            List<string> Hole = Model.Model.HoleAusleihobjekte();
            List<string> Hole1 = View.View.holeAusleihObjekte();
            return Hole1;
        }
        public List<string> Kundenabfrage()
        {
            List<string> abfrage = Model.Model.Kundenabfrage();
            List<string> abfrage1 = View.View.Kundenabfrage();
            return abfrage1;
        }
        public List<string> Kasse()
        {
            List<string> preis = Model.Model.BerechnePreis();
            List<string> preis1 = View.View.BerechnePreis();
            return preis1;
        }
        public List<string> BelegErstellen()
        {
            List<string> ausleihe = Model.Model.BelegErstellen();
            List<string> ausleihe1 = View.View.BelegErstellen();
            return ausleihe1;
        }
    }
}