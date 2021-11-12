using System;
using System.Collections.Generic;

class TodoList
{
    private List<TodoItem> todoList = new List<TodoItem>();

    public bool addItem(){
        Console.WriteLine("Enter type of todoItem");
        Console.WriteLine("Enter daily for daily todo item (Todo item that Resets every day)");
        Console.WriteLine("Or timed for timed todo item (Todo item with a deadline)");
        string inputType = Console.ReadLine();
        if(inputType.Equals("daily") || inputType.Equals("timed")){
            Console.WriteLine("Enter title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            if(inputType.Equals("daily")){
                todoList.Add(new DailyTodoItem(title, description));
                return true;
            }
            else if(inputType.Equals("timed")){
                Console.WriteLine("Enter endDate \"YYYY:MM:DD\"");
                string endDate = Console.ReadLine();
                todoList.Add(new TimedTodoItem(title, description, endDate));
                return true;
            }
        }
        
        return false;
    }

    // remove a todo item and is identified by title 
    // if items have the same name then the item that was added first will be removed
    public bool removeItem() {
        printAllTodoItems();
        Console.WriteLine("Enter title of the item you would like to remove.\n");
        string input = Console.ReadLine();
        foreach (TodoItem item in todoList)
        {
            if(item.title.Equals(input)){
                todoList.Remove(item);
                return true;
            }
        }
        return false;
    }

    // edits a todo item and is identified by title 
    // if items have the same name then the item that was added first will be edited 
    public bool editTodoItem(){
        printAllTodoItems();
        Console.WriteLine("Enter title of the item you would like to change.\n");
        string input = Console.ReadLine();
        foreach (TodoItem item in todoList)
        {
            if(item.title.Equals(input)){
                Console.WriteLine("Enter which part you would like to change");
                Console.WriteLine("Enter title to change the title");
                Console.WriteLine("Enter description to change the descritption");
                Console.WriteLine("Or enter done to mark item as done");
                input = Console.ReadLine();

                if(input.Equals("title")){
                    Console.WriteLine("Enter new title");
                    input = Console.ReadLine();
                    item.title = input;
                    return true;
                }
                else if(input.Equals("description")){
                    Console.WriteLine("Enter new description");
                    input = Console.ReadLine();
                    item.description = input;
                    return true;
                }
                else if(input.Equals("done")){
                    item.markAsDone();
                    return true;
                }
                else {
                    Console.WriteLine("bad input");
                    return false;
                }
            }
        }
        return false;
    }

    

    public void printAllTodoItems(){
        Console.WriteLine(" || --- Todo List ---------------");
        Console.WriteLine(" || -----------------------------");
        foreach (TodoItem item in todoList)
        {
            item.printTodoItem();
        }
        Console.WriteLine(" || -----------------------------");
        Console.WriteLine(" || -----------------------------");
    }
}