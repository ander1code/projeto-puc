
import com.javamatriculaapp.MatriculaTeste;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        String key = "";

        System.out.println("-----------------------------------------------------|");
        System.out.println("VERIFICAÇÃO DE MATRÍCULAS ---------------------------|");
        System.out.println("-----------------------------------------------------|");

        while (!"0".equals(key)) {
            String opc = "";
            System.out.println("OPÇÕES: ---------------------------------------------|");
            System.out.println("1 - INFORMAR MATRÍCULA ------------------------------|");
            System.out.println("2 - CALCULAR MATRÍCULAS EM ARQUIVO ------------------|");
            System.out.println("3 - TESTAR VERIFICAÇÃO DE MATRÍCULAS EM ARQUIVO -----|");
            System.out.println("-----------------------------------------------------|");

            Scanner ler = new Scanner(System.in);
            System.out.print("\nInforme a opção: ");
            opc = ler.next();

            switch (opc) {
                case "1":
                    Main.DigitarMatricula();
                    break;
                case "2":
                    Main.CalcularMatriculaArquivo();
                    break;
                case "3":
                    Main.TestarVerificacaoMatriculaArquivo();
                    break;
                default:
                    System.out.println("Opção inválida.");
                    break;
            }
            Scanner cont = new Scanner(System.in);
            System.out.print("\nDeseja continuar? (Informe 0 e ENTER para terminar): ");
            key = cont.next();
        }
        System.out.print("\nTerminou.");
    }

    private static void DigitarMatricula() {
        Scanner ler = new Scanner(System.in);
        System.out.print("Informe a matrícula:  ");
        String matricula = ler.next();
        if (MatriculaTeste.ValidarMatricula(matricula)) {
            System.out.println("Matrícula verificada: " + MatriculaTeste.InformarMatricula(matricula));
        } else {
            System.out.println("Matrícula inválida para verificação.");
        }
    }

    private static void CalcularMatriculaArquivo() {
        int result = MatriculaTeste.CalcularMatriculaArquivo("matriculasSemDV.txt");
        if (result == 1) {
            System.out.println("Verificações de matrículas em arquivo efetuadas.");
        }

        if (result == 0) {
            System.out.println("Não foi encontrado o arquivo com a lista de matrículas para serem verificadas.");
        }

        if (result == -1) {
            System.out.println("Erro ao efetuar a verificação de matrícula.");
        }
    }

    private static void TestarVerificacaoMatriculaArquivo() {
        int result = MatriculaTeste.TestarVerificacaoMatriculaArquivo("matriculasParaVerificar.txt");
        if (result == 1) {
            System.out.println("Teste da verificação de matrículas efetuado.");
        }

        if (result == 0) {
            System.out.println("Não foi encontrado o arquivo com a lista de matrículas para testar suas verificações.");
        }

        if (result == -1) {
            System.out.println("Erro ao efetuar o teste de verificação das matrículas.");
        }
    }
}
