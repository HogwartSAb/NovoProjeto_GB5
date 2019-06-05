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
                            Q.nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            Q.cor = Console.ReadLine();
                            Console.Write("Tamanho dos lados: ");
                            Q.lado = double.Parse(Console.ReadLine());
                            Lista_Figura.Add(Q);
                            break;
                        case 2:
                            T = new Triangulo();
                            Console.Write("Nome: ");
                            T.nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            T.cor = Console.ReadLine();
                            Console.Write("Altura: ");
                            T.altura = double.Parse(Console.ReadLine());
                            Console.Write("Base: ");
                            T.Base = double.Parse(Console.ReadLine());
                            Lista_Figuras.Add(T);
                            break;
                        case 3:
                            C = new Circulo();
                            Console.Write("Nome: ");
                            C.nome = Console.ReadLine();
                            Console.Write("Cor: ");
                            C.cor = Console.ReadLine();
                            Console.Write("Raio: ");
                            C.Raio = double.Parse(Console.ReadLine());
                            Lista_Figuras.Add(C);
                            break;
                        case 4:
                            Console.Write("Nome da figura: ");
                            string nome_figura = Console.ReadLine();
                            bool achou = false;
                            foreach (Figura f in Lista_Figuras)
                            {
                                if (f.nome == nome_figura)
                                {
                                    Console.Write("Nome: " + f.nome + " Cor: " + " Área: " + f.area().ToString("0.00"));
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
