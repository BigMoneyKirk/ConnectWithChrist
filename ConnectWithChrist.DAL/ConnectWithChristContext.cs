using ConnectWithChrist.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL
{
    public class ConnectWithChristContext : DbContext
    {
        public ConnectWithChristContext() : base()
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogEntry> BlogEntries { get; set; }

        public DbSet<FavoriteVerse> FavoriteVerses { get; set; }

        public DbSet<Friends> Friends { get; set; }

        public DbSet<GodlyLink> GodlyLinks { get; set; }

        public DbSet<HealthTip> HealthTips { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Journal> Journals { get; set; }

        public DbSet<JournalEntry> JournalEntries { get; set; }

        public DbSet<NewsFeed> NewsFeeds { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Sermon> Sermons { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<VerseOfDay> VerseOfDays { get; set; }
    }
}
