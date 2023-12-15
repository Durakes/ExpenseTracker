using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExpenseTracker.Models;
public class ExpenseCategory
{
    #region ATRIBUTES
    [Key]
    public int ID { get; set; }
    [Column("name")]
    [StringLength(100)]
    public required string Name { get; set; }
    #endregion

    #region RELATIONSHIPS
    public required ICollection<Expense> Expenses { get; set; }
    #endregion
}