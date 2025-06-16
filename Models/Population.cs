using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace WebGIS.Models;

[Table("Population")]
public partial class Population
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(Point,4326)")]
    public Point? geom { get; set; }

    public int? objectid { get; set; }

    [StringLength(120)]
    public string? prefecture { get; set; }

    [StringLength(100)]
    public string? arrondisse { get; set; }

    public double? shape_leng { get; set; }

    public double? shape_area { get; set; }

    public long? marocains { get; set; }

    public long? etrangers { get; set; }

    public long? total1994 { get; set; }

    public long? ménages199 { get; set; }

    public long? marocain_1 { get; set; }

    public long? etranger_1 { get; set; }

    public long? total2004 { get; set; }

    public long? ménages200 { get; set; }

    public double? taux { get; set; }

    public double? densite199 { get; set; }

    public double? densite200 { get; set; }

    public double? evolution_ { get; set; }
}
