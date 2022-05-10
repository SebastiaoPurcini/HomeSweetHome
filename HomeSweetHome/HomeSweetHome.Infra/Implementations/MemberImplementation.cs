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
            var member = new MemberFactory(memberTypeId).GetNewMember();

            return member;
        }
        private int GetRandomCount()
        {
            var random = new Random();

            return random.Next(1, 7);
        }
    }
}
