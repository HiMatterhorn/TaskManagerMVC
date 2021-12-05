using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TaskManagerMVC.Models;

namespace TaskManagerMVC.Controllers
{
    public class TaskController : Controller
    {
        private static IList<TaskModel> tasks = new List<TaskModel>()
        {
            new TaskModel(){TaskId =1, Name = "Wizyta u lekarza", Description = "Godzina 17:00", Done = false },
            new TaskModel(){TaskId =2, Name = "Zrobić obiad", Description = "Pierogi", Done = false },

        };

        private static int _id = tasks.Count;




        // GET: TaskController
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel taskModel)
        {

            if (tasks.Count > _id)
            {
                _id = tasks.Count;
            };

            _id = _id + 1;



            taskModel.TaskId = _id;
            tasks.Add(taskModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
            task.Name = taskModel.Name;
            task.Description = taskModel.Description;
            return RedirectToAction(nameof(Index));


        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskModel taskModel)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
            tasks.Remove(task);
            return RedirectToAction(nameof(Index));

        }
    }
}
