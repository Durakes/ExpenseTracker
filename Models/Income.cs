using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models;
public class Income : Transaction
{
    #region RELATIONSHIPS
    [ForeignKey("IncomeCategory")]
    [Column("category_id")]
    public int CategoryID { get; set; }
    public virtual IncomeCategory IncomeCategory { get; set; } = null!;
    #endregion
}