﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BeautySalon.Infrastructure;

public partial class Reviews
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("client_id")]
    public int ClientId { get; set; }

    [Column("employee_id")]
    public int EmployeeId { get; set; }

    [Column("text")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Text { get; set; }

    [Column("rate")]
    public byte Rate { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Reviews")]
    public virtual Clients Client { get; set; } = null!;
}