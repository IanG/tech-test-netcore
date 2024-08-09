using System.Linq;
using FluentAssertions;
using Microsoft.AspNetCore.Identity;
using Todo.Data.Entities;
using Todo.EntityModelMappers.TodoItems;
using Todo.Models.TodoItems;
using Xunit;

namespace Todo.Tests
{
    public class WhenTodoItemIsConvertedToEditFields
    {
        private readonly TodoItem srcTodoItem;
        private readonly TodoItemEditFields resultFields;

        public WhenTodoItemIsConvertedToEditFields()
        {
            var todoList = new TestTodoListBuilder(new IdentityUser("alice@example.com"), "shopping")
                    .WithItem("bread", 0, Importance.High)
                    .Build()
                ;

            srcTodoItem = todoList.Items.First();

            resultFields = TodoItemEditFieldsFactory.Create(srcTodoItem);
        }

        [Fact (DisplayName = "TodoItemEditFields.TodoListId should match the source TodoItem TodoListId")]
        public void EqualTodoListId()
        {
            resultFields.TodoListId.Should().Be(srcTodoItem.TodoListId);
        }

        [Fact (DisplayName = "TodoItemEditFields.Title should match the source TodoItem Title")]
        public void EqualTitle()
        {
            resultFields.Title.Should().Be(srcTodoItem.Title);
        }

        [Fact(DisplayName = "TodoItemEditFIelds.Rank should match the source TodoItem Rank")]
        public void EqualRank()
        {
            resultFields.Rank.Should().Be(srcTodoItem.Rank);
        }

        [Fact (DisplayName = "TodoItemEditFields.Importance should match the source TodoItem Importance")]
        public void EqualImportance()
        {
            resultFields.Importance.Should().Be(srcTodoItem.Importance);
        }

        [Fact(DisplayName = "TodoItemEditFields.TodoListTitle should match the source TodoList Title")]
        public void EqualTodoListTitle()
        {
            resultFields.TodoListTitle.Should().Be(srcTodoItem.TodoList.Title);
        }

        [Fact(DisplayName = "TodoItemEditFields.TodoItemId should match the source TodoItem Id")]
        public void EqualTodoItemId()
        {
            resultFields.TodoItemId.Should().Be(srcTodoItem.TodoItemId);
        }

        [Fact(DisplayName = "TodoItemEditFields.ResponsiblePartyId should match the source TodoItem ResponsiblePartyId")]
        public void EqualResponsiblePartyId()
        {
            resultFields.ResponsiblePartyId.Should().Be(srcTodoItem.ResponsiblePartyId);
        }

        [Fact(DisplayName = "TodoItemEditFields.IsDone should be false")]
        public void FalseIsDone()
        {
            resultFields.IsDone.Should().BeFalse();
        }
    }
}