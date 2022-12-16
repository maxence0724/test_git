﻿using System;
using System.Collections.Generic;

namespace GestImmo.DATA.Models
{
    public abstract class Bien
    {
        public int BienId { get; set; }
        public string Nom { get; set; }
        public int Valeur { get; set; }
        public string Adresse { get; set; }
        public int Surface { get; set; }
        public List<Bail> Bails { get; set; }
        public List<Intervention> Interventions { get; set; }
        public Pret? Pret { get; set; }

        public Bien()
        {

        }

        public Bien(string nom, int valeur, string adresse, int surface)
        {
            Nom = nom;
            Valeur = valeur;
            Adresse = adresse;
            Surface = surface;
            Bails = new List<Bail>();
        }

        

        public int calculRentabiliteNetMensuel()
        {
            int montantPret = 0;
            int loyer = 0;

            if (this.Pret != null)
            {
                montantPret = this.Pret.mensualite;
            }

            if (this.Bails.Count > 0)
            {
                foreach (Bail bail in this.Bails)
                {
                    if (bail.DateFin == Bail.dateBailEnCours)
                    {
                        loyer = bail.Loyer;
                        break;
                    }
                }
            }
            return loyer - montantPret;
        }

    }
}

