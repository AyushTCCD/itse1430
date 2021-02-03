/*
 * ITSE 1430
 * Spring 2021
 * Ayush Bhattarai
 */ 
using System;

namespace MovieLibrary
{
    class Program
    {
        static void Main ()  //string[] args)
        {
            AddMovie();
            DisplayMainMenu();
        }

        // modifiers* T identifier ( [parameters] ) { S* }
        // function declaration - function-signature that tells the compiler a funciton exists
        // function signature- T identifier (parameters)
        // function definition- function declaration + implementation
        private static void DisplayMainMenu ()
        {
            //Display output - equivalent to printf, cout
            //Console.Write();
            Console.WriteLine("Movie Library");  //String literals are enclose in double quotes
            Console.WriteLine("-------------");

            Console.WriteLine("A) dd Movie");
            Console.WriteLine("Q) uit");

            //Console input
            string input = Console.ReadLine(); // string ReadLine()

            //TODO: Validate input
            //TODO: Reutrn selection option 
        }

        static void AddMovie ()
        {
            // title, release year, run length (min), description, rating
            Console.Write("Enter a title: ");
            string title = Console.ReadLine();

            Console.Write("Enter an optional description: ");
            string description = Console.ReadLine();

            Console.Write("Enter a release year: ");
            int releaseYear = ReadInt32();

            Console.Write("Enter the run length in minutes: ");
            int runLenth = ReadInt32();

            Console.Write("Enter the rating: ");
            string rating = Console.ReadLine();

            Console.Write("Is a Classic (Y/N)? ");
            bool isClassic = ReadBoolean();
        }

        static bool ReadBoolean ()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            return true;
        }
        //Reads an integer value

        static int ReadInt32 ()
        {
            string input = Console.ReadLine();

            //Convert string to int
            int value = Int32.Parse(input);

            return value;
        }

        void DemoTypes ()
        {
            //Primitive types - types known by the compiler 

            //Integrals - signed
            // sbyte |1 byte | -128 to 127
            // short |2 bytes | +-32k
            // int | 4 bytes | +-2 billion | default
            // long |8 bytes | really large 
            sbyte sbyteValue = 10;
            short shortValue = 10;
            int hours = 20;
            long startsInGalaxy = 100000000;

            byte byteCode = 0xAF;
            ushort shortCode = 0x1045;
            uint hourCode = 0x145678;
            ulong longCode = 0b0010_1010_1111;

            //integrals - unsigned
            // byte |1 byte | 0 to 255
            // short |2 bytes | 0 to 64k
            // int | 4 bytes | 0 to 4 billion
            // long |8 bytes | really large 
        }


        // USE Pascal casing (capitalize on word boundaries - e.g. GetName, CalculateGrade
        void DemoVariables ()
        {
            // variable-declartion ::= T id [ = E ] ;
            // block-style delcations -> put all delcarations at top of function, grouped together
            // inline-style declaration -> declare variables as needed 
            string textInput = "";
            //other code ...
            //textInput =""; //should always intialize variables a part of declaration
         
            // assignment-statement ::= id = E ;
            // id - must be an lvalue (left value)
            // E - any rvalue (right value) provided it is type compatible
            // operstor precedence - orders in which operators are eveluated 4 + 5 * 10 = 54
            // operator associativity - which operand evaluates first (left, right) - right
            //textInput = "Hello";

            //All reads of variables must be definitely assigned
            // Compiler must be able to verify that all possible code paths to the read ensure that
            // variable is first written to 
            string textInput2 = textInput;

            //Multiple declarations
            // variable-declaration ::=T id [ =E ] { , id }* ;
            int x = 10, y = 12;

            //identifier rules
            // 1. Must start with letter or underscore
            // 2. Consist of letter or digits or underscores
            // 3. Must be unique in scope
            // 4. Cannot be a keyword

            //Variable name guidelines
            // nouns, desciptive (e.g. firstName, payRate, hours)
            // generally less than 15 characters long
            // are not single letters (e.g. x, y)
            // no abbrevations or acronyms unless they are well known (good: ok, bad: nbr, num)
            // USE camel casing (capitalize on word boundaries, lowercase first word - e.g. firstName, payRate, hours)
        
        }


        //Data to collect - title, genre, release year, actors. runtime, director, rating
        // title, release year, run length (min), description, rating
    }
}
