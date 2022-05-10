using HomeSweetHome.Core.Interfaces;
using HomeSweetHome.Core.Models;
using HomeSweetHome.Core.Services.Factories.Member;
using System;
using System.Collections.Generic;

namespace HomeSweetHome.Infra.Implementations
{
    public class MemberImplementation : IMember
    {
        public List<Member> GetByFamily()
        {
            var members = new List<Member>();

            for (int i = 0; i < GetRandomCount(); i++)
            {
                var memberTypeId = MemberTypeEnum.TypeEnum.Dependente;

                if (!members.Exists(m => m.MemberType.Id.Equals((int)MemberTypeEnum.TypeEnum.Pretendente)))
                {
                    memberTypeId = MemberTypeEnum.TypeEnum.Pretendente;
                }
                else if (!members.Exists(m => m.MemberType.Id.Equals((int)MemberTypeEnum.TypeEnum.Conjuge)))
                {
                    memberTypeId = MemberTypeEnum.TypeEnum.Conjuge;
                }

                members.Add(GetMember((int)memberTypeId));
            }

            return members;
        }

        private static Member GetMember(int memberTypeId)
        {
            var member = new MemberFactory(memberTypeId).GetNewMember();

            return member;
        }
        private static int GetRandomCount()
        {
            var random = new Random();

            return random.Next(1, 7);
        }
    }
}
