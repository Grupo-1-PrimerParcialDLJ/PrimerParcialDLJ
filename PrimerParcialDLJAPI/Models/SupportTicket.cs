using System;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcialDLJAPI.Models
{
    public class SupportTicket
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Subject { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string RequesterEmail { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public string Severity { get; set; } = "Low"; // Low, Medium, High

        [Required]
        public string Status { get; set; } = "Open";  // Open, InProgress, Closed

        [Required]
        public DateTime OpenedAt { get; set; } = DateTime.UtcNow;

        public DateTime? ClosedAt { get; set; }

        public string? AssignedTo { get; set; }
    }
}