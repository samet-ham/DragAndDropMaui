namespace DragAndDrop2Maui.Models
{
    public class TaskModel
    {
        public string TaskName { get; set; }
        public int TaskStatus { get; set; }
        public int TaskId { get; set; }
    }

    public enum TaskStatusOption
    {
        NewTask,
        InProgress,
        InReview,
        Done
    }
}
