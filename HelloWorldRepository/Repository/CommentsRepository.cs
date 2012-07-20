using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorldDomain;
using HelloWorldRepository.Mappers;

namespace HelloWorldRepository.Repository
{
    public class CommentsRepository : RepositoryBase, IRepository<Comments>
    {
        private readonly CommentsMapper _mapper;

        public CommentsRepository()
        {
            _mapper = new CommentsMapper();
        }

        public int Create(Comments comment)
        {
            var insertedComment = _mapper.Map(comment);

            DataContext.Comments.InsertOnSubmit(insertedComment);
            DataContext.SubmitChanges();

            return insertedComment.Id;
        }

        public List<Comments> Retrieve()
        {
            var comments = from x in DataContext.Comments
                           select x;

            return comments.Select(x => _mapper.Map(x)).ToList();
        }

        public Comments Retrieve(int id)
        {
            var comment = (from x in DataContext.Comments
                           where x.Id.Equals(id)
                           select x).SingleOrDefault();

            return (comment != null) ? _mapper.Map(comment) : null;
        }

        public bool Update(Comments comment)
        {
            var retrievedComment = DataContext.Comments.SingleOrDefault(x => x.Id.Equals(comment.Id));

            if (retrievedComment != null)
            {
                retrievedComment.ApplicationId = comment.ApplicationId;
                retrievedComment.Creator = comment.Creator;
                retrievedComment.Details = comment.Details;
                retrievedComment.IsPublic = comment.IsPublic;

                DataContext.SubmitChanges();

                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            var comment = (from x in DataContext.Comments
                          where x.Id.Equals(id)
                           select x).SingleOrDefault(); ;

            if (comment != null)
            {
                DataContext.Comments.DeleteOnSubmit(comment);
                DataContext.SubmitChanges();

                return true;
            }

            return false;
        }
    }
}