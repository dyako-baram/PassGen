using CommandLine;
using CommandLine.Text;
using PasswordGenerator;

Password pwd;

Parser.Default.ParseArguments<Options>(args)
    .WithParsed<Options>(o =>
    {
        pwd=new Password(includeLowercase: !o.LowerCase, includeUppercase: !o.UpperCase, includeNumeric: !o.Numbers, includeSpecial: !o.Specials, passwordLength: o.Length);
        
        string pass =pwd.Next();
        Console.Write("The Password ");
        Console.ForegroundColor=ConsoleColor.Blue;
        Console.Write(pass);
        Console.ResetColor();
        Console.Write(" has been copied to your clipboard");
        TextCopy.ClipboardService.SetText(pass);
    });

class Options
{
    [Option('l', "length", Default = 15 ,Required = false, HelpText = "Set the length of the password")]
    public int Length { get; set; }
    [Option('u', "uppercase",Default = false,  Required = false, HelpText = "Remove uppercase from genreated password")]
    public bool UpperCase { get; set; }
    [Option('c', "lowercase",Default = false, Required = false, HelpText = "Remove lowercase from genreated password")]
    public bool LowerCase { get; set; }
    [Option('n', "number",Default = false, Required = false, HelpText = "Remove numbers from genreated password")]
    public bool Numbers { get; set; }
    [Option('s', "special",Default = false, Required = false, HelpText = "Remove specials from genreated password")]
    public bool Specials { get; set; }
    

}
