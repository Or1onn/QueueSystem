using SQLite;
using System.Windows;

namespace QueueSystem.Models
{
    [Table("QueueModel")]
    public class QueueModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(7), NotNull]
        public string? FIN { get; set; }
        [NotNull]
        public int Queue { get; set; }
        [MaxLength(200), NotNull]
        public string? FullName { get; set; }
        [NotNull]
        public bool IsPaid { get; set; }
    }
}
