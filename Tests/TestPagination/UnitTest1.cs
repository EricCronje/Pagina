namespace TestPagination
{

    public class UnitTest1
    {
        [Fact]
        public void InValid_Total_Zero()
        {
            Pagina.Pagina pagination = new(10, 0);
            Assert.True(pagination.TotalPages == 1);
        }

        [Fact]
        public void Valid_Total_Ten_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 10);
            Assert.True(pagination.TotalPages == 1);
        }

        [Fact]
        public void Valid_Total_20_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 20);
            Assert.True(pagination.TotalPages == 2);
        }

        [Fact]
        public void Valid_Total_25_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 25);
            Assert.True(pagination.TotalPages == 3);
        }

        [Fact]
        public void Valid_Total_26_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 26);
            Assert.True(pagination.TotalPages == 3);
        }

        [Fact]
        public void Valid_Total_29_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 29);
            Assert.True(pagination.TotalPages == 3);
        }

        [Fact]
        public void Valid_Total_21_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 21);
            Assert.True(pagination.TotalPages == 3);
        }

        [Fact]
        public void Valid_Total_10_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 10);
            Assert.True(pagination.TotalPages == 1);
        }

        [Fact]
        public void Valid_Total_11_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 11);
            Assert.True(pagination.TotalPages == 2);
        }

        [Fact]
        public void Valid_Total_30_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 30);
            Assert.True(pagination.TotalPages == 3);
        }

        [Fact]
        public void Valid_Total_1_PageSize_10()
        {
            Pagina.Pagina pagination = new(10, 1);
            Assert.True(pagination.TotalPages == 1);
        }

        [Fact]
        public void Valid_Total_6_PageSize_5()
        {
            Pagina.Pagina pagination = new(5, 6);
            Assert.True(pagination.TotalPages == 2);
        }


        [Fact]
        public void Valid_GetFirstPage_Total_6_PageSize_5()
        {
            Pagina.Pagina pagination = new(5, 6);
            var pageNumber = pagination.GetCurrentPageNumber();

            Assert.True(pageNumber == 1);
        }

        [Fact]
        public void Valid_GetNextPage_Total_6_PageSize_5()
        {
            Pagina.Pagina pagination = new(5, 6);
            pagination.GetNextPage();
            var pageNumber = pagination.GetCurrentPageNumber();

            Assert.True(pageNumber == 2);
        }
        [Fact]
        public void InValid_GetNextPage_Total_6_PageSize_5_OnLastPage()
        {
            Pagina.Pagina pagination = new(5, 6);
            pagination.GetNextPage();
            pagination.GetNextPage();
            var pageNumber = pagination.GetCurrentPageNumber();

            Assert.True(pageNumber == 2);
        }

        [Fact]
        public void Valid_GetPreviousPage_Total_6_PageSize_5_OnLastPage()
        {
            Pagina.Pagina pagination = new(5, 6);
            pagination.GetNextPage();
            pagination.GetNextPage();
            pagination.GetPreviousPage();
            var pageNumber = pagination.GetCurrentPageNumber();

            Assert.True(pageNumber == 1);
        }

        [Fact]
        public void InValid_GetPreviousPage_Total_6_PageSize_5_OnFirstPage()
        {
            Pagina.Pagina pagination = new(5, 6);
            pagination.GetPreviousPage();
            var pageNumber = pagination.GetCurrentPageNumber();

            Assert.True(pageNumber == 1);
        }

        [Fact]
        public void Valid_TestIfLastPage_Total_6_PageSize_5_OnLastPage()
        {
            Pagina.Pagina pagination = new(5, 6);
            pagination.GetNextPage();
            pagination.GetNextPage();
            Assert.True(pagination.IsLastPage());
        }

        [Fact]
        public void Valid_TestIfISFirstPage_Total_6_PageSize_5_OnLastPage()
        {
            Pagina.Pagina pagination = new(5, 6);
            Assert.True(pagination.IsFirstPage());
        }

        [Fact]
        public void InValid_TestIfIsFirstPage_LastPage_Total_6_PageSize_5_OnLastPage()
        {
            Pagina.Pagina pagination = new(5, 6);
            pagination.GetNextPage();
            pagination.GetNextPage();
            Assert.False(pagination.IsFirstPage());
        }

        [Fact]
        public void InValid_SetPageSizeTo0_SetItemsTo0_Total_0_PageSize_0()
        {
            Pagina.Pagina pagination = new(0, 0);
            pagination.GetNextPage();
            pagination.GetNextPage();
            Assert.True(pagination.GetCurrentPageNumber() == 1);
        }

        [Fact]
        public void Valid_CheckNumberOfItemsPerPage_First_Page_Total_11_PageSize_5()
        {
            Pagina.Pagina pagination = new(5, 11);
            Assert.True(pagination.GetItemCountOnPage() == 5);
        }

        [Fact]
        public void Valid_CheckNumberOfItemsPerPage_LastPage_Total_11_PageSize_5()
        {
            Pagina.Pagina pagination = new(5, 11);
            pagination.GetNextPage();
            pagination.GetNextPage();
            pagination.GetNextPage();
            Assert.True(pagination.GetItemCountOnPage() == 1);
        }

        [Fact]
        public void Valid_GoToPage_1_PageSize_2_Items_11()
        {
            Pagina.Pagina pagination = new(2, 11);
            pagination.GoToPage(1);
            Assert.True(pagination.GetCurrentPageNumber() == 1);
        }
        [Fact]
        public void Valid_GoToPage_2_PageSize_2_Items_11()
        {
            Pagina.Pagina pagination = new(2, 11);
            pagination.GoToPage(2);
            Assert.True(pagination.GetCurrentPageNumber() == 2);
        }

        [Fact]
        public void Valid_GoToPage_3_PageSize_2_Items_11()
        {
            Pagina.Pagina pagination = new(2, 11);
            pagination.GoToPage(3);
            Assert.True(pagination.GetCurrentPageNumber() == 3);
        }

        [Fact]
        public void Valid_GoToPage_4_PageSize_2_Items_11()
        {
            Pagina.Pagina pagination = new(2, 11);
            pagination.GoToPage(4);
            Assert.True(pagination.GetCurrentPageNumber() == 4);
        }

        [Fact]
        public void Valid_GoToPage_5_PageSize_2_Items_11()
        {
            Pagina.Pagina pagination = new(2, 11);
            pagination.GoToPage(5);
            Assert.True(pagination.GetCurrentPageNumber() == 5);
        }

        [Fact]
        public void Valid_GoToPage_6_PageSize_2_Items_11()
        {
            Pagina.Pagina pagination = new(2, 11);
            pagination.GoToPage(6);
            Assert.True(pagination.GetCurrentPageNumber() == 6);
        }

        [Fact]
        public void InValid_StartOn_P1_GoToPage_7_PageSize_2_Items_11()
        {
            Pagina.Pagina pagination = new(2, 11);
            pagination.GoToPage(7);
            Assert.True(pagination.GetCurrentPageNumber() == 1);
        }

        [Fact]
        public void InValid_StartOn_P2_GoToPage_7_PageSize_2_Items_11()
        {
            //P1
            Pagina.Pagina pagination = new(2, 11);
            //P2
            pagination.GetNextPage();
            pagination.GoToPage(7);
            //Must stay on the page it was - must not move on.
            Assert.True(pagination.GetCurrentPageNumber() == 2);
        }

        [Fact]
        public void InValid_StartOn_P3_GoToPage_7_PageSize_11_Items_23()
        {
            //Total pages - 3
            //P1
            Pagina.Pagina pagination = new(11, 23);
            //P2
            pagination.GetNextPage();
            pagination.GetNextPage();
            pagination.GoToPage(7);
            //On failure - must stay on the page it was - must not move on.
            Assert.True(pagination.GetCurrentPageNumber() == 3);
        }

        [Fact]
        public void InValid_StartOn_P1_GoToPage_3_PageSize_11_Items_23_CheckPAgeNumberCaption()
        {
            //Total pages - 3
            //P1
            Pagina.Pagina pagination = new(11, 23);
            //P3
            pagination.GoToPage(3);
            Assert.True(pagination.GetPageNumberCaption() == "3/3");
        }

        [Fact]
        public void Valid_GotLastPage()
        {
            Pagina.Pagina pagination = new(11, 23);
            pagination.GoToPage(2);
            pagination.GoToLastPage();
            Assert.True(pagination.GetPageNumberCaption() == "3/3");
        }

        [Fact]
        public void Valid_GoFirstPage()
        {
            Pagina.Pagina pagination = new(11, 23);
            pagination.GoToPage(3);
            pagination.GoToFirstPage();
            Assert.True(pagination.GetPageNumberCaption() == "1/3");
        }

    }

}