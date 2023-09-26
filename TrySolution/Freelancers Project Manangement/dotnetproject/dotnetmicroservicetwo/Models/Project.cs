using System;
using System.Collections.Generic;

namespace dotnetmicroservicetwo.Models;
public class Project
{
    public int ProjectID { get; set; }
    public string ClientID { get; set; }
    public string ProjectTitle { get; set; }
    public string ProjectDescription { get; set; }
    public decimal Budget { get; set; }
    public DateTime Deadline { get; set; }


}
