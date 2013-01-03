﻿// Copyright 2012-2013 Alalf <alalf.iQLc_at_gmail.com>
//
// This file is part of SCFF-DirectShow-Filter(SCFF DSF).
//
// SCFF DSF is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// SCFF DSF is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with SCFF DSF.  If not, see <http://www.gnu.org/licenses/>.

/// @file SCFF.GUI/UpdateCommands.cs
/// Profile/OptionsがUpdateされたことを他のコントロールに知らせるためのRoutedCommands

namespace SCFF.GUI {

using System.Windows.Input;

/// Profile/OptionsがUpdateされたことを他のコントロールに知らせるためのRoutedCommands
public static class UpdateCommands {
  public readonly static RoutedCommand UpdateMainWindowCommand = new RoutedCommand();
  public readonly static RoutedCommand UpdateLayoutEditCommand = new RoutedCommand();
  public readonly static RoutedCommand UpdateCurrentTargetWindowCommand = new RoutedCommand();
  public readonly static RoutedCommand UpdateCurrentLayoutParameterCommand = new RoutedCommand();
}
}
