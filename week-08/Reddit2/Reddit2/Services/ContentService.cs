using Reddit2.Models;
using Reddit2.Repositories;
using Reddit2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Services
{
    public class ContentService
    {
        private ContentRepository contentRepository;

        public ContentService(ContentRepository contentRepository)
        {
            this.contentRepository = contentRepository;
        }

        public void AddPost(Post post)
        {
            contentRepository.AddPost(post);
        }
    }
}
