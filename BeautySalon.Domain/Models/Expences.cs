﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BeautySalon.Infrastructure;

public partial class Expences
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("sum")]
    public double Sum { get; set; }

    [Column("date")]
    public DateOnly Date { get; set; }
}