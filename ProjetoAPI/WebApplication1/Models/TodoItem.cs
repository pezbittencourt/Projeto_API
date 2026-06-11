using System.Globalization;

namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    
    public List<string> Entidade { get; set; } = new List<string>();

    public bool IsComplete { get; set; }


}