using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibraryManagement.DataLayar.Repositories;

namespace LibraryManagement.DataLayar.Services
{
    public class MemberRepository : IMemberRepository
    {
        private LibraryManagement_DBEntities db;
        public MemberRepository(LibraryManagement_DBEntities context)
        {
            //give an instance of LibraryManagement_DBEntities
            db = context;
        }
        public bool DeleteMember(tb_Members member)
        {
            try
            {
                db.Entry(member).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteMember(int memberId)
        {
            try
            {
                var member = GetMemberById(memberId);
                DeleteMember(member);
                return true;
            }
            catch
            {

                return false;
            }

        }

        public List<tb_Members> GetAllMembers()
        {
            return db.tb_Members.ToList();
        }

        public IEnumerable<tb_Members> GetMemberByFilter(string parameter)
        {
            return db.tb_Members.Where(m => m.memberName.Contains(parameter) ||
            m.memberLastName.Contains(parameter) ||
            m.memberPhone.Contains(parameter)
            ).ToList();
        }

        public tb_Members GetMemberById(int memberId)
        {
            return db.tb_Members.Find(memberId);
        }

        public bool InsertMember(tb_Members member)
        {
            try
            {
                db.tb_Members.Add(member);
                return true;
            }
            catch 
            {
                return false; 
            }
        }


        public bool UpdateMember(tb_Members member)
        {
            try
            {
                db.Entry(member).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
