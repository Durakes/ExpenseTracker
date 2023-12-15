using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models;
public class Store
{
    #region ATRIBUTES
    [Key]
    public int ID { get; set; }
    [Column("name")]
    [StringLength(250)]
    public required string Name { get; set; }
    [Column("address")]
    [StringLength(500)]
    public required string Address { get; set; }
    #endregion

    #region RELATIONSHIPS
    public required ICollection<Expense> Expenses { get; set; }
    #endregion
}