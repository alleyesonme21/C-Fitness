using System;

namespace FitnessClient.Models
{
  public class ErrorViewModel
  {
    public string RequestId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
  }
}