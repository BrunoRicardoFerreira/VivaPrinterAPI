using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04038
    {
        public Tb04038()
        {
            Tb04039 = new HashSet<Tb04039>();
            Tb04040 = new HashSet<Tb04040>();
        }

        public int Tb04038Lote { get; set; }
        public string Tb04038Codemp { get; set; }
        public DateTime? Tb04038Data { get; set; }
        public string Tb04038Opcad { get; set; }
        public DateTime? Tb04038Dtvenc1 { get; set; }
        public DateTime? Tb04038Dtvenc2 { get; set; }
        public string Tb04038Codfor { get; set; }
        public string Tb04038Tipdoccodigo { get; set; }
        public string Tb04038Tipdocnome { get; set; }
        public string Tb04038Clientecodigo { get; set; }
        public string Tb04038Clientenome { get; set; }
        public string Tb04038Centrocodigo { get; set; }
        public string Tb04038Centronome { get; set; }
        public string Tb04038Subcentrocodigo { get; set; }
        public string Tb04038Subcentronome { get; set; }
        public string Tb04038Planocodigo { get; set; }
        public string Tb04038Planonome { get; set; }
        public int? Tb04038Qtde { get; set; }
        public decimal? Tb04038Vlrtitulo { get; set; }
        public int? Tb04038Qtderec { get; set; }
        public decimal? Tb04038Vlrtitulorec { get; set; }
        public int? Tb04038Qtdedev { get; set; }
        public decimal? Tb04038Vlrtitulodev { get; set; }
        public DateTime? Tb04038Dtfecha { get; set; }
        public string Tb04038Opfecha { get; set; }
        public decimal? Tb04038Txadm { get; set; }
        public string Tb04038Obs { get; set; }
        public string Tb04038Destino { get; set; }
        public string Tb04038Codban { get; set; }
        public string Tb04038Codcon { get; set; }
        public string Tb04038Devpag { get; set; }

        public virtual Tb01007 Tb04038CodempNavigation { get; set; }
        public virtual Tb01001 Tb04038CodforNavigation { get; set; }
        public virtual ICollection<Tb04039> Tb04039 { get; set; }
        public virtual ICollection<Tb04040> Tb04040 { get; set; }
    }
}