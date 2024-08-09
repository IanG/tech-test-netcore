using System.ComponentModel;
using Todo.Data.Entities;

namespace Todo.Models.TodoItems
{
    public class TodoItemEditFields
    {
        public int TodoListId { get; set; }
        public string Title { get; set; }
        public string TodoListTitle { get; set; }
        public int TodoItemId { get; set; }
        
        [DisplayName("Task Is Completed")]
        public bool IsDone { get; set; }
        
        [DisplayName("Assign Task To")]
        public string ResponsiblePartyId { get; set; }
        
        public int Rank { get; set; }
        
        public Importance Importance { get; set; }

        public TodoItemEditFields() { }

        public TodoItemEditFields(int todoListId, string todoListTitle, int todoItemId, string title, int rank, bool isDone, string responsiblePartyId, Importance importance)
        {
            TodoListId = todoListId;
            TodoListTitle = todoListTitle;
            TodoItemId = todoItemId;
            Title = title;
            Rank = rank;
            IsDone = isDone;
            ResponsiblePartyId = responsiblePartyId;
            Importance = importance;
        }
    }
}