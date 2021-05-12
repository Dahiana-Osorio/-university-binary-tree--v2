using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;
            rectorPosition.impost = 25;

            //viserector financiero
            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector Financiero";
            vicFinPosition.Salary = 750;
            vicFinPosition.impost = 20;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;
            contadorPosition.impost = 21;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.impost = 18;


            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria Financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.impost = 10;


            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria Financiera 2";
            secFin2Position.Salary = 31;
            secFin2Position.impost = 10;


            //Vicerector academico
            Position vicAcaPosition = new Position();
            vicAcaPosition.Name = "Vicerector Academico";
            vicAcaPosition.Salary = 780;
            vicAcaPosition.impost = 25;

            Position jefeRegPosition  = new Position();
            jefeRegPosition.Name = "Jefe Registro";
            jefeRegPosition.Salary = 640;
            jefeRegPosition.impost = 18;

            Position secAca1Position = new Position();
            secAca1Position.Name = "Secretaria Academica 1";
            secAca1Position.Salary = 400;
            secAca1Position.impost = 10;

            Position asisAca1Position = new Position();
            asisAca1Position.Name = "Asistente Academico 1";
            asisAca1Position.Salary = 250;
            asisAca1Position.impost = 8;

            Position asisAca2Position = new Position();
            asisAca2Position.Name = "Asistente Academico 2";
            asisAca2Position.Salary = 170;
            asisAca2Position.impost = 8;

            Position mensAsisPosition = new Position();
            mensAsisPosition.Name = "Mensajero  de Asistente2";
            mensAsisPosition.Salary = 90;
            mensAsisPosition.impost = 5;

            Position secAca2Position = new Position();
            secAca2Position.Name = "Secretaria Academica 2";
            secAca2Position.Salary = 360;
            secAca2Position.impost = 10;


            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcaPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcaPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secAca1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asisAca1Position, secAca1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asisAca2Position, secAca1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensAsisPosition, asisAca2Position.Name);
            universityTree.CreatePosition(universityTree.Root, secAca2Position, jefeRegPosition.Name);



            universityTree.PrintTree(universityTree.Root);
            universityTree.HigherSalaryDiffrector(universityTree.Root);
            universityTree.ImprintSalarySearch(universityTree.Root, "Secretaria FINANCIERA 2");
            float totalSalary = universityTree.AddSalaries(universityTree.Root);


            Console.WriteLine($"Total Salaries:  {totalSalary}");
            float totalprom = universityTree.AvarageSalaries(universityTree.Root);
            Console.WriteLine($"The average salary is: {totalprom}");
            Console.WriteLine(universityTree.ImprintSalary());
            Console.WriteLine(universityTree.ImprintRole());
            Console.WriteLine($"The sum of the impost is: { universityTree.AddSalariesImpost(universityTree.Root)}");
            Console.ReadLine();

            

        }
    }
}
