using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebGIS.Models;

[Table("Client")]
public partial class Client
{
    [Key]
    public int id { get; set; }

    public short? nom { get; set; }

    public short? prenom { get; set; }
}
