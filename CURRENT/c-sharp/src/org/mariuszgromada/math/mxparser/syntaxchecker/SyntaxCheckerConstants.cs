/* Generated By: CSCC: 4.0 (03/25/2012)  Do not edit this line. SyntaxCheckerConstants.cs */
namespace org.mariuszgromada.math.mxparser.syntaxchecker{


using System;
public class SyntaxCheckerConstants {

  public const int EOF = 0;
  public const int LETTER = 5;
  public const int DIGIT = 6;
  public const int LETTERS = 7;
  public const int INTEGER = 8;
  public const int LEFT_PAR = 9;
  public const int RIGHT_PAR = 10;
  public const int PLUS = 11;
  public const int MINUS = 12;
  public const int MULTIPLY = 13;
  public const int DIV = 14;
  public const int POWER = 15;
  public const int MODULO = 16;
  public const int FACTORIAL = 17;
  public const int PERCENTAGE = 18;
  public const int COMMA = 19;
  public const int SEMICOLON = 20;
  public const int EQ = 21;
  public const int UNIT = 22;
  public const int NEQ = 23;
  public const int LT = 24;
  public const int LEQ = 25;
  public const int GT = 26;
  public const int GEQ = 27;
  public const int OR = 28;
  public const int AND = 29;
  public const int NOT = 30;
  public const int BITNOT = 31;
  public const int IMP = 32;
  public const int CIMP = 33;
  public const int NIMP = 34;
  public const int CNIMP = 35;
  public const int NAND = 36;
  public const int EQV = 37;
  public const int NOR = 38;
  public const int BITWISE = 39;
  public const int XOR = 40;
  public const int CHAR = 41;
  public const int REAL = 42;
  public const int NUMBER = 43;
  public const int NUMBER_CONSTANT = 44;
  public const int IDENTIFIER = 45;
  public const int FUNCTION = 46;
  public const int INVALID_TOKEN = 49;
  public const int UNEXPECTED_CHAR = 50;

  public const int DEFAULT = 0;

  public String[] tokenImage = {
    "<EOF>",
    "\" \"",
    "\"\\t\"",
    "\"\\n\"",
    "\"\\r\"",
    "<LETTER>",
    "<DIGIT>",
    "<LETTERS>",
    "<INTEGER>",
    "\"(\"",
    "\")\"",
    "\"+\"",
    "\"-\"",
    "\"*\"",
    "\"/\"",
    "\"^\"",
    "\"#\"",
    "\"!\"",
    "\"%\"",
    "\",\"",
    "\";\"",
    "<EQ>",
    "<UNIT>",
    "<NEQ>",
    "\"<\"",
    "\"<=\"",
    "\">\"",
    "\">=\"",
    "<OR>",
    "<AND>",
    "\"~\"",
    "\"@~\"",
    "\"-->\"",
    "\"<--\"",
    "\"-/>\"",
    "\"</-\"",
    "<NAND>",
    "\"<->\"",
    "<NOR>",
    "<BITWISE>",
    "\"(+)\"",
    "<CHAR>",
    "<REAL>",
    "<NUMBER>",
    "<NUMBER_CONSTANT>",
    "<IDENTIFIER>",
    "<FUNCTION>",
    "\"[\"",
    "\"]\"",
    "<INVALID_TOKEN>",
    "<UNEXPECTED_CHAR>",
  };

}
}
