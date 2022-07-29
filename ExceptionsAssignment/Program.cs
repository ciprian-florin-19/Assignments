using ExceptionsAssignment;
using System.Diagnostics;
#if DEBUG
Debug.WriteLine("Debugging started!");

//trigger breakpoint here
Debug.Assert(false);
#endif
#if RELEASE
Console.WriteLine("---begin testing---");
LabRat labRat;
try
{
    labRat = new LabRat(new TestClass("test"));
    //labRat = new LabRat(new TestClass(null));
    //labRat = new LabRat(null);
    labRat.BeginTesting();
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException);
}
finally
{
    Console.WriteLine("---end testing---");
}
#endif