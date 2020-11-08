// ---------------------------------------------------------------------------
// <copyright file="LibraryException.cs" company="Tethys">
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
    using System;

    /// <summary>
    /// Base exception for operations.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class LibraryException : Exception
    {
        #region CONSTRUCTION
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryException"/> class.
        /// </summary>
        public LibraryException()
        {
        } // LibraryException()

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public LibraryException(string message)
            : base(message)
        {
        } // LibraryException()

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception,
        /// or a null reference (<see langword="Nothing" /> in Visual Basic) if no inner exception is specified.</param>
        public LibraryException(string message, Exception innerException)
            : base(message, innerException)
        {
        } // LibraryException()
        #endregion // CONSTRUCTION
    } // LibraryException
}
