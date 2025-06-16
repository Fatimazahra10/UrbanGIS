using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace WebGIS.Models;

[Table("Site")]
public partial class Site
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(MultiPolygon,4326)")]
    public MultiPolygon? geom { get; set; }

    public int? objectid { get; set; }

    [StringLength(50)]
    public string? reference { get; set; }

    [StringLength(254)]
    public string? commune_ce { get; set; }

    [StringLength(50)]
    public string? etat { get; set; }

    [StringLength(200)]
    public string? prefecture { get; set; }

    public double? shape_leng { get; set; }

    public double? shape_area { get; set; }

    [StringLength(50)]
    public string? site { get; set; }

    public int? site_id { get; set; }

    [StringLength(200)]
    public string? avancement { get; set; }
}
