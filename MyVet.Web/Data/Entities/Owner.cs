using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }

        //Relaciones
        public ICollection<Pet> Pets { get; set; }
        public ICollection<Agenda> Agendas { get; set; }
    }
}
