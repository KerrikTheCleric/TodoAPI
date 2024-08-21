namespace TodoApi.Models;
public class TodoItem {
    public required long Id { get; set; }
    public required string? Title { get; set; }
    public required bool IsCompleted { get; set; }
    public required DateTime Timestamp { get; set; }
    public required string? Author { get; set; }
}