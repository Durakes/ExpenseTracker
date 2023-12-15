using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models;
public class Expense : Transaction
{
    #region RELATIONSHIPS
    [ForeignKey("ExpenseCategory")]
    [Column("category_id")]
    public int CategoryID { get; set; }
    public virtual required ExpenseCategory ExpenseCategory { get; set; }
    [ForeignKey("Store")]
    [Column("store_id")]
    public int StoreID { get; set; }
    public virtual required Store Store { get; set; }
    #endregion
}