using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Grad
    {

        private static int brojac = 0;
        private String naziv;

        public int GradId { get; set; }
        [Required]
        public string Naziv { get => naziv; set => naziv = value; }
        public List<Opcina> OpcinaId { get; set; }

        public virtual ICollection<Opcina> Opcine { get; set; }

        public Grad()
        {
            GradId = brojac++;
            OpcinaId = new List<Opcina>();
        }

        public Grad(String naziv, List<Opcina> opcine)
        {
            GradId = brojac++;
            this.Naziv = naziv;
            this.OpcinaId = opcine;
        }

        public void dodajOpcinu(Opcina opcina)
        {
            OpcinaId.Add(opcina);
        }
    }
}