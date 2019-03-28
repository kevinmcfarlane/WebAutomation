# F# Web Automation

Demonstrates use of [canopy], a web testing framework that can also be used for _ad hoc_ web automation as illustrated here.

It is a .NET Core Console application with a module that contains some functions that automate job searches at [JobServe] and one that displays job stats at [IT Jobs Watch].

Canopy abstracts away the Selenium automation API making it much easier to write automation code by referencing HTML Element IDs and using simple commands such as "click."

Use of the library does not require knowledge of advanced features of F#. The example here uses Firefox but it is fairly easy to modify it to use Google Chrome, which the example on the Canopy home page uses.

[canopy]: <https://lefthandedgoat.github.io/canopy/>
[JobServe]: <https://www.jobserve.com/>
[IT Jobs Watch]: <https://www.itjobswatch.co.uk/>