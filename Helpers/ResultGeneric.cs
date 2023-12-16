namespace ExpenseTracker.Helpers;
public class ResultObject<T>
{
    public bool Success { get; set; }
    public T? Value { get; set; }
    public string? Message { get; set; }
}

public class ResultList<T>
{
    public bool IsEmpty { get; set; }
    public required IEnumerable<T> Value { get; set; }
    public string? Message { get; set; }
}