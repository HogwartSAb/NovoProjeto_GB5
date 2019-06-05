using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princiapal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circulo C = null;
                Quadrado Q = null;
                Triangulo T = null;
                List<Figura> formasgeo = new List<Figura>();
                int op;

                do
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine(" 1. Adicionar  Quadrado");
                    Console.WriteLine(" 2. Adicionar Triângulo");
                    Console.WriteLine(" 3. Adicionar Círculo");
                    Console.WriteLine(" 4. Mostrar o Nome, a Cor e a Área de uma determinada figura");
                    Console.WriteLine(" 5. Sair");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.Write("Sua opção: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Q = new Quadrado();
                            Console.Write("Nome: ");
                            Q.Nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            Q.Cor = Console.ReadLine();
                            Console.Write("Tamanho dos lados: ");
                            Q.Lado = double.Parse(Console.ReadLine());
                            formasgeo.Add(Q);
                            break;
                        case 2:
                            T = new Triangulo();
                            Console.Write("Nome: ");
                            T.Nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            T.Cor = Console.ReadLine();
                            Console.Write("Altura: ");
                            T.AlturaT = double.Parse(Console.ReadLine());
                            Console.Write("Base: ");
                            T.BaseT = double.Parse(Console.ReadLine());
                            formasgeo.Add(T);
                            break;
                        case 3:
                            C = new Circulo();
                            Console.Write("Nome: ");
                            C.Nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            C.Cor = Console.ReadLine();
                            Console.Write("Raio: ");
                            C.Raio = double.Parse(Console.ReadLine());
                            formasgeo.Add(C);
                            break;
                        case 4:
                            Console.Write("Nome da figura: ");
                            string nome_figura = Console.ReadLine();
                            bool achou = false;
                            foreach (Figura f in formasgeo)
                            {
                                if (f.Nome == nome_figura)
                                {
                                    Console.Write("Nome: " + f.Nome + " Cor: " + " Área: " + f.Area().ToString("0.00"));
                                    achou = true;
                                    break;
                                }
                            }
                            if (!achou)
                                Console.Write("Figura não encontrada! ");
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }
                } while (op != 5);
            }
            catch (DivideByZeroException d)
            {
                Console.Write(d.Message);
            }
        }

    }
}
