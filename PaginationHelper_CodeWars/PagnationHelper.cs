using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationHelper_CodeWars
{
    public  class PagnationHelper
    {
        IList<int> coll = new List<int>();
        int PerPage = 0;


        public PagnationHelper(IList<int> collection, int itemsPerPage)
        {
            coll = collection;
            PerPage = itemsPerPage;
        }

        public int ItemCount
        {
            get
            {
                return coll.Count();
            }
        }

        public int ItemsOnLastPage
        {
            get
            {
                if(ItemCount % PerPage != 0)
                {
                    return ItemCount % PerPage;
                }
                else
                {
                    return PerPage;
                }
            }
        }

        public int PageCount
        {
            get
            {
                decimal pages = (decimal) ItemCount / (decimal) PerPage;

                if(pages % 1 != 0)
                {
                    return (int)(Math.Floor(pages) + 1);
                }
                else
                {
                    return (int) pages;
                }
            }
        }

        public int PageItemCount(int pageIndex)
        {
            if(pageIndex < 0 || pageIndex >= PageCount)
            {
                return -1;
            }
            else if (pageIndex == PageCount - 1)
            { // if pageindex is last page, need to return items on last page
                return ItemsOnLastPage;
            }
            else
            {
                return PerPage;
            }
        }

        public int PageIndex(int itemIndex)
        {
            // divide itemIndex by PerPage, use math.floor to round to nearest lowest int
            decimal page = (decimal) itemIndex / (decimal) PerPage;

            int index = (int) Math.Floor(page);

            if(index < 0 || index >= PageCount)
            {
                return -1;
            }
            else
            {
                return index;
            }
        }
    }
}
