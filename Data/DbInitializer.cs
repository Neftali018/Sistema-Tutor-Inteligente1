using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITS.Models;

namespace ITS.Data
{
    public class DbInitializer

    {
        public static void Initialize(ITSContext context)
        {
            context.Database.EnsureCreated();
            if (context.Curso.Any())
            {
                return;
            }
            {
                var Curso = new Curso[]
                {
                    new Curso {id_curso=01, nombre_curso="Programacion", nivel="XV"}
                };
                foreach (Curso a in Curso)
                {
                    context.Curso.Add(a);
                }
                context.SaveChanges();
            }
        }
      
    }
}
