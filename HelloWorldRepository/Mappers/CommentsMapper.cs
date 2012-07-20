using System;
using HelloWorldDomain;
using HelloWorldDatabaseAccess;

namespace HelloWorldRepository.Mappers
{
    public class CommentsMapper : IMapper<Comments, Comment>
    {
        public Comment Map(Comments c)
        {
            return new Comment
                {
                    Id = c.Id,
                    ApplicationId = c.ApplicationId,
                    Creator = c.Creator,
                    Details = c.Details,
                    IsPublic = c.IsPublic,
                    Created = c.Created
                };
        }
        
        public Comments Map(Object m)
        {
            return new Comments
                {
                    Id = Convert.ToInt32(m.GetType().GetProperty("Id").GetValue(m, null)),
                    ApplicationId = Convert.ToInt32(m.GetType().GetProperty("ApplicationId").GetValue(m, null)),
                    Creator = Convert.ToString(m.GetType().GetProperty("Creator").GetValue(m, null)),
                    Details = Convert.ToString(m.GetType().GetProperty("Details").GetValue(m, null)),
                    IsPublic = Convert.ToBoolean(m.GetType().GetProperty("IsPublic").GetValue(m, null)),
                    Created = Convert.ToDateTime(m.GetType().GetProperty("Created").GetValue(m, null))
                };
        }
    }
}