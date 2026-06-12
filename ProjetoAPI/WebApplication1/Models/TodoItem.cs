using System.Globalization;

namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    
    public string? email { get; set; } = null;

    public string? Secret { get; set; }
    public bool IsComplete { get; set; }


}