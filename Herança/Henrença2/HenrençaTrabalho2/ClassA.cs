
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Essa classe WorkItem herda implicitamente a classe base Object do C#
public class WorkItem
{
    // O atributo estático currentID armazena a ID de trabalho do último WorkItem que foi criado.
    private static int currentID;

    //Propriedades
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan jobLength { get; set; }

    // Construtor padrão. Se uma classe derivada não utilizar um construtor base de classe explicitamente, esse construtor padrão será chamado implicitamente.
    public WorkItem()
    {
        ID = 0;
        Title = "Default title";
        Description = "Default description.";
        jobLength = new TimeSpan();
    }

    // Construtor de instância que possui 3 parâmetros.
    public WorkItem(string title, string desc, TimeSpan joblen)
    {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = desc;
        this.jobLength = joblen;
    }

    // Construtor estático para inicializar o membro estático currentID. Esse construtor é chamado automaticamente apenas uma vez, antes de uma instância do WorkItem ou ChangeRequest ser criada, ou do currentID ser referenciado.
    static WorkItem() => currentID = 0;

    // currentID é um atributo estático que é incrementado toda vez que uma instância de WorkItem for criada.
    protected int GetNextID() => ++currentID;

    // Esse método Update permite que você altere o title e jobLength de um objeto WorkItem existente.
    public void Update(string title, TimeSpan joblen)
    {
        this.Title = title;
        this.jobLength = joblen;
    }

    // Esse método virtual sobrepõe o método ToString presente na classe Object que foi herdada implicitamente.
    public override string ToString() =>
        $"{this.ID} - {this.Title}";
}

// Essa classe ChangeRequest herda o WorkItem e adiciona a propriedade originalItemID e dois construtores.
