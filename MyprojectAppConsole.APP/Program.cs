using Myprojec.MODEL;
using MyProject.BLL;

DateTime dateTime = DateTime.Now;
Projeto projeto1 = new Projeto("Vitoria","Jose", dateTime, dateTime,"teste",1);

ProjetoRepository.Add(projeto1);
/*-----------------------------------------------*/
List<Projeto> projetos = ProjetoRepository.getAll();


foreach (Projeto projeto in projetos)
{
    Console.WriteLine(projeto.NomedoProjeto);
}
Console.WriteLine("Registro");

Console.ReadLine();


/*-----------------------------------------------*/

