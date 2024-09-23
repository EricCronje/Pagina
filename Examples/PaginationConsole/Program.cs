using P = Pagina.Pagina;

const string cCaptionPageSize = "Page size?";
const string cCaptionTotalCount = "Total items?";

const string cCaptionPage = "Page:";
//0_
const string cInputQuestion = "Choice?";
const string cOptionExit = "x";
const string cOptionCaptionExit = " (exit)";
const string cOptionNext = "n";
const string cOptionCaptionNext = " (next)";
const string cOptionBack = "b";
const string cOptionCaptionBack = " (back)";
//1. Add new const for cOption<?> and cOptionCaption<?> {4576CA0A-29C1-4469-83C5-E20C29035156}

const string cCaptionInitialInstruction =
    $"{cOptionNext}{cOptionCaptionNext}" +
    $" or {cOptionBack}{cOptionCaptionBack}" +
    //2. Add new " or {cOption<?>}{cOptionCaption<?>} "OptionCaption {90362A2D-3625-4E8A-8A4E-EA4264A79FE5}
    $" or {cOptionExit}{cOptionCaptionExit}"
    ;

Console.WriteLine(cCaptionPageSize);
_ = uint.TryParse(Console.ReadLine(), out uint pageSize);
Console.WriteLine(cCaptionTotalCount);
_ = uint.TryParse(Console.ReadLine(), out uint totalCount);

Console.Clear();
P pagination = new(pageSize, totalCount);

string? input = string.Empty;

ShowOutput(cCaptionPage, cCaptionInitialInstruction, pagination);

while (input != cOptionExit)
{
    Console.WriteLine(cInputQuestion);
    input = Console.ReadLine();

    switch (input)
    {
        case cOptionNext:
            pagination.GetNextPage();
            break;
        case cOptionBack:
            pagination.GetPreviousPage();
            break;
        //3. Add new case section; OptionCase {8F2650E5-807C-4B9B-BF2F-1C17CA5BEC29}
        default:
            break;
    }

    Console.Clear();
    ShowOutput(cCaptionPage, cCaptionInitialInstruction, pagination);
}

static void ShowOutput(string cCaptionPage, string cCaptionInitialInstruction, P pagination)
{
    Console.WriteLine($"{cCaptionPage} {pagination.GetPageNumberCaption()}");
    //4. Add display item {A17784DA-A832-41ED-A613-6D9973213F94}
    Console.WriteLine(cCaptionInitialInstruction);
}