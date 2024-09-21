using System.Text;
using Pn = Pagina.Pagina;
using Pu = PaginationCUtility.PaginationCUtility;

namespace PaginationConsoleWithListUtility
{
    /// <summary>
    /// 
    /// </summary>

    public static class PaginationConsoleWithListUtility
    { 
        public static string GetResults(List<string> menuOptions, Pn pagination, StringBuilder sbInstructions)
        {
            int counter = Convert.ToInt32(pagination.GetFirstItemNumberOnPage0Based());
            StringBuilder? result = new();
            result.Clear();
            result.AppendLine(Pu.cVersionCaption);
            result.AppendLine(Pu.cLine);
            result.AppendLine(Pu.cMenuCaption);
            result.AppendLine(Pu.cLine);

            var s = menuOptions.GetRange(Convert.ToInt32(pagination.GetFirstItemNumberOnPage0Based()), Convert.ToInt32(pagination.GetItemCountOnPage()));
            for (int i = 0; i < s.Count; i++)
            {
                string? item = s[i];
                counter++;
                result.AppendLine($"{counter}: {item}");
            }
            s.Clear();
            result.AppendLine(Pu.cLine);
            result.AppendLine($"{Pu.cPagesCaption}{pagination.GetPageNumberCaption()}");
            result.AppendLine(Pu.cLine);
            result.AppendLine();
            result.AppendLine(Pu.cLine);
            result.AppendLine(Pu.cInstructionsCaption);
            result.AppendLine(Pu.cLine);
            result.AppendLine(sbInstructions.ToString());
            result.AppendLine(Pu.cLine);
            result.AppendLine();
            result.Append(Pu.cOptionCaptionSpace);

            return result.ToString();
        }

        public static string PaginationImplementation(List<string> menuOptions, uint pageSize, List<string>? inputSimulate)
        {
            string result = string.Empty;

            if (menuOptions.Count > 0)
            {
                Pn pagination = new(pageSize, Convert.ToUInt32(menuOptions.Count));
                StringBuilder sbInstructions = new();
                StringBuilder validInputs = new();

                result = InitialPaginationImplementation(menuOptions, pagination, sbInstructions, validInputs);
                bool isSimulate = (inputSimulate != null);
                OutputToConsole(result, true, false, isSimulate, Pu.cEmptyString);

                bool continueWithOptions = true;
                bool error = false;

                while (continueWithOptions)
                {
                    if (isSimulate)
                    {
                        StringBuilder simulate = new();
                        if (inputSimulate != null)
                        {
                            foreach (string input in inputSimulate)
                            {
                                result = InnerImplementation(menuOptions, isSimulate, pagination, sbInstructions, validInputs, ref continueWithOptions, ref error, input);
                                simulate.AppendLine(result);
                            }
                        }
                        continueWithOptions = false;
                        result = simulate.ToString();
                    }
                    else
                    {
                        string? input = Console.ReadLine();
                        result = InnerImplementation(menuOptions, isSimulate, pagination, sbInstructions, validInputs, ref continueWithOptions, ref error, input);
                    }
                }
            }

            return result;
        }

        private static string InnerImplementation(List<string> menuOptions, bool bSimulate, Pn pagination, StringBuilder sbInstructions, StringBuilder validInputs, ref bool continueWithOptions, ref bool error, string? input)
        {
            string result = PaginationImplementation(input, menuOptions, pagination, sbInstructions, validInputs, ref continueWithOptions);
            string ConsoleOutput = OutputToConsole(result, !error, error, bSimulate, input);
            return ConsoleOutput;
        }

        public static string InitialPaginationImplementation(List<string> menuOptions, Pn pagination, StringBuilder sbInstructions, StringBuilder validInputs)
        {
            sbInstructions.Append(Pu.cNextLastCaption);
            validInputs.Append(Pu.cNextExitOption);
            AddPagePart(pagination, sbInstructions, validInputs);
            sbInstructions.Append(Pu.cExitCaption);
            string result = GetOutput(menuOptions, pagination, sbInstructions);
            return result;
        }

        private static void AddPagePart(Pn pagination, StringBuilder sbInstructions, StringBuilder validInputs)
        {
            for (int i = 1; i <= pagination.TotalPages; i++)
            {
                validInputs.Append(Pu.cPipeSeparator + Pu.cPageOption + i);
            }
            sbInstructions.Append(Pu.cPageNumberCaption);
        }

