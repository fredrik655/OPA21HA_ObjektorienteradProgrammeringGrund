using System;


class TodoItem
{
    public string title {set; get;}
    public string description {set; get;}
    protected bool done = false;

    public TodoItem(string _title, string _description){
        this.title = _title;
        this.description = _description;
    }

    // prints all info about the todoItem
    public virtual void printTodoItem(){
        Console.WriteLine(" || Title: " + title + " Description: " + description + " Done: " + (done ? "[X]" : "[ ]"));
    }

    public virtual void markAsDone(){
        done = true;
    }
}