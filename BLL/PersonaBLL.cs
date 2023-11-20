using System;
using DAL;
namespace BLL
{
    public class PersonaBLL
    {
        public void AgregarPersona(string run, string nombre, string apellido,
            DateTime fechaNacimiento, string direccion, string estadoCivil)
        {
            using(MasterDbContext db = new MasterDbContext())
            { 
               Persona persona = new Persona();
                persona.Run = run;
                persona.Nombre = nombre;
                persona.Apellido = apellido;
                persona.FechaNacimiento = fechaNacimiento;
                persona.Direccion = direccion;
                persona.EstadoCivil = estadoCivil;

                db.Persona.Add(persona);

                db.SaveChanges();
            }
        }

    }
}
