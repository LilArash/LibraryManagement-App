using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataLayar.Repositories
{
    public interface IMemberRepository
    {
        List<tb_Members> GetAllMembers();
        IEnumerable<tb_Members> GetMemberByFilter(string parameter);
        tb_Members GetMemberById(int memberId);
        bool InsertMember(tb_Members member);
        bool UpdateMember(tb_Members member);
        bool DeleteMember(tb_Members member);
        bool DeleteMember(int memberId);
        
    }
}
