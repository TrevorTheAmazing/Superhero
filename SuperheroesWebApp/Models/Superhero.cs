using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SuperheroesWebApp.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string alterEgoName { get; set; }
        public string primarySuperheroAbility { get; set; }
        public string secondarySuperheroAbility { get; set; }
        public string catchphrase { get; set; }
    }
}