using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Book
    {
        private int _pages ;
        public int pages { get => _pages; }


        public  int GetBookPage(int Pages = 16)
        {
            
            if (this.pages>=16)
            {
                this._pages = Pages;
                
            }
            return Pages;
        }

    }
}
