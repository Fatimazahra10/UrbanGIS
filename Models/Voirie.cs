using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace WebGIS.Models;

[Table("Voirie")]
public partial class Voirie
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(MultiLineString,4326)")]
    public MultiLineString? geom { get; set; }

    public double? length { get; set; }

    [StringLength(200)]
    public string? nom { get; set; }
}
