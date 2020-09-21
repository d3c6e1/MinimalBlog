using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalBlog.Service
{
    public class Config
    {
        public static string ConnectionString { get; set; }
        public static string GitHubRepository { get; set; }
        public static string Title { get; set; }
    }
}
