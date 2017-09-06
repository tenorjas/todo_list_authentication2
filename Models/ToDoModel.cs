using System;
using System.ComponentModel.DataAnnotations;

namespace testAuth.Models
{
      public class TodoModel
    {
        [Key]
        public string UserId {get; set;}
        public string TaskName {get; set;}
        public bool? IsComplete {get; set;}
        public DateTime Time {get; set;} = DateTime.Now;

        public void Complete()
        {
            IsComplete = true;
            Time = DateTime.Now;
        }
    }
}