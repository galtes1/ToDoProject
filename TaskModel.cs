namespace ToDoProject
{
    class TaskModel
    {
        public int TaskId { get; set; }
        public string TaskDiscription { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Created { get; set; }

        public TaskModel(int taskId, string taskDiscription)
        {
            TaskId = taskId;
            TaskDiscription = taskDiscription;
            IsCompleted = false;
            Created = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{TaskId}. {TaskDiscription} - {Created.ToString()} - Done? {IsCompleted}";
        }
    }

}
