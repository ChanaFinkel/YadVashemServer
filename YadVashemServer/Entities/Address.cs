using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Address
{
    public string city { get; set; }
    public string address { get; set; }
    public string zipCode { get; set; }
    public string? mailingAddress { get; set; }
    public Country country { get; set; }
    public string state { get; set; }

}
