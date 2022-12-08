﻿using GamerssChat.Models;
using GamerssChat.Repositories.Interfaces;

namespace GamerssChat.Services
{
    public class TimelineService
    {

        private readonly ITimelineRepository _timelineRepository;

        public TimelineService(ITimelineRepository timelineRepository)
        {
            _timelineRepository = timelineRepository;
        }

        public IEnumerable<Timeline> GetTimelines()
        {
            return _timelineRepository.GetAll();
        }

        public Timeline AddPostsToTimeline(Guid timelineId, List<Post> posts)
        {
            return _timelineRepository.AddPostsToTimeline(timelineId, posts);
        }

        public Timeline AddPostToTimeline(Guid timelineId, Post post)
        {
            return _timelineRepository.AddPostToTimeline(timelineId, post);
        }

        public void DeleteTimeline(Guid id)
        {
             this._timelineRepository.DeleteById(id);
        }

        public Timeline GetTimelineById(Guid id)
        {
            return _timelineRepository.GetById(id);
        }

        public Timeline RemovePostFromTimeline(Guid timelineId, Post postToDelete)
        {
            return _timelineRepository.RemovePostFromTimeline(timelineId, postToDelete);
        }

        public Timeline TimelineToUpdate(Timeline timelineToUpdate)
        {
            return _timelineRepository.Update(timelineToUpdate);
        }
    }
}
