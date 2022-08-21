using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationHelper_CodeWars
{
    public  class PagnationHelper
    {
        IList<char> coll = new List<char>();
        int PerPage = 0;


        public PagnationHelper(IList<char> collection, int itemsPerPage)
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

        public bool IsLastPageNotRegular
        {
            get
            {
                return (ItemCount % PerPage != 0);
            }
        }

        public int PageCount
        {
            get
            {
                decimal pages = ItemCount / PerPage;

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
            if(pageIndex < 0 || pageIndex >= coll.Count())
            {
                return -1;
            }
            else if (pageIndex == coll.Count() - 1)
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
            decimal page = itemIndex / PerPage;

            int index = (int) Math.Floor(page);

            // check to see if that nearest lowest int is in the index

            return PageItemCount(index);
        }


    }
}
