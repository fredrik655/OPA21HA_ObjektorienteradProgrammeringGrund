using System;


class TimedTodoItem : TodoItem
{
    private string endDate {set; get;}
    public TimedTodoItem(string _title, string _description, string _endDate) : base(_title, _description) {
        this.endDate = _endDate;
    }

    public override void printTodoItem(){
        Console.WriteLine(" || Title: " + title + " Description: " + description + " EndDate " + endDate + " Done: " + (done ? "[X]" : "[ ]"));
    }
}