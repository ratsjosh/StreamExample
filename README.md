# StreamExample
Understand how the .Seek operation of a stream works

# What does the project contains?
1. Console application
2. Example file

# Things to take note
- letter 'a' = offset 3 in Seek method.
- The reason for this is the first two bytes represent the encoding of file.
- Read the origin first. By doing so, It will guide you on where the stream starts. After that, count the offset.

# Resource(s)
Code => https://msdn.microsoft.com/en-us/library/883dhyx0(v=vs.110).aspx
