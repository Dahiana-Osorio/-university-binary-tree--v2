using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;
        public int cont = 0;
        public float highersalary = 0;
        public string highersalaryworker = "";
        public string search = "";

        public void CreatePosition(PositionNode parent, Position positionToCreate, string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            if (parent == null)
            {
                return;
            }

            if (parent.Position.Name == parentPositionName)
            {
                if (parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }
                parent.Rigth = newNode;
                return;
            }

            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Rigth, positionToCreate, parentPositionName);
        }

        public void PrintTree(PositionNode from)
        {
            if (from == null)
            {
                return;
            }
            else
            {
                cont++;
            }
            from.Position.impost = from.Position.Salary * (from.Position.impost / 100);

            Console.WriteLine($"{from.Position.Name} : Except Impost ${from.Position.Salary} ---- Impost ${from.Position.impost} ------ Total Salary {from.Position.Salary - from.Position.impost}");

            PrintTree(from.Left);
            PrintTree(from.Rigth);
        }

        public float AddSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Rigth);
        }

        public float AddSalariesImpost(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return from.Position.impost + AddSalariesImpost(from.Left) + AddSalariesImpost(from.Rigth);
        }

        // Metodo promedio 
        public float AvarageSalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return (from.Position.Salary + AddSalaries(from.Left) + AddSalaries(from.Rigth)) / cont;
        }

        //Sario mayor diferente al del rector
        public void HigherSalaryDiffrector(PositionNode from)
        {
            if (from == null)
            {
                return;
            }

            if (from.Position.Name == "Rector")
            {

            }
            else 
            {
                if (highersalary < from.Position.Salary)
                {
                    highersalary = from.Position.Salary;
                    highersalaryworker = from.Position.Name;
                }
                   
            }

            HigherSalaryDiffrector(from.Left);
            HigherSalaryDiffrector(from.Rigth);
        }

        // imprimir el salario alto
        public string ImprintSalary()
        {
            return $"The highest worker's salary is that of the {highersalaryworker} : {highersalary}";
        }

        // imprimir salario buscado
        public void ImprintSalarySearch(PositionNode from, string role)
        {
            if (from == null)
            {
                return;
            }

            if (from.Position.Name.ToLower() == role.ToLower())
            {
                search = $"{from.Position.Name} : {from.Position.Salary}";
            }

            ImprintSalarySearch(from.Left, role);
            ImprintSalarySearch(from.Rigth, role);
        }

        //imprime el rol que se busco
        public string ImprintRole()
        {
            return search;
        }
    }

}
