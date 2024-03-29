﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TutApp.Data.Models
{
    public class Message
    {
        [Key] public int Id { get; set; }

        public string SenderEmail { get; set; }
        public string ReciverEmail { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public MessageStatusTypes Status { get; set; }
    }
}
