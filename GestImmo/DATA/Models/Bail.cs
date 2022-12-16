﻿using System;
using System.Collections.Generic;

namespace GestImmo.DATA.Models
{
    public class Bail
    {
        public int BailId { get; set; }

        public int Loyer { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public List<Locataire> Locataires { get; set; }

        public static DateTime dateBailEnCours = new DateTime(2000, 1, 1);



        public Bail()
        {

        }

        public Bail(int loyer, DateTime dateDebut, DateTime dateFin)
        {
            Loyer = loyer;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Locataires = new List<Locataire>();
        }
    }
}

