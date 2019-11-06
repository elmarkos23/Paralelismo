using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Paralelismo
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Persona> listaPersona = new List<Persona>();

      for (int i = 100; i <= 999; i++)
      {
        listaPersona.Add(new Persona { id = i, Name = "Marco" });
      }
      
      //var options = new ParallelOptions()
      //{
      //  MaxDegreeOfParallelism = 2
      //};
      Console.WriteLine("*** Proceso Parallel.ForEach ***");
      Parallel.ForEach(listaPersona, x =>
      {
        Console.WriteLine(@"value of i = {0}, thread = {1}, time={2}",x.id, Thread.CurrentThread.ManagedThreadId,DateTime.Now.ToString("HH:mm:ss"));
      });

      Console.WriteLine("\n\n\n");
      Console.WriteLine("*** Proceso Normal foreach ***");
      foreach (Persona persona in listaPersona)
      {
        Console.WriteLine(@"value of i = {0}, thread = {1}, time={2}", persona.id, Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:mm:ss"));
      }

      Console.WriteLine("Press any key to exist");
      Console.ReadLine();
    }
  }
}
