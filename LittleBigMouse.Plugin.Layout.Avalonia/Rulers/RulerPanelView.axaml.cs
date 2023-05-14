﻿/*
  LittleBigMouse.Plugin.Location
  Copyright (c) 2021 Mathieu GRENET.  All right reserved.

  This file is part of LittleBigMouse.Plugin.Location.

    LittleBigMouse.Plugin.Location is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LittleBigMouse.Plugin.Location is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MouseControl.  If not, see <http://www.gnu.org/licenses/>.

	  mailto:mathieu@mgth.fr
	  http://www.mgth.fr
*/

using System.Runtime.InteropServices;
using Avalonia.Styling;
using HLab.Sys.Windows.API;
using Window = Avalonia.Controls.Window;

namespace LittleBigMouse.Plugin.Layout.Avalonia.Rulers
{
    /// <summary>
    /// Logique d'interaction pour ScreenPanel.xaml
    /// </summary>
    public partial class RulerPanelView : Window
    {
        public RulerPanelView()
        {
            InitializeComponent();
        }
    }
}
