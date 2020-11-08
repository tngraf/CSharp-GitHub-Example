// ---------------------------------------------------------------------------
// <copyright file="MyLibraryTest.cs" company="Tethys">
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

namespace MyLibraryTest
{
    using MyLibrary;
    using Xunit;

    /// <summary>
    /// Test class.
    /// </summary>
    public class MyLibraryTest
    {
        /// <summary>
        /// Unit test.
        /// </summary>
        [Fact]
        public void TestOperationAdd()
        {
            var actual = MyLibraryCore.OperationAdd(1, 2);
            Assert.Equal(3, actual);
        }

        /// <summary>
        /// Unit test.
        /// </summary>
        [Fact]
        public void TestOperationSubtract()
        {
            var actual = MyLibraryCore.OperationSubtract(10, 2);
            Assert.Equal(8, actual);
        }

        /// <summary>
        /// Unit test.
        /// </summary>
        [Fact]
        public void TestOperationMultiply()
        {
            var actual = MyLibraryCore.OperationMultiply(10, 2);
            Assert.Equal(20, actual);
        }

        /// <summary>
        /// Unit test.
        /// </summary>
        [Fact]
        public void TestOperationDivide()
        {
            var actual = MyLibraryCore.OperationDivide(10, 2);
            Assert.Equal(5, actual);
        }

        /// <summary>
        /// Unit test.
        /// </summary>
        [Fact]
        public void TestOperationDivideByZero()
        {
            Assert.Throws<LibraryException>(() => MyLibraryCore.OperationDivide(1, 0));
        }
    }
}
