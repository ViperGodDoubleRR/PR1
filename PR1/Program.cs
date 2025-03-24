using System;
namespace GIT
{
    class Dog
    {
        public string Nickname { get; set; }
        public string Breed { get; set; }
        public float Age { get; set; }

        public Dog(string nickname, string breed, float age)
        {
            Nickname = nickname;
            Breed = breed;
            Age = age;
        }

        public string GetInfo()
        {
            return $"Собака: {Nickname}, Порода: {Breed}, Возраст: {Age} лет";
        }

        public bool IsOlderThan(float age)
        {
            return Age > age;
        }
    }

}