
def OldPhonePad(input_string):
    KEYS = {'1': "&'(", '2': "ABC", '3': "DEF", '4': "GHI", '5': "JKL",
            '6': "MNO", '7': "PQRS", '8': "TUV", '9': "WXYZ", '0': " "}  # Phone key pad dictionary

    sb, prevChar, consecutiveCount = '', '', 0  # variables

    for c in input_string:
        if c == "#":  # Send
            return sb
        elif c == "*":  # Backspace
            sb = sb[:-1:]
            prevChar = ''
        elif c == " ":  # Handling the pause
            prevChar = ''
        else:
            if c == prevChar:  # Handle pressing the same button multiple times
                if consecutiveCount == len(KEYS[c]):  # Cycle back, Ex: OldPhonePad("44") == OldPhonePad("44444") == H
                    consecutiveCount = 0
                sb = sb[:-1:]
                sb += KEYS[c][consecutiveCount]
                consecutiveCount += 1

            else:  # Handling button press
                sb += KEYS[c][0]
                prevChar = c
                consecutiveCount = 1


if __name__ == '__main__':
    print(OldPhonePad("4433555 55566608 88777444666*664#"))
