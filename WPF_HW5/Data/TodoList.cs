using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HW5.Data;

public static class TodoList
{
    private static List<Todo> todos = [];

    //create new task
    public static Todo Add(string title)
    {
        var newTodo = new Todo
        {
            Title = title,
            IsComplited = false,
            Id = Guid.NewGuid()
        };

        todos.Add(newTodo);

        return newTodo;
    }

    public static void Delete(Guid id) 
    {
        todos.RemoveAll(t => t.Id == id);
    }

    public static void Complete(Guid id) 
    { 
        Todo todo = todos.First(t=> t.Id == id);
        todo.IsComplited = true;
    }

    public static void Clear()
    {
        todos.Clear();
    }

}

