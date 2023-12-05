// See https://aka.ms/new-console-template for more information
using HenrençaTrabalho2;
WorkItem workItem = new WorkItem();
Console.WriteLine("WorkItem: " + workItem.ToString());

// Criando uma instância de ChangeRequest usando o construtor com parâmetros
ChangeRequest changeRequest = new ChangeRequest("Change Request", "Description", TimeSpan.FromHours(5), 1);
Console.WriteLine("ChangeRequest: " + changeRequest.ToString());

// Acessando o método Update da classe WorkItem
workItem.Update("Updated WorkItem", TimeSpan.FromHours(8));
Console.WriteLine("Updated WorkItem: " + workItem.ToString());

