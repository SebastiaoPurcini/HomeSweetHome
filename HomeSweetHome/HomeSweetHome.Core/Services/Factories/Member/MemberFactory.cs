﻿using HomeSweetHome.Core.Interfaces;
using HomeSweetHome.Core.Models;
using System;
using System.Collections.Generic;

namespace HomeSweetHome.Core.Services.Factories.Member
{
    public class MemberFactory : IMemberFactory
    {
        private int _memberTypeId;

        public MemberFactory(int memberTypeId)
        {
            _memberTypeId = memberTypeId;
        }
        public Models.Member GetNewMember()
        {
            int id = 0, age = 0;
            
            id = CommonFactory.GenerateId();
            age = GetRandomAge();

            var member = new Models.Member()
            {
                Id = id,
                FirstName = $"Membro Nº {id}",
                LastName = $"Membro Sobrenome {id}",
                Age = age,
                Salary = GetRandomSalary(age),
                MemberType = GetMemberType()
            };

            return member;
        }

        private MemberType GetMemberType()
        {
            var memberType = new List<MemberType>();

            memberType.Add(new MemberType { Id = 1, Type = "Pretendente" });
            memberType.Add(new MemberType { Id = 2, Type = "Conjuge" });
            memberType.Add(new MemberType { Id = 3, Type = "Dependente" });

            return memberType.Find(m => m.Id == _memberTypeId);
        }

        private decimal GetRandomSalary(int age)
        {
            var random = new Random();

            // Essa validação foi aplicada apenas para o
            // gerador de salários dos integrados se diferenciar,
            // para assim gerar uma métrica melhor na pontuação

            if (_memberTypeId == 3 && age < 18)
            {
                return 0;
            }
            else if (_memberTypeId == 2)
            {
                return random.Next(0, 800); ;
            }

            return random.Next(200, 1500);
        }

        private int GetRandomAge()
        {
            var random = new Random();

            if (_memberTypeId == 1 || _memberTypeId == 2)
            {
                return random.Next(18, 80);
            }

            return random.Next(1, 20);
        }
    }
}