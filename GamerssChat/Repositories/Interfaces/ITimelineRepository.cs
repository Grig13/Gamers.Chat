using GamerssChat.Models;

namespace GamerssChat.Repositories.Interfaces
{
    public interface ITimelineRepository
    {
        public IEnumerable<Timeline> GetAll();
        public Timeline AddPostsToTimeline(Guid timelineId, List<Post> posts);
        public Timeline AddPostToTimeline (Guid timelineId, Post postToAdd);
        public Timeline RemovePostFromTimeline(Guid timelineId, Post postToRemove);
        public void DeleteById(Guid id);
        public Timeline Update(Timeline timelineToUpdate);
        public Timeline GetById(Guid id);

    }
}
