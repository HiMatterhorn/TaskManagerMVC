using System;
using System.Linq;
using TaskManagerMVC.Models;

namespace TaskManagerMVC.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        private readonly TaskManagerContext _context;

        public TaskRepository(TaskManagerContext context)
        {
            _context = context;
        }


        //TODO - Operations on data
        public void Add(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TaskModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TaskModel> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, TaskModel task)
        {
            throw new NotImplementedException();
        }
    }
}
