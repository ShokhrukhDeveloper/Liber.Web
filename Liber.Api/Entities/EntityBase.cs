﻿namespace Liber.Api.Entities;

public class EntityBase 
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}