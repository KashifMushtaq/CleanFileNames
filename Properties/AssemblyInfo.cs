using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Cleans File Names in the Windows History Backup")]
[assembly: AssemblyDescription("Tool search for all the files in the selected root directory and tries to find the start ' (' and end ')' tag in the file names. If it finds it, it removes it from the name. It is useful to clean up the Windows History (files backup) if you could not restore using windows backup. If history backup has multiple files with the same name (after removing date from name), it deletes the old file and keeps the new one.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("eLogic Builders Inc")]
[assembly: AssemblyProduct("CleanFileNames")]
[assembly: AssemblyCopyright("Copyright ©  2024 eLogic Builders Inc")]
[assembly: AssemblyTrademark("eLogic Builders Inc")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b5818bdd-538d-4fe9-86b4-638f245d2787")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
