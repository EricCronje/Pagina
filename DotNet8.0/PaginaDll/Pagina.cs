namespace Pagina
{
    public class Pagina : IDisposable
    {
        private uint PageSize { get; set; }
        private uint TotalCount { get; set; }
        public uint TotalPages { get; } = 0;
        public uint FirstItemNumber { get; private set; }
        private uint LastItemNumber { get; set; }

        public Pagina(uint pageSize, uint totalCount)
        {
            if (pageSize == 0) pageSize = 1;
            if (totalCount == 0) totalCount = 1;
            PageSize = pageSize;
            FirstItemNumber = 1;
            TotalCount = totalCount;
            TotalPages = CalculateTotalPages();
        }
		
        public uint CalculateTotalPages()
        {
            if (TotalCount <= 0) { TotalCount = 1; }
            if (PageSize <= 0) { PageSize = 5; }

            uint total = TotalCount / PageSize;
            double mod = TotalCount % PageSize;

            if (mod > 0) { total += 1; }
            if (total <= 0) { total = 1; }

            return Convert.ToUInt32(total);
        }

        public bool IsLastPage() { return (TotalPages == GetCurrentPageNumber()); }

        public bool IsFirstPage() { return (GetCurrentPageNumber() == 1); }

        private uint GetLastItemOnPage() { LastItemNumber = FirstItemNumber + (PageSize - 1); return LastItemNumber; }

        public uint GetCurrentPageNumber()
        {
            uint page = GetLastItemOnPage() / PageSize;
            uint mod = GetLastItemOnPage() % PageSize;
            if (mod > 0) { page += 1; }
            if (page == 0) { page = 1; GoToPage(1); }
            return page;
        }

        public uint GetNextPage()
        {
	    GoToPage(GetCurrentPageNumber() + 1);
            return GetCurrentPageNumber();
        }

        public uint GetPreviousPage()
        {
            GoToPage(GetCurrentPageNumber() - 1);
            return GetCurrentPageNumber();
        }

        public uint GetFirstItemOnPage() { return FirstItemNumber; }

        public uint GetFirstItemNumberOnPage0Based() { return FirstItemNumber - 1; }

        public uint GetLastItemOnThePage() { return IsLastPage() ? TotalCount : LastItemNumber; }

        public void Dispose() { GC.SuppressFinalize(this); }

        public uint GetItemCountOnPage() { return (GetLastItemOnThePage() - FirstItemNumber) + 1; }

        public string GetPageNumberCaption()
        {
            return $"{GetCurrentPageNumber()}/{TotalPages}";
        }

        public void GoToPage(uint pageNumber)
        {
            uint PrevFirstNumber = FirstItemNumber;
            FirstItemNumber = pageNumber * PageSize - PageSize + 1;
            if (pageNumber < 0) { FirstItemNumber = 1; }
            if (pageNumber > TotalPages) { FirstItemNumber = PrevFirstNumber; }
        }

        public void GoToFirstPage()
        {
            GoToPage(1);
        }

        public void GoToLastPage()
        {
            GoToPage(TotalPages);
        }

    }
}
