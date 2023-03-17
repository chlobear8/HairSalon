using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    [Range(1, int.MaxValue, ErrorMessage= "You must have a stylist to add a client to. Have you inputted a stylist yet?")]
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}