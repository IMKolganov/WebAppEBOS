namespace WebAppEBOS.Entities.Specifications.Interfaces;

public interface ISpecification<in T>
{
    bool IsSatisfied(T item);
}