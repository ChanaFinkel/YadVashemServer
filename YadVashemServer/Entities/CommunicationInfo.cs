using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities;
public class CommunicationInfo
{
    public string telephone  { get; set; }
    public string telephone2 { get; set; }
    public string email { get; set; }
    public string mobile { get; set; }
    public string? fax { get; set; }
}
