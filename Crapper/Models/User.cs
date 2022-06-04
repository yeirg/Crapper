﻿using System.ComponentModel.DataAnnotations;

namespace Crapper.Models
{
    /// <summary>
    /// Example of inherited class = BaseModel<Type> (int Id will now be included in this class)
    /// </summary>
    public class User : BaseModel<int>
    {
        [StringLength(20, MinimumLength = 3)]
        public string Username { get; set; }

        public string Email { get; set; }
        
        [StringLength(300)]
        public string? Bio { get; set; }

        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }

        public ICollection<Post> Posts { get; set; }
        
        public ICollection<Subscription> Subscribers { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }

        public int SubscribersCount 
        { 
            get
            {
                return Subscribers.Count;
            } 
        }

        public int SubscriptionsCount
        {
            get
            {
                return Subscriptions.Count;
            }
        }
    }
}
