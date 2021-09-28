using System.Collections.Generic;
using BlogGraphQL.Models.App;
using BlogGraphQL.Models.Data;

namespace BlogGraphQL.Services.Mapping
{
    public interface ICommentMapping
    {
        CommentModel ToCommentModel(Comment comment);
        Comment ToComment(CommentModel commentModel);
        List<CommentModel> ToCommentModels(IEnumerable<Comment> comments);
    }
}