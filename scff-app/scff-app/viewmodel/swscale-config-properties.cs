﻿// Copyright 2012 Alalf <alalf.iQLc_at_gmail.com>
//
// This file is part of SCFF DSF.
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

/// @file scff-app/viewmodel/swscale-config-properties.cs
/// @brief scff_app.viewmodel.SWScaleConfigのプロパティの定義

namespace scff_app.viewmodel {

using System;

/// @brief scff_interprocess.SWScaleConfigのビューモデル
partial class SWScaleConfig {
  public scff_interprocess.SWScaleFlags Flags { get; set; }
  public Boolean AccurateRnd { get; set; }
  public Boolean IsFilterEnabled { get; set; }
  public Single LumaGBlur { get; set; }
  public Single ChromaGBlur { get; set; }
  public Single LumaSharpen { get; set; }
  public Single ChromaSharpen { get; set; }
  public Single ChromaHShift { get; set; }
  public Single ChromaVShift { get; set; }
}
}