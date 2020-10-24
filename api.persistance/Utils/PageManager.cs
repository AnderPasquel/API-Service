using System;
using System.Collections.Generic;
using System.Text;

namespace api.persistance.Utils
{
    public class PageManager
    { 
        public int Offset { get; }
        public int PageSize { get; }
        public PageManager(int offset)
        {
            this.PageSize = 5;
            if (offset != 0)
            {
                this.Offset = offset;
            }
            else
            {
                this.Offset = 0;
            }
        }
        public PageManager(int offset, int limit) 
        {
            if (offset != 0)
            {
                this.Offset = offset;
            }
            else
            {
                this.Offset = 0;
            }
            if (limit != 0)
            {
                this.PageSize = limit;
            }
            else
            {
                this.PageSize = 10;
            }         
        }
      
    }
}
