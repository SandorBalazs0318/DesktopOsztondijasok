using System;
using System.Collections.Generic;

namespace ScholarshipProject.DbModels;

public partial class Scholarship
{
    public string? Email { get; set; }

    public string? Name { get; set; }

    public int? ScholarshipAmount { get; set; }
}
