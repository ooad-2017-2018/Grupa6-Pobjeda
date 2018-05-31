using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_market.Models
{
    public class Supermarket
    {
        private static int brojac = 0;
        private int brojLajkova;

        public int SupermarketId { get; set; }
        public int GradId { get; set; }
        public int OpcinaId { get; set; }
        public int NaseljeId { get; set; }
        public List<int> UposlenikSupermarketaId { get; set; }
        public int MenadzerId { get; set; }
        public List<int> ArtikalId { get; set; }

        public int BrojLajkova { get => brojLajkova; set => brojLajkova = value; }
        public virtual Grad Grad { get; set; }
        public virtual Opcina Opcina { get; set; }
        public virtual Naselje Naselje { get; set; }
        public virtual ICollection<UposlenikSupermarketa> UposleniciSupermarketa { get; set; }
        public virtual Menadzer Menadzer { get; set; }
        public virtual ICollection<Artikal> Artikli { get; set; }
        

        public Supermarket()
        {
            SupermarketId = brojac++;
            UposlenikSupermarketaId = new List<int>();
            ArtikalId = new List<int>();
        }

        public Supermarket(int GradId, int OpcinaId, int NaseljeId, List<int>UposlenikSupermarketaId, int MenadzerId, List<int>ArtikalId) 
        {
            SupermarketId = brojac++;
            this.GradId = GradId;
            this.OpcinaId = OpcinaId;
            this.NaseljeId = NaseljeId;
            this.UposlenikSupermarketaId = UposlenikSupermarketaId;
            this.MenadzerId = MenadzerId;
            this.ArtikalId = ArtikalId;
        }


    }
}