﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Client.Entities;

namespace Client.Models
{
    [Table("Conference")]
    public class ConferenceModel
    {
         [Key]
         public int Id { get; set; }
         public string Name { get; set; }
         public string Description { get; set; }
         public DateTime StartDate { get; set; }

         public virtual ICollection<User> Organisators { get; set; }
    }
}