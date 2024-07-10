namespace ToDoProject
{
    class TaskManagerService
    {

        public List<TaskModel> tasks;

        public TaskManagerService()
        {
            tasks = new List<TaskModel>();
        }

        public void AddTask(TaskModel task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(int taskId) { }
        public void UpdateTask(int taskId, string newDiscription) { }
        public void ToggleIsComplete(int taskId) { }


    }
}
