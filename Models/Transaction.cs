using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace ExpenseTracker.Models;
public class Transaction
{
    #region ATRIBUTES
    [Key]
    public int ID { get; set; }
    [Column("title")]
    [StringLength(100)]
    public required string Title { get; set; }
    [Column("amount", TypeName = "decimal(18, 2)")]
    [DataType(DataType.Currency)]
    [Range(0.01, 999999.99)]
    public decimal Amount { get; set; }
    [Column("record_date")]
    public DateOnly RecordDate { get; set; }
    [Column("description")]
    [StringLength(500)]
    public string? Description { get; set; }
    #endregion
}