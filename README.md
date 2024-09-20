# Pagina
Pagination - c# .net 8.0 dll - with examples

Pagina (Pagination) breaks up a bigger list into smaller pieces (pages). 
Providing a way to navigate through the list with a particular page size.

Methods provided:

CalculateTotalPages               - Returns the number of pages.
IsLastPage                        - Returns a true or false if it is the last page. Returns true if it is the last page otherwise false.
IsFirstPage                       - Returns a boolean value to indicate the first page. True if it is the first page on the other hand false if it is not.
GetLastItemOnPage                 - Returns the item number of the Item on the page. First item number plus the page size minus 1.
GetNextPage                       - Returns the next page number.
GetPreviousPage                   - Returns the previous page number.
GetFirstItemOnPage                - Returns the first item number on the page.
GetFirstItemNumberOnPage0Based    - Returns the first itme number on the page (Zero based).
GetLastItemOnThePage              - Returns the last item on the page. In the case where it is the last page will return the total count. If not the last item number.
Dispose                           - Cleanup.
GetItemCountOnPage                - Returns the item count on the page.
GetPageNumberCaption              - Shows the page caption e.g "Page 1/5".
GoToPage                          - Navigates to a valid page. Pass in the page number.
GoToFirstPage                     - Goes to the first page.
GoToLastPage                      - NAvigates to the last page number.
