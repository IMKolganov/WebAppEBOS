﻿using WebAppEBOS.Data.PageData.Interfaces;

namespace WebAppEBOS.Data.PageData;

public class PageResult<T> : IHasItems<T>
{
    public int PageIndex { get; set; }

    public int PageSize { get; set; }

    public int Total { get; set; }

    public ICollection<T> Items { get; set; } = (ICollection<T>) ArraySegment<T>.Empty;
}