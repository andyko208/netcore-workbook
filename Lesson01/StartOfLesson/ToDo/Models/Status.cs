using System;
using Microsoft.Extensions.Primitives;

namespace ToDoApp.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public static implicit operator Status(StringValues v)
        {
            throw new NotImplementedException();
        }
    }
}
