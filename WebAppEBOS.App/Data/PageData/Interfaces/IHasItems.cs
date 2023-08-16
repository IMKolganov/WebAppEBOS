namespace WebAppEBOS.Data.PageData.Interfaces;

public interface IHasItems<T>
{
    ICollection<T> Items { get; set; }
}