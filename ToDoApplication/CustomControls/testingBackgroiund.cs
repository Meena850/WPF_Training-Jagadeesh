﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ToDoApplication.CustomControls
{
	internal class testingBackgroiund : Control
	{


		public Color MyProperty
		{
			get { return (Color)GetValue(MyPropertyProperty); }
			set { SetValue(MyPropertyProperty, value); }
		}

		// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MyPropertyProperty =
			DependencyProperty.Register("MyProperty", typeof(Color), typeof(testingBackgroiund), new PropertyMetadata(Colors.Orange));


	}
}
