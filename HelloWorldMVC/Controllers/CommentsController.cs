using System.Web.Mvc;
using HelloWorldMVC.Models.Comments;
using HelloWorldServices;

namespace HelloWorldMVC.Controllers
{
    public class CommentsController : Controller
    {
        private readonly IService _commentsService;

        public CommentsController()
        {
            _commentsService = new CommentsService();
        }

        public CommentsController(CommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        public ActionResult Index()
        {
            return View(new CommentsModel().ToList(_commentsService.Retrieve()));
        }

        public ActionResult Create(string postBack = "")
        {
            ViewBag.submitText = "Create";
            ViewBag.postBack = postBack;

            return View(new CommentsModel());
        }

        [HttpPost]
        public ActionResult Create(CommentsModel model)
        {
            if (ModelState.IsValid)
            {
                int createdCommentId = _commentsService.Create(model);

                if (createdCommentId != 0)
                    return RedirectToAction("Create", "Comments", new { postBack = "success"});
                
                ModelState.AddModelError("", "Comment not added successfully.");
            }

            ViewBag.submitText = "Create";

            return View(model);
        }

        public ActionResult Update(int id, string postBack = "")
        {
            ViewBag.submitText = "Update";
            ViewBag.postBack = postBack;

            return View(new CommentsModel(_commentsService.Retrieve(id)));
        }

        [HttpPost]
        public ActionResult Update(int id, CommentsModel model)
        {
            if (ModelState.IsValid)
            {
                if (_commentsService.Update(model))
                    return RedirectToAction("Update", "Comments", new { id, postBack = "success" });

                ModelState.AddModelError("", "Comment not edited successfully.");
            }

            ViewBag.submitText = "Update";

            return View(model);
        }

        public ActionResult Delete(int id, string postBack = "")
        {
            ViewBag.postBack = postBack;

            return View(new CommentsModel(_commentsService.Retrieve(id)));
        }

        [HttpPost]
        public ActionResult Delete(int id, CommentsModel model)
        {
            if (_commentsService.Delete(model))
                return RedirectToAction("Delete", "Comments", new { id, postBack = "success" });

            ModelState.AddModelError("", "Comment not deleted successfully.");

            return View(new CommentsModel(_commentsService.Retrieve(id)));
        }
    }
}