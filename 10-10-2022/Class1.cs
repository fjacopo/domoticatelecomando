using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_10_2022
{
    public class Class1
    {
        private string produttore;
        private string modello;
        private int volume;
        private bool stato;
        private int canale;
        private string segnale;


        public string setProduttore(string nuovoproduttore)
        {
            produttore = nuovoproduttore;
            return produttore;
        }
        public string setModello(string ilmodello)
        {
            modello = ilmodello;
            return modello;
        }

        public int setCanale(int nuovoCanale)
        {
            canale = nuovoCanale;
            return canale;
        }

        public int setVolume(int nuovoVolume)
        {
            volume = nuovoVolume;
            return volume;
        }

        public void accendi()
        {
            setStato(true);
        }
        public void spegni()
        {
            setStato(false);
        }
        private void setStato(bool nuovoStato)
        {
            stato = nuovoStato;
        }
        public bool getStato()
        {
            return stato;
        }
        

        public string setSegnale()
        {
            if (segnale == "Bluetooth")
            {
                segnale = "Wi-Fi";
            }
            else if (segnale == "Wi-Fi")
            {
                segnale = "Infrarossi";
            }
            else
            {
                segnale = "Bluetooth";
            }
            return segnale;
        }

    }
       
 }
