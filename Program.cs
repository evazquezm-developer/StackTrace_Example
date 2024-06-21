using System;
using System.Diagnostics;

static void EntryPoint()
{
    string lastName = string.Empty;

    if ( string.IsNullOrEmpty( lastName) )
    {
        throw new Exception("lastname variable cannot be null or empty.");
    }

    Console.WriteLine("End application.");
}

try{
     EntryPoint();
}
catch(Exception ex) {
    Console.WriteLine("\nCaught exception:");
    Console.WriteLine("StackTrace data: ");
    Console.WriteLine( ex.StackTrace);

    Console.WriteLine("\nStackTrace by properties: ");
    StackTrace stackTrace = new StackTrace(ex, true);

    for (int inx = 0; inx < stackTrace.FrameCount; inx++) {
        StackFrame frame = stackTrace.GetFrame(inx);

        Console.WriteLine($"Method      : { frame.GetMethod().Name}");
        Console.WriteLine($"File        : { frame.GetFileName() }");
        Console.WriteLine($"Line number : { frame.GetFileLineNumber() }");
    }
}
