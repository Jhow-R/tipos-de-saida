using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeSaida
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            Console.WriteLine("REF");
            Console.WriteLine("Antes da chamada do método, valor de a : {0}", a);
            // Deve ser inicializado no método de chamada antes de ser passado para o método chamado
            ValueRef(ref a);
            Console.WriteLine("Depois da chamada do método, valor de a : {0} \n", a);


            int b;
            Console.WriteLine("OUT");
            // O argumento pode ser passado mesmo sem valor atribuido
            ValueOut(out b);
            Console.WriteLine("Depois da chamada do método, valor de b : {0} \n", b);


            int c = 1;
            Console.WriteLine("IN");
            Console.WriteLine("Antes da chamada do método, valor de c : {0}", c);
            // Este valor não pode ser alterado
            ValueIn(in c);
            Console.WriteLine("Depois da chamada do método, valor de c : {0} \n", c);

            Console.WriteLine("KEY VALUE PAIR");
            var pair = GetTwoNumbers();
            Console.WriteLine("Chave: " + pair.Key);
            Console.WriteLine("Valor: " + pair.Value + "\n");

            Console.WriteLine("TUPLE");
            var tupla = GetTupla("Hello ", "World");
            Console.ReadLine();
        }

        // Ref: o valor do referido parâmetro é mudado no método, que se reflete no método de chamada
        public static void ValueRef(ref int a)
        {
            a = 10;
        }

        // Out: deve ser inicializado no método antes de retornar a chamada do mesmo
        public static void ValueOut(out int b)
        {
            b = 10;
        }

        // In: o parâmetro é um "ref readonly"
        public static int ValueIn(in int c)
        {
            return c;
        }

        // Key Value Pair
        static KeyValuePair<int, int> GetTwoNumbers()
        {
            return new KeyValuePair<int, int>((int)Math.Pow(2, 2), (int)Math.Pow(3, 2));
        }

        // Tuple
        static Tuple<string, string> GetTupla(string str1, string str2)
        {
            // Construtor
            var t1 = new Tuple<string, string>("Hello ", "World");
            Console.WriteLine(t1);
            
            // Método estático
            Tuple<string, string> t2 = Tuple.Create("Hello ", "World");
            Console.WriteLine(t2.Item1 + t2.Item2);
            
            // Inferência implícita
            var t3 = Tuple.Create("Hello ", "World");

            return new Tuple<string, string>(str1, str2);
        }

        #region only on VS 2019
        /*
        public (int, string) ReturnsIntAndString()
        {
            return (1, "two");
        }

        public (int inteiro, string texto) ReturnsIntAndString()
        {
            return (1, "two");
        }
        */
        #endregion
    }
}
