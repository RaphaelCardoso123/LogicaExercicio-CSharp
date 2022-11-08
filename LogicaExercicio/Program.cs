
namespace Course {
    class Program {
        static void Main(string[] args) {

            static void CalcularMedia() {

                Console.WriteLine("Digite a quantidade de notas a ser calculada: ");
                int quantNotas = Convert.ToInt32(Console.ReadLine());

                double soma = 0;
                for (int i = 1; i <= quantNotas; i++) {
                    Console.WriteLine("Digite a " + i + "° nota: ");
                    double notas = Convert.ToDouble(Console.ReadLine());
                    soma += notas;
                }

                double media;
                media = soma / quantNotas;
                Console.WriteLine("A média do aluno foi de: " + media);

                if (media >= 6) {
                    Console.WriteLine("Parabéns, você passou!!");
                }
                else {
                    Console.WriteLine("Você reprovou!!");
                }

                Console.WriteLine("Deseja calcular outra média?");
                Console.WriteLine("Digite 1 para sim");
                int outraMedia = Convert.ToInt32(Console.ReadLine());

                switch (outraMedia) {
                    case 1:
                        CalcularMedia();
                        break;
                    default:
                        break;
                }
            }
            CalcularMedia();
        }
    }
}