﻿/*
 * ExtentsionMethods.cs
 * Author: Brandon Bednar
 * Purpose: Extension methods for finding ancestors of the controls
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CowboyCafe.Extensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Find the first ancestor in the Visual Tree that has the specified type,
        /// or null if no ancestor is found
        /// </summary>
        /// <typeparam name="T">The type to search for</typeparam>
        /// <param name="element">The element being investigated</param>
        /// <returns>The first ancestor of type T, or null</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent is null)
            {
                return null;
            }

            if (parent is T)
            {
                return parent as T;
            }

            return FindAncestor<T>(parent);
        }
    }
}
