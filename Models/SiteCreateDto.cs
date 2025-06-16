using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace WebGIS.Models;
public class SiteCreateDto
{
    public string? reference { get; set; }
    public string? commune_ce { get; set; }
    public string? etat { get; set; }
    public string? prefecture { get; set; }
    public double? shapeLeng { get; set; }
    public double? shapeArea { get; set; }
    public string? site { get; set; }
    public int? siteId { get; set; }
    public string? avancement { get; set; }

    // Géométrie en GeoJSON 
    [Required(ErrorMessage = "Veuillez dessiner un polygone.")]
    public string? GeometrieGeoJson { get; set; }


}
