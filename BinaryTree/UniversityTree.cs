using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class UniversityTree
    {
        public Nodo_position Root;

        public void CreatePosition (Nodo_position padre, Position positionToCreate, string padrePositionName)
        {
            Nodo_position newNodo = new Nodo_position();
            newNodo.Position = positionToCreate;

            if(Root == null)
            {
                Root = newNodo;
                return;
            }

            if(padre == null)
            {
                return;
            }

            if(padre.Position.name == padrePositionName)
            {
                if(padre.Left == null)
                {
                    padre.Left = newNodo;
                    return;
                }
                padre.Right = newNodo;
                return;
            }
            CreatePosition(padre.Left, positionToCreate, padrePositionName);
            CreatePosition(padre.Right, positionToCreate, padrePositionName);
        }

        public void PrintTree(Nodo_position from)
        {
            if(from == null)
            {
                return;
            }
            System.Console.WriteLine($"{from.Position.name} : ${from.Position.salary}");
            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float AddSalaries(Nodo_position from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.salary + AddSalaries(from.Left) + AddSalaries(from.Right);
        }
    }
}
