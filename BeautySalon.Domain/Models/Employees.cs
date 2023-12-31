﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BeautySalon.Infrastructure;

[Index("Id", Name = "indx_employee_id")]
public partial class Employees
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("surname")]
    [StringLength(255)]
    [Unicode(false)]
    public string Surname { get; set; } = null!;

    [Column("position")]
    public int Position { get; set; }

    [Column("birthday", TypeName = "date")]
    public DateTime? Birthday { get; set; }

    [Column("phone_number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [Column("payment_percent")]
    public int? PaymentPercent { get; set; }

    [Column("email")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("password_hash")]
    [StringLength(255)]
    [Unicode(false)]
    public string? PasswordHash { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<Appointments> Appointments { get; set; } = new List<Appointments>();

    [InverseProperty("Worker")]
    public virtual ICollection<EmployeeSchedule> EmployeeSchedule { get; set; } = new List<EmployeeSchedule>();

    [ForeignKey("Position")]
    [InverseProperty("Employees")]
    public virtual Positions PositionNavigation { get; set; } = null!;

    [InverseProperty("Employee")]
    public virtual ICollection<Salary> Salary { get; set; } = new List<Salary>();
}