# OldPhonePad
## C# Coding Challenge

### This repository consists of both C# and Python code for a coding challenge below.

Here is an old phone keypad with alphabetical letters (2-9), a space key (0), a backspace key (*), and a send key (#). Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.

![Example of an old phone keyboard](https://github.com/krrish7788/OldPhonePad/blob/main/Example%20of%20a%20old%20phone%20keyboard.jpg)

For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’. You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.


### Prompt:

Please design and document a class of method that will turn any input to OldPhonePad into the correct output. Assume that a send “#” will always be included at the end of every input.


### Example:

1) OldPhonePad(“33#”) => output: E
2) OldPhonePad(“227*#”) => output: B
3) OldPhonePad(“4433555 555666#”) => output: HELLO
4) OldPhonePad(“8 88777444666*664#”) => output: TURING
5) OldPhonePad("699906626330444777*777702266622#") => output: MY NAME IS BOB


### Solution:

> $ git clone https://github.com/krrish7788/OldPhonePad.git

**OldPhonePad_C# (Usage)**
> $ cd OldPhonePad_C# 
1) dotnet run (Program.cs for main script)
2) dotnet test (Program_test.cs for test cases)

**OldPhonePad_Python  (Usage)**
> $ cd OldPhonePad_Python
1) python3 main.py (main script)
2) python3 main_test.py (test cases)


**Cheers!**
