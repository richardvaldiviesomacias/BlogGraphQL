using System.Collections.Generic;
using System.Linq;
using BlogGraphQL.Models.App;
using BlogGraphQL.Models.Data;

namespace BlogGraphQL.Services.Mapping
{
    public class CommentMapping
    {
        public CommentModel ToCommentModel(Comment comment)
        {
            var commentModel = new CommentModel
            {
                UserId = comment.UserId,
                Body = comment.Body,
                PostId = comment.PostId
            };

            return commentModel;
        }

        public Comment ToComment(CommentModel commentModel)
        {
            var comment = new Comment
            {
                Id = commentModel.Id,
                Body = commentModel.Body,
                UserId = commentModel.UserId,
                PostId = commentModel.PostId
            };
            return comment;
        }

        public List<CommentModel> ToCommentModels(IEnumerable<Comment> comments)
        {
            var commentModels = new List<CommentModel>();
            comments.ToList().ForEach(comment => { commentModels.Add(ToCommentModel(comment)); });
            return commentModels;
        }
    }
}