using HomeSweetHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HomeSweetHome.Services.Implementations
{
    public class MemberServiceImplementation : IMemberService
    {
        private volatile int _memberId;
        public List<Member> GetAll()
        {
            var members = new List<Member>();

            for(int i=0; i < 20; i++)
            {
                //members.Add(GetMember());
            }

            return members;
        }

        public List<Member> GetByFamily()
        {
            var members = new List<Member>();

            for (int i = 0; i < GetRandomCount(); i++)
            {
                int memberTypeId = 3;

                if (!members.Exists(m => m.MemberType.Id.Equals(1)))
                {
                    memberTypeId = 1;
                }
                else if (!members.Exists(m => m.MemberType.Id.Equals(2)))
                {
                    memberTypeId = 2;
                }

                members.Add(GetMember(memberTypeId));
            }

            return members;
        }

        private Member GetMember(int memberTypeId)
        {
            int id = GenerateId();

            var member = new Member()
            {
                Id = id,
                FirstName = "Membro Nº " + id,
                LastName = "Membro Sobrenome " + id,
                Age = GetRandomAge(memberTypeId),
                Salary = GetRandomSalary(),
                MemberType = GetMemberType(memberTypeId)
            };

            return member;
        }

        private MemberType GetMemberType(int id)
        {
            var memberType = new List<MemberType>();

            memberType.Add(new MemberType { Id = 1, Type = "Pretendente" });
            memberType.Add(new MemberType { Id = 2, Type = "Conjuge" });
            memberType.Add(new MemberType { Id = 3, Type = "Dependente" });

            return memberType.Find(m => m.Id == id);
        }
        private decimal GetRandomSalary()
        {
            var random = new Random();

            return random.Next(500, 1500);
        }
        private int GetRandomAge(int memberId)
        {
            var random = new Random();

            if (memberId == 1 || memberId == 2)
            {
                return random.Next(18, 80);
            }

            return random.Next(1, 20);
        }
        private int GetRandomCount()
        {
            var random = new Random();

            return random.Next(1, 8);
        }
        private int GenerateId()
        {
            return Interlocked.Increment(ref _memberId);
        }
    }
}
