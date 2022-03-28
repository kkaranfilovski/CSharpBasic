using SEDC.Oop.Class09.ErrorHandling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Oop.Class09.ErrorHandling
{
    public class HumanService
    {
        public List<Human> Humans { get; set; }

        public HumanService()
        {
            Humans = new List<Human>
            {
                new Human() {Name = "H1"},
                new Human(){Name = "h2", Skills = new List<Skill> { new Skill() { Points = 5, Name = "S1" } }},
                new Human() {Name = "h3", Skills = new List<Skill>()}
            };
        }

        public void PrintHumanSkills(Human human)
        {
            try
            {
                foreach (Skill skill in human.Skills)
                {
                    Console.WriteLine(skill.Name);
                }
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
        }

        public Skill GetFirstHumanSkill(Human human)
        {
            try
            {
                return human.Skills.First();
            }
            catch (InvalidOperationException)
            {
                throw new Exception("There is no skills in this human");
            }
            catch (Exception)
            {
                throw new Exception("Something wrong happened. DOnt panic!");
            }
        }

        public void PrintHumanSkills1(Human human)
        {
            if(human.Skills == null)
            {
                throw new Exception("This human does not have skills");
            }

            foreach(Skill skill in human.Skills)
            {
                Console.WriteLine(skill.Name);
            }
        }
    }

}
