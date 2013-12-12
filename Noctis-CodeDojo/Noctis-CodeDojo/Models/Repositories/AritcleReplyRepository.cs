using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Noctis_CodeDojo.Models.Repositories.Base;
namespace Noctis_CodeDojo.Models.Repositories
{
    public class ArticleReplyRepository : EFRepository<ArticleReply>, IArticleReplyRepository
    {
        public ArticleReplyRepository()
        {
            this.UnitOfWork = new EFUnitOfWork();
        } //Constructor

        #region Create
        /// <summary>新增會員</summary>
        public int Create(ArticleReply Model)
        {
            this.Add(Model);
            this.UnitOfWork.Commit();
            return Model.Id;
        }
        #endregion



    }
    public interface IArticleReplyRepository : IRepository<ArticleReply>
    {

    }
}