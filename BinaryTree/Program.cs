using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.name = "Rector";
            rectorPosition.salary = 1000;

            Position vicFinancieroPosition = new Position();
            vicFinancieroPosition.name = "Vicepresidente Financiero";
            vicFinancieroPosition.salary = 750;
            Position contadorFinPosition = new Position();
            contadorFinPosition.name = "Contador Financiero";
            contadorFinPosition.salary = 500;
            Position jefeFinPosition = new Position();
            jefeFinPosition.name = "Jefe Financiero";
            jefeFinPosition.salary = 610;
            Position secre1FinPosition = new Position();
            secre1FinPosition.name = "Secretaria1 Financiero";
            secre1FinPosition.salary = 350;
            Position secre2FinPosition = new Position();
            secre2FinPosition.name = "Secretaria2 Financiero";
            secre2FinPosition.salary = 310;


            Position vicAcademicoPosition = new Position();
            vicAcademicoPosition.name = "Vicepresidente Academico";
            vicAcademicoPosition.salary = 780;
            Position jefeAcademicoPosition = new Position();
            jefeAcademicoPosition.name = "Jefe Academico";
            jefeAcademicoPosition.salary = 640;
            Position secre2AcademicoPosition = new Position();
            secre2AcademicoPosition.name = "Secretria2 Academico";
            secre2AcademicoPosition.salary = 360;
            Position secre1AcademicoPosition = new Position();
            secre1AcademicoPosition.name = "Secretria1 Academico";
            secre1AcademicoPosition.salary = 400;
            Position asist2AcademicoPosition = new Position();
            asist2AcademicoPosition.name = "Asistente2 Academico";
            asist2AcademicoPosition.salary = 170;
            Position asist1AcademicoPosition = new Position();
            asist1AcademicoPosition.name = "Asistente1 Academico";
            asist1AcademicoPosition.salary = 250;
            Position mensajeroAcademicoPosition = new Position();
            mensajeroAcademicoPosition.name = "Mensajero Academico";
            mensajeroAcademicoPosition.salary = 90;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);

            universityTree.CreatePosition(universityTree.Root, vicFinancieroPosition, rectorPosition.name);
            universityTree.CreatePosition(universityTree.Root, contadorFinPosition, vicFinancieroPosition.name);
            universityTree.CreatePosition(universityTree.Root, secre1FinPosition, contadorFinPosition.name);
            universityTree.CreatePosition(universityTree.Root, secre2FinPosition, contadorFinPosition.name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinancieroPosition.name);

            universityTree.CreatePosition(universityTree.Root, vicAcademicoPosition, rectorPosition.name);
            universityTree.CreatePosition(universityTree.Root, jefeAcademicoPosition, vicAcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, secre2AcademicoPosition, jefeAcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, secre1AcademicoPosition, jefeAcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, asist2AcademicoPosition, secre1AcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, mensajeroAcademicoPosition, asist2AcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, asist1AcademicoPosition, secre1AcademicoPosition.name);

            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salarios: ${totalSalary}");

            Console.ReadLine();
        }
    }
}
