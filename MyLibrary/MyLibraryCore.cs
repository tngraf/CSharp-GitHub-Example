// ---------------------------------------------------------------------------
// <copyright file="MyLibraryCore.cs" company="Tethys">
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

namespace MyLibrary
{
    /// <summary>
    /// A very simple mathematical demo library.
    /// </summary>
    public static class MyLibraryCore
    {
        #region PUBLIC METHODS
        /// <summary>
        /// Add two integer values.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The addition result.</returns>
        public static int OperationAdd(int a, int b)
        {
            return a + b;
        } // OperationAdd()

        /// <summary>
        /// Subtract two integer values.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The subtraction result.</returns>
        public static int OperationSubtract(int a, int b)
        {
            return a - b;
        } // OperationSubtract()

        /// <summary>
        /// Multiply two integer values.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The multiplication result.</returns>
        public static int OperationMultiply(int a, int b)
        {
            return a * b;
        } // OperationMultiply()

        /// <summary>
        /// Divide two integer values.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The division result.</returns>
        public static int OperationDivide(int a, int b)
        {
            if (b == 0)
            {
                throw new LibraryException("You must not divide by zero");
            } // if

            return a / b;
        } // OperationDivide()
        #endregion // PUBLIC METHODS
    } // MyLibrary
}
