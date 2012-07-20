using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorldRepository.Mappers;
using HelloWorldRepository.Repository;

namespace HelloWorldServices
{
    public class CommentsService : IService
    {
        private readonly CommentsMapper _mapper = new CommentsMapper();
        private readonly CommentsRepository _repository = new CommentsRepository();

        public int Create(Object comment)
        {
            return _repository.Create(_mapper.Map(comment));
        }

        public List<Object> Retrieve()
        {
            return _repository.Retrieve().Select(x => x as Object).ToList();
        }

        public Object Retrieve(int id)
        {
            return _repository.Retrieve(id);
        }

        public bool Update(Object comment)
        {
            return _repository.Update(_mapper.Map(comment));
        }

        public bool Delete(Object comment)
        {
            return _repository.Delete(_mapper.Map(comment).Id);
        }
    }
}