﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoApplication.Dialogs;
using ToDoApplication.Ioc;
using ToDoApplication.Repositories;
using ToDoApplication.Services;
using ToDoApplication.ViewModels;

namespace ToDoApplication
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			Title = "To Do HMI";
			InitializeComponent();
			//modified
			DataContext = IocContainer.current.Resolve<MainWindowViewModel>();
			//var tagRepository = new TagRepository();
			//DataContext = new MainWindowViewModel
			//	(new TodoItemRepository(), tagRepository,
			//	new DialogService(tagRepository),null);
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}


	}
}
