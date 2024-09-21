using System.Text;
using Pnu = PaginationConsoleWithListUtility.PaginationConsoleWithListUtility;
using TPICU = TestPaginationIntegrationCUtility.TestPaginationIntegrationCUtility;
using Pd = PaginationData.PaginationData;
using Pcu = PaginationCUtility.PaginationCUtility;

namespace TestProjectPaginationConsoleWithList
{
    public class UnitTestTestProjectPaginationConsoleWithList
    {
        

        [Fact]
        public void Valid_Initial_NoOptionsSelected()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();

            string result = Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            string expected = TPICU.cExpectedPage1;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Next_Option_Page1()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage2;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Next_Option_Page2()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage3;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Next_Option_Page3()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage4;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Next_Option_Page4()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage4;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Next_Option_Page5()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage5;
            Assert.True(result == expected);
        }

        [Fact]
        public void InValid_Next_Option_AlreadyOnPage5()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //p2
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p3
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p4
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p5
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p5 - next
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage5InvalidOptionN;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Back_Option_OnPage5_AfterFailing()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //p2
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p3
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p4
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p5
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p5 - n - to fail
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            input = "b";
            //p4 - back
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage4;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Back_Page5_Now_Page4()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            //Page 1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //Page 2
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //Page 3
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //Page 4
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //Page 5
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //Page 5 - Next again
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            input = "b";
            //Page 5 - Back - Page 4
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage4;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Back_Page4_To_Page3()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            input = "b";
            //P3
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedPage3;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Back_Page3_To_Page2()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //p2
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p3
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p4
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p5
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            input = "b";
            //p4 - back
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p3 - back
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //P2 - back
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);

            string expected = TPICU.cExpectedPage2;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Back_Page2_To_Page1()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "n";
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //p2
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p3
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p4
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p5 - Next
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p5 - Fail
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            input = "b";
            //P4 - back
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //P3 - back
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //p2 - back
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            //P1
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);

            string expected = TPICU.cExpectedPage1;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_Next_On_Page1_To_Page2_PaginationImplementation_Simulation()
        {
            List<string> SimulationInputs = ["n"];
            string result = Pnu.PaginationImplementation(Pd.GetData(), 2, SimulationInputs);
            string expected = TPICU.cSimExpectedPage2;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_From_P1_N_N_TO_P3_Simulation()
        {
            List<string> SimulationInputs = ["n", "n"];
            string result = Pnu.PaginationImplementation(Pd.GetData(), 2, SimulationInputs);
            string expected = TPICU.cSimExpectedPage1NextNextPage3;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_P1_To_P5_Then_B_P4_Simulation()
        {
            List<string> SimulationInputs = ["n", "n", "n", "n", "b"];
            string result = Pnu.PaginationImplementation(Pd.GetData(), 2, SimulationInputs);
            string expected = TPICU.cSimExpectedP1ToP5BackP4;
            Assert.True(result == expected);
        }

        [Fact]
        public void Valid_GoToP2_PageSize2_9Items()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "p2";
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //p2
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Assert.True(pagination.GetCurrentPageNumber() == 2);
        }

        [Fact]
        public void Valid_GoToP3_PageSize2_9Items()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "p3";
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //p3
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Assert.True(pagination.GetCurrentPageNumber() == 3);
        }

        [Fact]
        public void Valid_GoToP5_PageSize2_9Items()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "p5";
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //p3
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Assert.True(pagination.GetCurrentPageNumber() == 5);
        }

        [Fact]
        public void InValid_GoToP6_PageSize2_9Items()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            string? input = "p6";
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            //p6 - invalid - stay on page 1 give error
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            Assert.True(pagination.GetCurrentPageNumber() == 1);
        }

        [Fact]
        public void Simulate_Valid_P1_To_P5_UsingGotoPage()
        {
            List<string> SimulationInputs = ["p1", "p2", "p3", "p4", "p5"];
            string result = Pnu.PaginationImplementation(Pd.GetData(), 2, SimulationInputs);
            string expected = TPICU.cExpectedSimP1ToP5GotoPage;
            Assert.True(result == expected);
        }

        [Fact]
        public void Simulate_Valid_P1_P2_P5_P3_P2_UsingGotPage()
        {
            List<string> SimulationInputs = ["p1", "p2", "p5", "p3", "p2"];
            string result = Pnu.PaginationImplementation(Pd.GetData(), 2, SimulationInputs);
            string expected = TPICU.cExpectedSimP12532GoToPage;
            Assert.True(result == expected);
        }

        [Fact]
        public void Simulate_InValid_AnotherInvalidEntry_P5_n_P1_b_P3_InvalidEntry_UsingGotPage()
        {
            List<string> SimulationInputs = ["AnotherInvalidEntry", "p5", "n", "p1", "b", "p3", "InvalidEntry"];
            string result = Pnu.PaginationImplementation(Pd.GetData(), 2, SimulationInputs);
            string expected = TPICU.cExpectedP5NextP1BackP3InvalidEntry;
            Assert.True(result == expected);
        }

        [Fact]
        public void Simulate_InValid_Numbers_1_2_3_4_900()
        {
            List<string> SimulationInputs = ["1", "2", "3", "4", "900"];
            string result = Pnu.PaginationImplementation(Pd.GetData(), 2, SimulationInputs);
            string expected = TPICU.cExpectedSimInvalidNumbers1_2_3_4_900;
            Assert.True(result == expected);
        }

        [Fact]
        public void Invalid_Numbers_1_2_3_4_900()
        {
            List<string> menuOptions;
            menuOptions = Pd.GetData();
            UInt32 pagesize = 2;
            Pagina.Pagina pagination = new(pagesize, Convert.ToUInt32(menuOptions.Count));
            StringBuilder sbInstructions = new();
            StringBuilder validInputs = new();
            
            bool continueWithOptions = true;
            //p1
            Pnu.InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
            
            string? input = "1";
            //p1 - invalid - stay on page 1 give error
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);

            input = "2";
            //p1 - invalid - stay on page 1 give error
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);

            input = "3";
            //p1 - invalid - stay on page 1 give error
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            input = "4";
            //p1 - invalid - stay on page 1 give error
            Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            input = "900";
            //p1 - invalid - stay on page 1 give error
            string result = Pnu.PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string expected = TPICU.cExpectedInvalidNumbers1_2_3_4_900;

            Assert.True(result == expected);
        }

        [Fact]
        public void VersionTest()
        {
            Assert.True(Pcu.cVersionCaption == "(Version: 5.3.2)");
        }

    }
}