using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrençaTrabalho2
{
    public class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }

        // Devido a nenhum desses construtores criarem um construtor base de classe explicitamente, o construtor base da classe herdada é chamado implicitamente através de um construtor padrão.

        // Construtor padrão para chamar o construtor base da classe herdada (WorkItem).
        public ChangeRequest() { }

        // Construtor de instância que possui quatro parâmentros.
        public ChangeRequest(string title, string desc, TimeSpan jobLen,
                             int originalID)
        {
            // As seguintes propriedades junto com o método GetNextID são herdados da classe WorkItem.
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = jobLen;

            // Essa propriedade originalItemID pertence apenas a classe ChangeRequest e não a WorkItem.
            this.originalItemID = originalID;
        }
    }
}
