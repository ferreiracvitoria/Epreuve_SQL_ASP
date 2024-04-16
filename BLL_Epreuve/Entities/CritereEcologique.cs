using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class CritereEcologique
    {
        public string Nom {  get; set; }


        public CritereEcologique( string nom)
        {
            Nom = nom;
        }
    }
}
