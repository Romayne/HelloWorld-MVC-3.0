using System;

namespace HelloWorldDomain
{
    public class Comments
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        public string Details { get; set; }

        public string Creator { get; set; }

        public bool IsPublic { get; set; }

        public DateTime Created { get; set; }
    }
}