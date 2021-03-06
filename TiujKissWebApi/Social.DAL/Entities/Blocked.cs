﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.DAL.Entities
{
  public  class Blocked
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BlockedID { get; set; }

        public Guid FromUserID { get; set; }

        public Guid ToUserID { get; set; }

        public DateTime DateLBlocked { get; set; }

        public string BlockedIssue { get; set; }

        public virtual User User { get; set; }

    }
}
