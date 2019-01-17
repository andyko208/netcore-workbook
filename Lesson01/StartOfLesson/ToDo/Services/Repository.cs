using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace ToDoApp.Services
{
    public class Repository
    {
        public static Dictionary<int, Status> status = new Dictionary<int, Status>
        {
            { 1, new Status { Id = 1, Value = "Not Started" } },
            { 2, new Status { Id = 2, Value = "In Progress" } },
            { 3, new Status { Id = 3, Value = "Done" } }
        };


        public static List<ToDo> list = new List<ToDo>
        {
            new ToDo { Id = 1, Title = "My First ToDo", Description = "Get the app working", Status = status[2] }
        };

        public static ToDo GetTodoById(int id)
        {
            var todo = list.SingleOrDefault(t => t.Id == id);

            return todo;
        }

        public static void SaveTodo(int id, IFormCollection collection)
        {
            // get the current todo based on id
            // overwrite each property with values from collection
            // var todo = GetTodoById(id) 
            // todo.Description = collection["Description"];
        }
        
        public static void CreateTodo(IFormCollection collection)
        {
            // no need to get anything from list
            // create new object of type todo and append values from collection
            // title = collection[title];
            // status = collection[status];
            // add new todo to list
        }

        public static void DeleteTodo(IFormCollection collection)
        {
            // find todo
            // delete from list (know how to delete element from list)
        }
    }
}
