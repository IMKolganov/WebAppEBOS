namespace WebAppEBOS.Data;

public interface IHasItems<T>
{
    ICollection<T> Items { get; set; }
}