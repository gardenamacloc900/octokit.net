﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]    
    public class CommitComment
    {
        /// <summary>
        /// The issue comment Id.
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// The URL for this repository comment.
        /// </summary>
        public Uri Url { get; protected set; }

        /// <summary>
        /// The html URL for this repository comment.
        /// </summary>
        public Uri HtmlUrl { get; protected set; }

        /// <summary>
        /// Details about the repository comment.
        /// </summary>
        public string Body { get; protected set; }

        /// <summary>
        /// Relative path of the file that was commented on.
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// Line index in the diff that was commented on.
        /// </summary>
        public int Position { get; protected set; }

        /// <summary>
        /// The line number in the file that was commented on.
        /// </summary>
        public int? Line { get; protected set; }

        /// <summary>
        /// The commit 
        /// </summary>
        public string CommitId { get; protected set; }

        /// <summary>
        /// The user that created the repository comment.
        /// </summary>
        public User User { get; protected set; }

        /// <summary>
        /// The date the repository comment was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; protected set; }

        /// <summary>
        /// The date the repository comment was last updated.
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "Id: {0}, Commit Id: {1}, CreatedAt: {2}", Id, CommitId, CreatedAt);
            }
        }
    }
}
