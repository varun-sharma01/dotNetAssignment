using System;

namespace PostApp
{
    class Post
    {
        private int _voteValue; // Private field to store the vote value

        // Properties for the post's title, description, and creation date/time
        public string Title { get; }
        public string Description { get; }
        public DateTime Created { get; }

        // Public property to get the current vote value
        public int VoteValue => _voteValue;

        // Constructor to initialize the post with a title and description
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Created = DateTime.Now;
            _voteValue = 0; // Initialize vote value to 0
        }

        // Method to up-vote the post
        public void UpVote()
        {
            _voteValue++;
        }

        // Method to down-vote the post
        public void DownVote()
        {
            _voteValue--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new post
            var post = new Post("Sample Post", "This is a sample post for StackOverflow");

            // Up-vote the post twice and down-vote it once
            post.UpVote();
            post.UpVote();
            post.DownVote();

            // Display the current vote value
            Console.WriteLine($"Current Vote Value: {post.VoteValue}");
            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Description: {post.Description}");
            Console.WriteLine($"Creation Time: {post.Created}");
        }
    }
}
