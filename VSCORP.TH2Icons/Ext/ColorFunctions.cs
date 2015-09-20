//============================================================================
//
//    TH2Icons
//    Copyright (C) 2015 Visual Software Corporation
//
//    Author: ASV93
//    File: ColorFunctions.cs
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License along
//    with this program; if not, write to the Free Software Foundation, Inc.,
//    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
//============================================================================

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Code from http://winmodlib.codeplex.com/

namespace VSCORP.TH2Icons.Ext
{
    public static class ColorFunctions
    {
        /// <summary>
        /// Returns used-defined Immersive Colors of system 
        /// </summary>
        /// <param name="color">Immersive Color</param>
        /// <returns>User-setted color</returns>
        public static Color GetImmersiveColor(ImmersiveColors color)
        {
            return GetMetroColorByString(color.ToString());
        }

        #region CALLTOWIN
        [DllImport("uxtheme.dll", EntryPoint = "#94")]
        private static extern int GetImmersiveColorSetCount();

        /// <summary>
        /// Retrieves an immersive colour from the specified colour set.
        /// </summary>
        /// <param name="dwImmersiveColorSet">Colour set index. Use <see cref="GetImmersiveColorSetCount"/> to get the number of colour sets available.</param>
        /// <param name="dwImmersiveColorType">The colour type. Use <see cref="GetImmersiveColorTypeFromName"/> to get the type from an element name.</param>
        /// <param name="bIgnoreHighContrast">Set this to true to return colours from the current colour set, even if a high contrast theme is being used.</param>
        /// <param name="dwHighContrastCacheMode">Set this to 1 to force UxTheme to check whether high contrast mode is enabled. If this is set to 0, UxTheme will only perform this check if high contrast mode is currently disabled.</param>
        /// <returns>Returns a colour (0xAABBGGRR).</returns>
        [DllImport("uxtheme.dll", EntryPoint = "#95")]
        private static extern uint GetImmersiveColorFromColorSetEx(uint dwImmersiveColorSet, uint dwImmersiveColorType, bool bIgnoreHighContrast, uint dwHighContrastCacheMode);

        /// <summary>
        /// Retrieves an immersive colour type given its name.
        /// </summary>
        /// <param name="pName">Pointer to a string containing the name preprended with 9 characters (e.g. "Immersive" + name).</param>
        /// <returns>Colour type.</returns>
        [DllImport("uxtheme.dll", EntryPoint = "#96")]
        private static extern uint GetImmersiveColorTypeFromName(IntPtr pName);

        /// <summary>
        /// Gets the user's colour set preference (or default colour set if the user isn't allowed to modify this setting according to group policy).
        /// </summary>
        /// <param name="bForceCheckRegistry">Forces update from registry (HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Accent\ColorSet_Version3).</param>
        /// <param name="bSkipCheckOnFail">Skip second check if first result is -1.</param>
        /// <returns>User colour set preference.</returns>
        [DllImport("uxtheme.dll", EntryPoint = "#98")]
        private static extern int GetImmersiveUserColorSetPreference(bool bForceCheckRegistry, bool bSkipCheckOnFail);

        /// <summary>
        /// Retrieves names of colour types by index.
        /// </summary>
        /// <param name="dwIndex">Colour type index (0 to 766/0x2fe).</param>
        /// <returns>Pointer to a string containing the colour type's name.</returns>
        [DllImport("uxtheme.dll", EntryPoint = "#100")]
        private static extern IntPtr GetImmersiveColorNamedTypeByIndex(uint dwIndex);

        private static Color GetMetroColorByString(string Key)
        {
            int colourset = GetImmersiveUserColorSetPreference(false, false);
            IntPtr pElementName = Marshal.StringToHGlobalUni(Key);
            uint type = GetImmersiveColorTypeFromName(pElementName);
            Marshal.FreeCoTaskMem(pElementName);
            uint colourdword = GetImmersiveColorFromColorSetEx((uint)colourset, type, false, 0);
            byte[] colourbytes = new byte[4];
            colourbytes[0] = (byte)((0xFF000000 & colourdword) >> 24); // A
            colourbytes[1] = (byte)((0x00FF0000 & colourdword) >> 16); // B
            colourbytes[2] = (byte)((0x0000FF00 & colourdword) >> 8); // G
            colourbytes[3] = (byte)(0x000000FF & colourdword); // R
            return Color.FromArgb(colourbytes[0], colourbytes[3], colourbytes[2], colourbytes[1]);
        }
        #endregion
    }
}

