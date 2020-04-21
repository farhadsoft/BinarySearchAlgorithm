﻿using System;

namespace BinarySearchTask
{
    /// <summary>
    /// Class for basic array operations.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Implement binary search, see https://en.wikipedia.org/wiki/Binary_search_algorithm.
        /// </summary>
        /// <param name="source">Source sorted array.</param>
        /// <param name="value">Value to search.</param>
        /// <returns>
        /// The position of an element with a given value in sorted array.
        /// If element is not found returns null.
        /// </returns>
        /// <example>
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 11 => 6
        /// source = {1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634}, value = 144 => 9
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 0 => null
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 14 => null
        /// </example>
        public static int? BinarySearch(int[] source, int value)
        {
            throw new NotImplementedException();
        }
    }
}