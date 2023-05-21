using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotes.Models
{
    [Table("Notes")]
    public class Note
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        public string CreationData { get; set; }

        public string Color { get; set; }
    }
}
