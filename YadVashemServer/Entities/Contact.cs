using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Entities;
public class Contact
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string fullName { get; set; }
    public string idNumber { get; set; }
    public Gender gender { get; set; }
    public CommunicationInfo communicationInfo { get; set; }
    public Address address { get; set; }
    public Guid id { get; set; }
    public bool isDeleted { get; set; }
    public bool isDirty { get; set; }
    public bool isCanceled { get; set; }
    public bool isActive { get; set; }
    public string? createdOn { get; set; }

}
