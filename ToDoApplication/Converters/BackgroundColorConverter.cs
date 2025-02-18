﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using ToDoApplication.Model;

namespace ToDoApplication.Converters
{
	public class BackgroundColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{

			if (value is TagColor tagColor)
			{ switch (tagColor)
				{
					case TagColor.Color1:
						 return GetBrush("TagColor1");
					case TagColor.Color2:
						return GetBrush("TagColor2");
					case TagColor.Color3:
						return GetBrush("TagColor3");
					case TagColor.Color4:
						return GetBrush("TagColor4");

				}
			}
			return GetBrush("TagColorDefault");
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		private SolidColorBrush GetBrush(string resourceKey)
		{
			var brush = Application.Current.Resources[resourceKey];
			return brush as SolidColorBrush;
		}
	}
}
