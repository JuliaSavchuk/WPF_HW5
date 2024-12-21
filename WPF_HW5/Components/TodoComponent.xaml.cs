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
using WPF_HW5.Data;

namespace WPF_HW5.Components;

/// <summary>
/// Логика взаимодействия для TodoComponent.xaml
/// </summary>
public partial class TodoComponent : UserControl
{
    private Todo todo;
    public TodoComponent(Todo todo )
    {
        InitializeComponent();
        this.todo = todo;
    }

    public void OnCompleteClick(object sender, RoutedEventArgs e)
    {
        TodoList.Complete(todo.Id);

        TitleLabel.Foreground = Brushes.White;

        CompleteButton.IsEnabled = false;
    }

    public void OnDeleteClick(object sender, RoutedEventArgs e) 
    { 
        TodoList.Delete(todo.Id);

        StackPanel parent = Parent as StackPanel;

        parent.Children.Remove(this);
    }

    private void TitleLabel_Loaded(object sender, RoutedEventArgs e)
    {
        TitleLabel.Content=todo.Title;
    }
}
