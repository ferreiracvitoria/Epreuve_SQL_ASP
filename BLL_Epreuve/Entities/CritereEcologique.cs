using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Entities
{
    public class CritereEcologique
    {
        public int Id_CritereEcologique { get; set; }
        public string Nom {  get; set; }


        public CritereEcologique(int id_CritereEcologique, string nom)
        {
            Id_CritereEcologique = id_CritereEcologique;
            Nom = nom;

        }
    }
}
