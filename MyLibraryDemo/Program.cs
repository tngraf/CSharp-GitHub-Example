// ---------------------------------------------------------------------------
// <copyright file="Program.cs" company="Tethys">
//   Copyright (C) 2020 T. Graf
// </copyright>
//
// Licensed under the MIT License.
// SPDX-License-Identifier: MIT
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied.
// ---------------------------------------------------------------------------

namespace MyLibraryDemo
{
    using System;
    using System.Collections.Generic;
    using MyLibrary;

    /// <summary>
    /// Main application class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("\nDemonstrate MyLibrary");

            if (args.Length < 3)
            {
                Console.WriteLine("Not enough arguments specified");
                Console.WriteLine("Usage: MyLibraryDemo <operation> <operand 1> <operand 2>");
                Console.WriteLine("  operation - mathematical operation: add, subtract, multiply or divide");
                Console.WriteLine("  operand 1 - an integer value");
                Console.WriteLine("  operand 2 - an integer value");
                return;
            } // if

            if (!CheckOperation(args[0]))
            {
                Console.WriteLine("No valid operation specified, must be add, subtract, multiply or divide.");
                return;
            } // if

            if (!int.TryParse(args[1], out var a))
            {
                Console.WriteLine("First operand is no valid integer!");
                return;
            } // if

            if (!int.TryParse(args[2], out var b))
            {
                Console.WriteLine("Second operand is no valid integer!");
                return;
            } // if

            try
            {
                var result = DoCalculation(args[0], a, b);
                Console.WriteLine($"Operation result = {result}\n");
            }
            catch (LibraryException lex)
            {
                Console.WriteLine($"Error in operation: {lex.Message}");
            } // catch
        } // Main()

        /// <summary>
        /// Checks the operation type.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <returns><c>true</c> if this is a valid operation; otherwise <c>false</c>.</returns>
        private static bool CheckOperation(string operation)
        {
            var validOperation = new List<string>();
            validOperation.AddRange(new[] { "add", "subtract", "multiply", "divide" });
            return validOperation.Contains(operation.ToLower());
        } // CheckOperation()

        /// <summary>
        /// Does the calculation.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The operation result.</returns>
        private static int DoCalculation(string operation, int a, int b)
        {
            operation = operation.ToLower();

            int result;
            if (operation == "add")
            {
                result = MyLibraryCore.OperationAdd(a, b);
            }
            else if (operation == "subtract")
            {
                result = MyLibraryCore.OperationSubtract(a, b);
            }
            else if (operation == "multiply")
            {
                result = MyLibraryCore.OperationMultiply(a, b);
            }
            else
            {
                result = MyLibraryCore.OperationDivide(a, b);
            } // if

            return result;
        } // DoCalculation()
    } // Program
}
