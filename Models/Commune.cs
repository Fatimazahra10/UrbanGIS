using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace WebGIS.Models;

public partial class Commune
{
    [Key]
    public int id { get; set; }

    [Column(TypeName = "geometry(MultiPolygon,4326)")]
    public MultiPolygon? geom { get; set; }

    public int? objectid_1 { get; set; }

    public int? objectid { get; set; }

    public double? shape_leng { get; set; }

    [StringLength(50)]
    public string? prefecture { get; set; }

    [StringLength(50)]
    public string? commune_ar { get; set; }

    [StringLength(50)]
    public string? prefectu_1 { get; set; }

    public double? shape_le_1 { get; set; }

    public double? shape_area { get; set; }

    public int? numero { get; set; }

    [StringLength(50)]
    public string? plan_amena { get; set; }
}
