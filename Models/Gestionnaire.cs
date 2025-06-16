using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebGIS.Models;

[Table("Gestionnaire")]
public partial class Gestionnaire
{
    [Key]
    public int id { get; set; }

    public short? nom { get; set; }

    public short? etat { get; set; }
}
