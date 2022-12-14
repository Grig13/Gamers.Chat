using GamerssChat.Models;
using GamerssChat.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamerssChat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly NewsService _newsService;

        public NewsController(NewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public IEnumerable<News> Get()
        {
            return this._newsService.GetNews();
        }

        [HttpGet("{id}")]
        public News Get(Guid newsId)
        {
            return this._newsService.GetNewsById(newsId);
        }

        [HttpPost]
        public News Post([FromBody] News news)
        {
            var newsToAdd = new News
            {
                Content = news.Content,
                Image = news.Image,
                Attachment = news.Attachment
            };

            return this._newsService.AddNews(newsToAdd);
        }

        [HttpPut("{id}")]
        public News Update(Guid id, [FromBody] News news)
        {
            var newsToEdit = _newsService.GetNewsById(id);
            newsToEdit.Content = news.Content;
            newsToEdit.Image = news.Image;
            newsToEdit.Attachment = news.Attachment;
            return this._newsService.UpdateNews(newsToEdit);

        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            this._newsService.DeleteNews(id);
        }
    }
}
