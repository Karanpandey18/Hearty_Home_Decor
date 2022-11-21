using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartyHomeDecor.Utility
{
    public class PagingList<T> : List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public PagingList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            int pages = (int)Math.Ceiling(count / (double)pageSize);
            TotalPages = pages == 0 ? 1 : pages;

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public int TotalPageNo
        {
            get
            {
                return TotalPages;
            }
        }

        public static PagingList<T> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PagingList<T>(items, count, pageIndex, pageSize);
        }
    }
}
