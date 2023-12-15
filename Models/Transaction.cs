using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace ExpenseTracker.Models;
public class Transaction
{
    #region ATRIBUTES
    [Key]
    public int ID { get; set; }
    [Column("amount")]
    [DataType(DataType.Currency)]
    [Range(0.01, 999999.99)]
    public decimal Amout { get; set; }
    [Column("record_date")]
    public DateTime RecordDate { get; set; }
    [Column("description")]
    [StringLength(500)]
    public string? Description { get; set; }
    #endregion
}