# OldPhonePad
C# Coding Challenge

This repository consists of both C# and Python code for a coding challenge below.

Imagin an old phone keypad with alphabetical letters, a backspace key, and a send button. Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.

For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’. You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.


Prompt:

Please design and document a class of method that will turn any input to OldPhonePad into the correct output. Assume that a send “#” will always be included at the end of every input.


Example:

OldPhonePad(“33#”) => output: E
OldPhonePad(“227*#”) => output: B
OldPhonePad(“4433555 555666#”) => output: HELLO
OldPhonePad(“8 88777444666*664#”) => output: TURING
OldPhonePad("699906626330444777702266622#") => output: MY NAME IS BOB


Solution:

OldPhonePad - C# (Usage)
1) dotnet run (Program.cs)
2) dotnet test (Program_test.cs)

OldPhonePad - Python  (Usage)
1) python3 main.py (main script)
2) python3 main_test.py (test cases)


Cheers!
