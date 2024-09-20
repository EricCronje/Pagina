// See https://aka.ms/new-console-template for more information
using Pd = PaginationData.PaginationData;
List<string> menuOptions;
menuOptions = Pd.GetData();
PaginationConsoleWithListUtility.PaginationConsoleWithListUtility.PaginationImplementation(menuOptions, 2, null);
