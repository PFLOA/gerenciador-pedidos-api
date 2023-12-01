using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class BdEmpresa : Entity
    {
        public string BdServer { get; set; }
        public string BdNome { get; set; }
        public string BdPw { get; set; }
        public string BdUser { get; set; }

        [IgnoreDataMember]
        public virtual Empresa Empresa { get; set; }

        public override string ToString()
        {
            return $"server={BdServer};port=3306;userid={BdUser};password={BdPw};database={BdNome};";
        }
    }
}
