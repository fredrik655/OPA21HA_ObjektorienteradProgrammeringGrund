using System;
using System.IO;

namespace OPA21HA_ObjektorienteradProgrammeringGrund
{
    class Program
    {
        static TodoList todoList;
        static Storage storage; 
        static void Main(string[] args)
        {
            // init objects
            bool runProgram = true;
            todoList = new TodoList();
            storage = new Storage();

            ParseStoredData();

            // start main loop for the program
            while(runProgram){
                Console.WriteLine("choose print, add, remove, edit or stop");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "print":
                        todoList.printAllTodoItems();
                        break;
                    case "add":
                        bool added = todoList.addItem();
                        if(added) {
                            storage.saveList(todoList);
                        }
                        break;
                    case "remove":
                        bool removed = todoList.removeItem();
                        if(removed) {
                            storage.saveList(todoList);
                        }
                        break;
                    case "edit":
                        bool edited = todoList.editTodoItem();
                        if(edited) {
                            storage.saveList(todoList);
                        }
                        break;
                    case "stop":
                        runProgram = false;
                        Console.WriteLine("Program stopped");
                        break;
                    default:
                        Console.WriteLine("bad input try again");
                        break;
                }
            }
        }

        static public void ParseStoredData(){
            if(File.Exists(@"./file.txt")){
                string unParsedListString = storage.loadSavedList();
            }
            else {
                // make new file
                Console.WriteLine("No saved file found, making new file (not implemented)");
            }
        }
    }
}
