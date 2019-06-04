using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04041
    {
        public Tb04041()
        {
            Tb04042 = new HashSet<Tb04042>();
        }

        public int Tb04041Lote { get; set; }
        public string Tb04041Codemp { get; set; }
        public DateTime? Tb04041Data { get; set; }
        public string Tb04041Opcad { get; set; }
        public DateTime? Tb04041Dtvenc1 { get; set; }
        public DateTime? Tb04041Dtvenc2 { get; set; }
        public string Tb04041Tipdoccodigo { get; set; }
        public string Tb04041Tipdocnome { get; set; }
        public string Tb04041Clientecodigo { get; set; }
        public string Tb04041Clientenome { get; set; }
        public string Tb04041Centrocodigo { get; set; }
        public string Tb04041Centronome { get; set; }
        public string Tb04041Subcentrocodigo { get; set; }
        public string Tb04041Subcentronome { get; set; }
        public string Tb04041Planocodigo { get; set; }
        public string Tb04041Planonome { get; set; }
        public int? Tb04041Qtde { get; set; }
        public decimal? Tb04041Vlrtitulo { get; set; }
        public int? Tb04041Qtderec { get; set; }
        public decimal? Tb04041Vlrtitulorec { get; set; }
        public int? Tb04041Qtdedev { get; set; }
        public decimal? Tb04041Vlrtitulodev { get; set; }
        public DateTime? Tb04041Dtfecha { get; set; }
        public string Tb04041Opfecha { get; set; }
        public string Tb04041Obs { get; set; }
        public string Tb04041Destino { get; set; }
        public string Tb04041Codban { get; set; }
        public string Tb04041Codcon { get; set; }
        public string Tb04041Devpag { get; set; }
        public decimal? Tb04041Vlrjuros { get; set; }
        public decimal? Tb04041Vlrdesconto { get; set; }
        public decimal? Tb04041Vlrabatimento { get; set; }
        public decimal? Tb04041Vlrmulta { get; set; }
        public DateTime? Tb04041Dtjuros { get; set; }
        public DateTime? Tb04041Dtdesconto { get; set; }
        public DateTime? Tb04041Dtabatimento { get; set; }
        public DateTime? Tb04041Dtmulta { get; set; }
        public string Tb04041Arqremessa { get; set; }
        public string Tb04041Layout { get; set; }
        public string Tb04041Carteira { get; set; }
        public int? Tb04041Diasjuros { get; set; }
        public int? Tb04041Diasprotesto { get; set; }
        public string Tb04041Tipoend { get; set; }
        public string Tb04041Tipodata { get; set; }
        public string Tb04041Mesfecha { get; set; }

        public virtual Tb01007 Tb04041CodempNavigation { get; set; }
        public virtual ICollection<Tb04042> Tb04042 { get; set; }
    }
}