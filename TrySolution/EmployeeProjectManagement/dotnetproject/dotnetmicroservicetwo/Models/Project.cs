using System;
using System.Collections.Generic;

namespace dotnetmicroservicetwo.Models;
public class Project
{
    public int ProjectID { get; set; }
    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ProjectStatus { get; set; }


}
