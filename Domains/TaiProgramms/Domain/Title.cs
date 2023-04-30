﻿using Common.Entities;

namespace TaiProgramms.Domain
{
    public class Title : ValueObject<Title>
    {
        public string Name { get; init; }

        public Title(string name)
        {
            Name = (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                ? throw new Exception("Заполните название программы.")
                : name;
        }

        protected override bool EqualsCore(Title valueObject)
            => Name == valueObject.Name;


        protected override int GetHashCodeCore()
            => Name.GetHashCode();
    }
}
