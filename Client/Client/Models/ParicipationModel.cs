using Client.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Client.Models
{
    [Table("Paricipations")]
    public class ParicipationModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Anotation { get; set; }

        public virtual User User { get; set; }
        public virtual ConferenceModel Conference { get; set; }


    }
}