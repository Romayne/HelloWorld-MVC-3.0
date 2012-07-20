using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using HelloWorldMVC.Models.Helpers;

namespace HelloWorldMVC.Models.Comments
{
    public class CommentsModel
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [Display(Name = "Author")]
        public string Creator { get; set; }

        [Required]
        [Display(Name = "Comment")]
        public string Details { get; set; }

        [Display(Name = "Is Public?")]
        public bool IsPublic { get; set; }

        public DateTime Created { get;  set; }

        public CommentsModel()
        {
            Id = 0;
            ApplicationId = new Random().Next(1000, 5000);
            Created = DateTime.UtcNow;
        }

        public CommentsModel(Object comment)
        {
            ModelHelper.Map(this, comment);
        }

        public List<CommentsModel> ToList(List<Object> comments)
        {
            List<CommentsModel> commentsList = new List<CommentsModel>();

            if (comments.Any())
                foreach(Object comment in comments)
                {
                    CommentsModel commentsModel = new CommentsModel();

                    ModelHelper.Map(commentsModel, comment);

                    commentsList.Add(commentsModel);
                }

            return commentsList;
        }
    }
}