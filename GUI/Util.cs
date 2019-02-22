﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Drawing;

namespace CKAN
{
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public static class Util
    {
        /// <summary>
        /// Invokes an action on the UI thread, or directly if we're
        /// on the UI thread.
        /// </summary>
        public static void Invoke<T>(T obj, Action action) where T : Control
        {
            if (obj.InvokeRequired) // if we're not in the UI thread
            {
                // enqueue call on UI thread and wait for it to return
                obj.Invoke(new MethodInvoker(action));
            }
            else
            {
                // we're on the UI thread, execute directly
                action();
            }
        }

        // utility helper to deal with multi-threading and UI
        // async version, doesn't wait for UI thread
        // use with caution, when not sure use blocking Invoke()
        public static void AsyncInvoke<T>(T obj, Action action) where T : Control
        {
            if (obj.InvokeRequired) // if we're not in the UI thread
            {
                // enqueue call on UI thread and continue
                obj.BeginInvoke(new MethodInvoker(action));
            }
            else
            {
                // we're on the UI thread, execute directly
                action();
            }
        }

        // hides the console window on windows
        // useful when running the GUI
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void HideConsoleWindow()
        {
            if (Platform.IsWindows)
            {
                ShowWindow(GetConsoleWindow(), 0);
            }
        }

        /// <summary>
        /// Returns true if the string could be a valid http address.
        /// DOES NOT ACTUALLY CHECK IF IT EXISTS, just the format.
        /// </summary>
        public static bool CheckURLValid(string source)
        {
            Uri uri_result;
            return Uri.TryCreate(source, UriKind.Absolute, out uri_result) && uri_result.Scheme == Uri.UriSchemeHttp;
        }

        public static void OpenLinkFromLinkLabel(LinkLabel link_label)
        {
            if (link_label.Text == "N/A")
            {
                return;
            }

            TryOpenWebPage(link_label.Text);
        }

        /// <summary>
        /// Tries to open an url using the default application.
        /// If it fails, it tries again by prepending each prefix before the url before it gives up.
        /// </summary>
        public static bool TryOpenWebPage(string url, IEnumerable<string> prefixes = null)
        {
            // Default prefixes to try if not provided
            if (prefixes == null)
                prefixes = new string[] { "http://", "https://" };

            try // opening the page normally
            {
                Process.Start(url);
                return true; // we did it! return true
            }
            catch (Exception) // something bad happened
            {
                foreach (string prefixed_url in prefixes.Select(p=>p+url).Where(CheckURLValid))
                {
                    try // with a new prefix
                    {
                        Process.Start(prefixed_url);
                        return true;
                    }
                    catch (Exception)
                    {
                        // move along to the next prefix
                    }
                }
                // We tried all prefixes, and still no luck.
                return false;
            }
        }

        /// <summary>
        /// Adjust position of a box so it fits entirely on one screen
        /// </summary>
        /// <param name="location">Top left corner of box</param>
        /// <param name="size">Width and height of box</param>
        /// <returns>
        /// Original location if already fully on-screen, otherwise
        /// a position representing sliding it onto the screen
        /// </returns>
        public static Point ClampedLocation(Point location, Size size)
        {
            var rect = new Rectangle(location, size);
            // Find a screen that the default position overlaps
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.IntersectsWith(rect))
                {
                    // Slide the whole rectangle fully onto the screen
                    if (location.X < screen.WorkingArea.Top)
                        location.X = screen.WorkingArea.Top;
                    if (location.Y < screen.WorkingArea.Left)
                        location.Y = screen.WorkingArea.Left;
                    if (location.X + size.Width > screen.WorkingArea.Right)
                        location.X = screen.WorkingArea.Right - size.Width;
                    if (location.Y + size.Height > screen.WorkingArea.Bottom)
                        location.Y = screen.WorkingArea.Bottom - size.Height;
                    // Stop checking screens
                    break;
                }
            }
            return location;
        }

        /// <summary>
        /// Adjust position of a box so it fits on one screen with a margin around it
        /// </summary>
        /// <param name="location">Top left corner of box</param>
        /// <param name="size">Width and height of box</param>
        /// <param name="topLeftMargin">Size of space between window and top left edge of screen</param>
        /// <param name="bottomRightMargin">Size of space between window and bottom right edge of screen</param>
        /// <returns>
        /// Original location if already fully on-screen plus margins, otherwise
        /// a position representing sliding it onto the screen
        /// </returns>
        public static Point ClampedLocationWithMargins(Point location, Size size, Size topLeftMargin, Size bottomRightMargin)
        {
            // Imagine drawing a larger box around the window, the size of the desired margin.
            // We pass that box to ClampedLocation to make sure it fits on screen,
            // then place our window at an offset within the box
            return ClampedLocation(location - topLeftMargin, size + topLeftMargin + bottomRightMargin) + topLeftMargin;
        }

    }
}
