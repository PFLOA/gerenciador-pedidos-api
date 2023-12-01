<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using System;
=======
﻿using System;
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Entity : EntityBase
    {
<<<<<<< HEAD
=======
        [IgnoreDataMember]
        public short Id { get; set; }
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
