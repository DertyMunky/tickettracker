﻿using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;

namespace TicketTracker.Models
{
    /// <summary>
    /// A ticket object to be stored or viewed in the database
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Ticket object ID
        /// </summary>
        public int TicketID { get; set; }

        /// <summary>
        /// The levels of importance of the ticket
        /// </summary>
        [Required]
        [EnumDataType(typeof(SeverityTypes))]
        public SeverityTypes Severity { get; set; }

        /// <summary>
        /// Title of the ticket object concern
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Full descpription of the ticket object concern
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Ticket status active/resolved
        /// </summary>
        [Required]
        [EnumDataType(typeof(TicketTypes))]
        public TicketTypes Status { get; set; }

        /// <summary>
        /// Ticket creators email for inquiries
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public string Creator { get; set; }

        /// <summary>
        /// Date the ticket was opened
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Ticket creators email for inquiries
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public string Modifier { get; set; }

        /// <summary>
        /// Date the ticket was modified
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? Modified { get; set; }
    }

    /// <summary>
    /// Ticket status
    /// </summary>
    public enum TicketTypes { active, resolved }

    /// <summary>
    /// Ticket severity
    /// </summary>
    public enum SeverityTypes { Low, Medium, High, Critical }
}