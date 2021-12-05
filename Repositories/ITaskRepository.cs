using System.Linq;
using TaskManagerMVC.Models;

namespace TaskManagerMVC.Repositories
{
    interface ITaskRepository
    {

        public TaskModel Get(int id);
        public IQueryable<TaskModel> GetAllActive();
        public void Add(TaskModel task);
        public void Update(int id, TaskModel task);
        public void Delete(int id);
    }
}
