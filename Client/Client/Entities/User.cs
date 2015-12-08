using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations.Schema;
using Client.Models;


namespace Client.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string VUZ { get; set; }

        public string Position { get; set; }

        public string Role { get; set; }

        public virtual List<ConferenceModel> Conferences { get; set; }

    }
}