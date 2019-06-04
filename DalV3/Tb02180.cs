using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02180
    {
        public string Tb02180Codigo { get; set; }
        public string Tb02180Codcli { get; set; }
        public DateTime? Tb02180Data { get; set; }
        public DateTime? Tb02180Dtencerra { get; set; }
        public string Tb02180Titulo { get; set; }
        public string Tb02180Codtec { get; set; }
        public string Tb02180Os { get; set; }
        public string Tb02180Conversa { get; set; }
        public string Tb02180Email { get; set; }
        public int? Tb02180Avaliacao { get; set; }
        public string Tb02180Obs { get; set; }
        public string Tb02180Nome { get; set; }
        public int? Tb02180Porta { get; set; }
        public string Tb02180Atendente { get; set; }
        public int? Tb02180Status { get; set; }
        public string Tb02180Obstec { get; set; }
        public string Tb02180Setor { get; set; }
        public string Tb02180Statusresolvido { get; set; }
        public string Tb02180Statusnresolvido { get; set; }
        public int? Tb02180Operacao { get; set; }
        public string Tb02180Emailsup { get; set; }
        public int? Tb02180Tempo { get; set; }
        public int? Tb02180Resolvido { get; set; }
        public string Tb02180Ip { get; set; }
        public string Tb02180Nomecli { get; set; }
        public DateTime? Tb02180Dtsolicitante { get; set; }
        public DateTime? Tb02180Dtatendente { get; set; }

        public virtual Tb01008 Tb02180CodcliNavigation { get; set; }
    }
}