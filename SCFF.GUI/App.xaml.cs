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

/// @file SCFF.GUI/App.xaml.cs
/// @copydoc SCFF::GUI::App

/// SCFF DSFのGUIクライアント
namespace SCFF.GUI {

using System.Windows;
using SCFF.Common;

/// Applicationクラス
public partial class App : Application {
  //===================================================================
  // シングルトン
  //===================================================================

  /// Singleton: アプリケーション設定
  private static Options options = new Options();
  /// アプリケーション設定を取得
  public static Options Options {
    get { return App.options; }
  }

  /// Singleton: アプリケーション実行時設定
  private static RuntimeOptions runtimeOptions = new RuntimeOptions();
  /// アプリケーション実行時設定を取得
  public static RuntimeOptions RuntimeOptions {
    get { return App.runtimeOptions; }
  }

  /// Singleton: 現在編集中のプロファイル
  private static Profile profile = new Profile();
  /// 現在編集中のプロファイルを取得
  public static Profile Profile {
    get { return App.profile; }
  }

  /// Singleton: スクリーンキャプチャ用タイマー
  private static ScreenCaptureTimer screenCaptureTimer = new ScreenCaptureTimer();
  /// スクリーンキャプチャ用タイマー
  public static ScreenCaptureTimer ScreenCaptureTimer {
    get { return App.screenCaptureTimer; }
  }

  //===================================================================
  // イベントハンドラ
  //===================================================================

  /// Startup: アプリケーション開始時
  /// @param e コマンドライン引数(Args)を参照可能
  protected override void OnStartup(StartupEventArgs e) {
    base.OnStartup(e);

    // Options
    OptionsINIFile.Load(App.Options);

    // Profile
    if (App.Options.RestoreLastProfile) {
      /// @todo(me) プロファイル読み込み
      App.Profile.RestoreDefault();
    } else {
      App.Profile.RestoreDefault();
    }
  }

  /// Exit: アプリケーション終了時
  /// @param e 終了コード(ApplicationExitCode)の参照・設定が可能
  protected override void OnExit(ExitEventArgs e) {
    base.OnExit(e);

    // Profileの保存は明示的にMainWindow上で行うのでここでは何もしない

    // Options
    OptionsINIFile.Save(App.Options);
  }
}
}   // namespace SCFF.GUI
