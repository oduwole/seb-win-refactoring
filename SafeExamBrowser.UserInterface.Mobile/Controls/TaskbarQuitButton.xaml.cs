﻿/*
 * Copyright (c) 2019 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using SafeExamBrowser.Contracts.UserInterface.Shell.Events;
using SafeExamBrowser.UserInterface.Mobile.Utilities;

namespace SafeExamBrowser.UserInterface.Mobile.Controls
{
	public partial class TaskbarQuitButton : UserControl
	{
		public event QuitButtonClickedEventHandler Clicked;

		public TaskbarQuitButton()
		{
			InitializeComponent();
			LoadIcon();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Clicked?.Invoke(new CancelEventArgs());
		}

		private void LoadIcon()
		{
			var uri = new Uri("pack://application:,,,/SafeExamBrowser.UserInterface.Desktop;component/Images/ShutDown.xaml");
			var resource = new XamlIconResource(uri);

			Button.Content = IconResourceLoader.Load(resource);
		}
	}
}
