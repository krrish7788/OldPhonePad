using System;
using System.Text;
using System.Collections.Generic;

namespace MyApplication
{
  class MobileProgram {
  	private static readonly Dictionary<char, string> KEYS = new Dictionary<char, string>() {
    	{'1', "&'("}, {'2', "ABC"}, {'3', "DEF"}, {'4', "GHI"}, {'5', "JKL"}, 
        {'6', "MNO"}, {'7', "PQRS"}, {'8', "TUV"}, {'9', "WXYZ"}, {'0', " "}
	};
	public static string OldPhonePad(string input) {
      StringBuilder sb = new StringBuilder();
      char prevChar = ' ';
      int consecutiveCount = 0;

      foreach (char c in input) {
      	 if (c == '#'){
            break;
         } else if (c == '*') {
         	sb.Remove(sb.Length - 1, 1);
         	prevChar = ' ';
         } else if (c == ' '){
         	prevChar = ' ';
         } else {
         	if (c == prevChar){
                if (consecutiveCount == KEYS[c].Length){
                    consecutiveCount = 0;
                }
				sb.Remove(sb.Length - 1, 1);
                sb.Append(KEYS[c][consecutiveCount]);
                consecutiveCount++;
            }
            else {
            	sb.Append(KEYS[c][0]);
                prevChar = c;
                consecutiveCount = 1;
            }            
         }
      }
	  return sb. ToString();
    }
    
    public static void Main(string[] args) {
      Console.WriteLine(OldPhonePad("4433555 55566608 88777444666*664#"));
    }
  }
}

