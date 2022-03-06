﻿using Aniverse.Core.Entites.Enum;

namespace Aniverse.Core.Entites
{
    public class UserFriend
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string FriendId { get; set; }
        public AppUser Friend { get; set; }
        public FriendRequestStatus Status { get; set; }
    }
}
