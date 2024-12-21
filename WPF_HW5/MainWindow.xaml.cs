using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_HW5.Components;
using WPF_HW5.Data;

namespace WPF_HW5;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void OnAddClick(object sender, RoutedEventArgs e)
    {
        string title = TitleTextBox.Text;

        Todo newTodo = TodoList.Add(title);

        TodoComponent component = new TodoComponent(newTodo);

        TodoListPanel.Children.Add(component);
    }

    public void OnClearClick(object sender, RoutedEventArgs e)
    {

        TodoList.Clear();

        TodoListPanel.Children.Clear();
    }
}