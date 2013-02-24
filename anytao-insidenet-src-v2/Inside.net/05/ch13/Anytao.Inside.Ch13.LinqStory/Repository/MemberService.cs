// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch13.LinqStory
// Release     : 2011/01/05 1.0
// Description : 13.4  LINQ江湖

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch13.LinqStory.Repository
{
    public class MemberService
    {
        IMemberRepository repository = new MemberRepository();

        /// <summary>
        /// Get member info by id
        /// </summary>
        /// <param name="id">Member's id</param>
        /// <returns></returns>
        public Member Get(int id)
        {
            return repository.Load(x => x.Id == id);
        }

        /// <summary>
        /// Verify member's info by email and password
        /// </summary>
        /// <param name="email">Member's email</param>
        /// <param name="password">Member's password</param>
        /// <returns></returns>
        public bool Varify(string email, string password)
        {
            var entity = repository.Load(x => x.Email == email && x.Password == password);

            return entity != null ? true : false;
        }

        /// <summary>
        /// Register a new member
        /// </summary>
        /// <param name="model"></param>
        public void Register(Member model)
        {
            var entity = repository.Loads(x => x.Id == model.Id).FirstOrDefault();

            if (entity == null)
            {
                repository.Add(entity);
            }
        }

        // 省略其他
    }
}