        static string OutputToConsole(string result, bool clear, bool readLine, bool simulate, string? input)
        {
            string output = OutputToConsoleSimulate(result, clear, readLine, input);
            if (!simulate)
            {
                if (output.Contains(Pu.cClearScreen)) { Console.Clear(); }
                if (output.Contains(Pu.cWriteLine)) { Console.WriteLine(result); }
                if (output.Contains(Pu.cReadLine)) { Console.ReadLine(); }
            }
            return output;
        }

        public static string OutputToConsoleSimulate(string result, bool clear, bool readLine, string? input)
        {
            StringBuilder sbResultSim = new();
            if (input == null) { sbResultSim.AppendLine(Pu.cNoInput); } else { sbResultSim.AppendLine($"{Pu.cInputCaption}{input}"); }
            if (clear) sbResultSim.AppendLine(Pu.cClearScreen);
            if (readLine) sbResultSim.AppendLine(Pu.cReadLine);
            sbResultSim.AppendLine(Pu.cWriteLine);
            sbResultSim.Append(result);
            return sbResultSim.ToString();
        }
        public static string PaginationImplementation(string? input, List<string> MenuItems, Pn pagination, StringBuilder sbInstructions, StringBuilder sbValidInputs, ref bool continueOptions)
        {
            bool refresh = false;
            string? result = String.Empty;
            if (!string.IsNullOrEmpty(input) && (sbValidInputs.ToString().Contains(input)))
            {
                sbValidInputs.Clear();
                sbValidInputs.Append(Pu.cLastFirstNextBackExitOptions);

                continueOptions = (input != Pu.cExit);

                switch (input[..1])
                {
                    case Pu.cNextOption:
                        pagination.GetNextPage();
                        refresh = true;
                        break;
                    case Pu.cBackOption:
                        pagination.GetPreviousPage();
                        refresh = true;
                        break;
                    case Pu.cPageOption:
                        bool validNumber = uint.TryParse(input.AsSpan(1, input.Length - 1), out UInt32 page);
                        if (validNumber)
                        {
                            pagination.GoToPage(page);
                            refresh = true;
                        }
                        else
                        {
                            result = InvalidInput(input, MenuItems, pagination, sbInstructions);
                        }
                        break;
                    case Pu.cFirstPageOption:
                        pagination.GoToFirstPage();
                        refresh = true;
                        break;
                    case Pu.cLastPageOption:
                        pagination.GoToLastPage();
                        refresh = true;
                        break;
                    default:
                        result = InvalidInput(input, MenuItems, pagination, sbInstructions);
                        break;
                }

                sbInstructions.Clear();
                sbInstructions.Append(Pu.cNextBackFirstLastOptionsCaption);
                if (pagination.IsLastPage())
                {
                    sbInstructions.Clear();
                    sbInstructions.Append(Pu.cFirstBackCaption);
                    sbValidInputs.Clear();
                    sbValidInputs.Append(Pu.cFirstBackExitOption);
                }
                if (pagination.IsFirstPage())
                {
                    sbInstructions.Clear();
                    sbInstructions.Append(Pu.cNextLastCaption);
                    sbValidInputs.Clear();
                    sbValidInputs.Append(Pu.cNextExitOption);
                }
                AddPagePart(pagination, sbInstructions, sbValidInputs);
                sbInstructions.Append(Pu.cExitCaption);
                if (refresh)
                {
                    result = GetOutput(MenuItems, pagination, sbInstructions);
                }
            }
            else
            {
                result = InvalidInput(input, MenuItems, pagination, sbInstructions);
            }
            return result;
        }

        private static string InvalidInput(string? input, List<string> MenuItems, Pn pagination, StringBuilder sbInstructions)
        {
            string result = GetOutput(MenuItems, pagination, sbInstructions);
            result += $"{Pu.cInvalidInput} {input}";
            result = result.Replace(Pu.cOption, Pu.cError);
            result += Pu.cNewLine + Pu.cLFOption;
            return result;
        }

        static string GetOutput(List<string> strings, Pn pagination, StringBuilder sb)
        {
            string result = GetResults(strings, pagination, sb);
            return result;
        }
    }
}
