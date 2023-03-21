import unittest
from main import OldPhonePad


class TestOldPhonePad(unittest.TestCase):
    def test_1(self): self.assertEqual(OldPhonePad("33#"), "E")
    def test_2(self): self.assertEqual(OldPhonePad("227 *  #"), "B")
    def test_3(self): self.assertEqual(OldPhonePad("4433555 555666#"), "HELLO")
    def test_4(self): self.assertEqual(OldPhonePad("8 88777444666 * 664#"), "TURING")
    def test_5(self): self.assertEqual(OldPhonePad("4433555 55566608 88777444666*664#"), "HELLO TURING")


if __name__ == '__main__':
    unittest.main()
