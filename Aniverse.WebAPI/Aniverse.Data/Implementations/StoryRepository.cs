﻿using Aniverse.Core.Entites;
using Aniverse.Core.Entites.Enum;
using Aniverse.Core.Interfaces;
using Aniverse.Data.DAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Aniverse.Data.Implementations
{
    public class StoryRepository : Repository<Story>, IStoryRepository
    {
        private readonly AppDbContext _context;
        public StoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<List<Story>> GetFriendStory(string username)
        //{
        //    var friends = await _context.UserFriends.Where(u => u.User.UserName == username && u.Status == FriendRequestStatus.Accepted).Select(u => u.FriendId).Distinct().ToListAsync();
        //    var stories = await _context.Story
        //        .Where(p => friends
        //        .Contains(p.UserId) || p.User.UserName == username)
        //        .Include(p => p.User)
        //        .ToListAsync();
        //    return stories;
        //}
    }
}
