# InterSharp
[Intercept](https://github.com/intercept/intercept) C# support

# Usage
After compiling the DLL's for Wrapper, Managed, and the main dll place the InterSharp_x64.dll in intercept folder. Place the other two DLL's in the main arma directory.

# Function Wrapping
Basically look at the sample SQF time command that I have ported. I believe all commands that have been executed as soon as Arma starts (so if you call SQF.time() when arma starts) it will give 0 and eventually crash. However, if you wait until you load a map it will work perfectly. This is just how memory works.

# Type wrapping
TODO

# How it works and why this method
After failed attempts on hosting CLR I have decided to just go along with creating an exported function from C# and calling it from C++ and wrapping native methods in order to get 2 way communication. The other option is IPC which I found too slow. This method works the best.

# ToDo
1. Wrap all functions
2. Wrap types
3. Wrap Event Handlers
4. Use AppDomain to load multiple assemblies and utilize the InterSharpManaged.dll as a loader and nothing more. 
