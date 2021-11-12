using System;

class DailyTodoItem : TodoItem
{

    public DailyTodoItem(string _title, string _description) : base(_title, _description){

    }

    public override void  markAsDone(){
        Console.WriteLine("this is daily done");
        done = true;
    }
}