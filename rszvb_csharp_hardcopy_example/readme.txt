README.TXT

Rohde&Schwarz ZVB Vector Network Analyzer Hardcopy Application Example for C#

Hardcopy Example

Version: 1.1, 07/2011

Contents:

1.0  Introduction

2.0  Prerequisites

3.0  How to use this example

4.0  Known Defects

5.0  Revision History

6.0  Example Files
----------------------------------------------------------------------------

1.0  Introduction

This example explains how to use the C# Instrument driver.

2.0  Prerequisites

- Microsoft Visual Studio 2008 (or higher)
- National Instruments NI-488.2 Software 1.60 (or higher) (GPIB only)
- National Instruments VISA 4.0 or Agilent I/O Library 14 (or higher)
- rszvb VXIpnp Instrument Driver

3.0  How to use this example

After installing instrument driver unzip the example and open solution file. 
Make an executable file and run it.
To use the example, fill in the Resource String (by default it is 
GPIB0::20::INSTR). Select proper instrument model and Save File Path
and press Save button to save instrument's screen into specified file.
You may press Save button again to make new hardcopy.
Example could be exited by closing the window.

4.0  Known Defects

none

5.0  Revision History

1.0, 07/2009, Juergen Straub
    Created.
1.1, 0/2011, Juergen Straub
    Visual Studio Conversion errors fixed.
		
6.0  Example Files

ExampleForm.cs                      - example source code
ExampleForm.Designer.cs             - example GUI source code
rzvb_hardcopy_example.sln       		- example solution file
rszvb_hardcopy_example.csproj    		- example project file
AssemblyInfo.cs                     - C# generated file
ExampleForm.resx                    - C# generated file
RS.ico                              - icon file
readme.txt                          - this file

-----------------------------------------------------------------------------
Should you have any technical questions please contact 
the hotline of Rohde & Schwarz Vertriebs-GmbH
Rohde & Schwarz Support Center
e-mail: CustomerSupport@rohde-schwarz.com
-----------------------------------------------------------------------------
