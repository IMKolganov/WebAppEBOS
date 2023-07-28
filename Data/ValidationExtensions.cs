namespace WebAppEBOS.Data;

  public static class ValidationExtensions
  {
    public static T ThrowIfNull<T>(this T context, string argumentName = null) => (object) context != null ? context : throw new ArgumentNullException(argumentName ?? nameof (context));

    public static string ThrowIfEmpty(this string context, string argumentName = null) => !context.IsEmpty() ? context : throw new ArgumentNullException(argumentName ?? nameof (context));

    public static T ThrowIf<T>(this T context, Predicate<T> predicate, string name = null) => (object) context != null && !predicate(context) ? context : throw new ArgumentException(name ?? nameof (context));

    public static bool IsEmpty(this string context) => string.IsNullOrWhiteSpace(context);

    public static bool IsNotEmpty(this string context) => !string.IsNullOrWhiteSpace(context);

    public static bool IsEmpty(this DateTime context) => context == new DateTime();

    public static bool IsNotEmpty(this DateTime context) => context != new DateTime();

    public static bool IsEmpty(this Guid context) => context == Guid.Empty;

    public static bool IsNotEmpty(this Guid? context)
    {
      int num;
      if (context.HasValue)
      {
        Guid? nullable = context;
        Guid empty = Guid.Empty;
        num = nullable.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() != empty ? 1 : 0) : 0) : 1;
      }
      else
        num = 0;
      return num != 0;
    }

    public static bool IsEmpty(this Guid? context)
    {
      int num;
      if (context.HasValue)
      {
        Guid? nullable = context;
        Guid empty = Guid.Empty;
        num = nullable.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() == empty ? 1 : 0) : 1) : 0;
      }
      else
        num = 1;
      return num != 0;
    }

    public static bool IsNotEmpty(this Guid context) => context != Guid.Empty;

    public static bool IsNull(this object context) => context == null;

    public static bool IsNotNull(this object context) => context != null;

    public static bool IsEmpty<T>(this IEnumerable<T> context) => context == null || !context.Any<T>();

    public static bool IsNotEmpty<T>(this IEnumerable<T> context) => context != null && context.Any<T>();

    public static string DefaultIfEmpty(this string context, string defaultValue) => context.IsEmpty() ? defaultValue : context;

    public static Guid DefaultIfEmpty(this Guid context, Guid defaultValue) => new Guid?(context).DefaultIfEmptyInternal(defaultValue);

    public static Guid DefaultIfEmpty(this Guid? context, Guid defaultValue) => context.DefaultIfEmptyInternal(defaultValue);

    private static Guid DefaultIfEmptyInternal(this Guid? context, Guid defaultValue) => context.IsNotEmpty() ? context.Value : defaultValue;
  }