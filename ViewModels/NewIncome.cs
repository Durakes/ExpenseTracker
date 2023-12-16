namespace ExpenseTracker.ViewModels;
public class NewIncome
{
    public required string Title { get; set; }
    public decimal Amount { get; set; }
    public DateOnly RecordDate { get; set; }
    public int CategoryID { get; set; }
    public string? Description { get; set; }
}