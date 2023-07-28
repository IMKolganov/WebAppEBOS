namespace WebAppEBOS.Data;

public interface ISpecification<in T>
{
    bool IsSatisfied(T item);
}