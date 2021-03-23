A tool to adjust IP Address and Subnet mask I use for working with PLC's and Cameras at work.


This is a complete re-write of IPSetter (VB.NET) 
Now I will  use this to try and further my understanding of C# language instead

version 0.0.1.0 is completly re-written from scratch to be identical to IpSetter (VB.NET version) going forward this is the only repository that will be worked on.

only differences is how the setting of the IP addressed and DHCP are handled. Instead of invoding a CMD process it is now done in code.

as of Mar 22 2021 all IP changes are completed using a Helper Class which is alot more efficient.
The Class is used in the following project, and was too compocated for my needs. Therefor I trimmed out what was required and coded my own project around it.

https://www.codeproject.com/Articles/6975/SwitchNetConfig-Laptop-users-quickly-switch-networ


