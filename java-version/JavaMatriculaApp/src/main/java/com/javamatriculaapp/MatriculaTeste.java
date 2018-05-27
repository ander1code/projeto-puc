package com.javamatriculaapp;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MatriculaTeste {

    //Método para calcular o dígito verificador de somente uma matrícula.
    public static String InformarMatricula(String matricula) {
        return MatriculaTeste.CalcularMatricula(matricula);
    }

    //Método para calcular o dígito verificador de matrículas dentro de um arquivo.
    public static int CalcularMatriculaArquivo(String path) {
        try {
            int i = 0;
            List<String> matriculas = MatriculaTeste.ObterMatriculasArquivo(path);
            if (matriculas != null) {
                for (String matricula : matriculas) {
                    matriculas.set(i, CalcularMatricula(matricula));
                    i = i + 1;
                }
            }
            return GravarEmArquivo(1, matriculas); // 1 OK or -1 Error
        } catch (Exception e) {
            return -1; // Erro gerado;
        }
    }

    //Método para testar se as verificações das matrícula no arquivo estão corretas.
    public static int TestarVerificacaoMatriculaArquivo(String path) {
        try {
            int i = 0;
            List<String> matriculas = MatriculaTeste.ObterMatriculasArquivo(path);
            if (matriculas != null) {
                String result = "";
                for (String matricula : matriculas) {
                    if(matricula.equals(CalcularMatricula(matricula.substring(0, 4))))
                    {
                        result = "Verdadeiro";
                    }
                    else
                    {
                        result = "Falso";
                    }
                    matriculas.set(i, String.format("%s - %s", matricula, result));
                    i = i + 1;
                }
            }
            return GravarEmArquivo(2, matriculas); // 1 OK or -1 Error
        } catch (Exception e) {
            return -1; // Erro gerado;
        }
    }

    //Método para obter as matriculas listadas num arquivo.
    private static List<String> ObterMatriculasArquivo(String path) {

        File file = new File(path);

        if (file.exists()) {
            List<String> list = new ArrayList<>();
            FileReader fileReader = null;
            try {
                fileReader = new FileReader(file);
            } catch (FileNotFoundException ex) {
                Logger.getLogger(MatriculaTeste.class.getName()).log(Level.SEVERE, null, ex);
            }
            BufferedReader bufferedReader = new BufferedReader(fileReader);
            String line;
            try {
                while ((line = bufferedReader.readLine()) != null) {
                    list.add(line);
                }
            } catch (IOException ex) {
                Logger.getLogger(MatriculaTeste.class.getName()).log(Level.SEVERE, null, ex);
            }
            return list;
        } else {
            return null;
        }
    }

    //Método que faz o calculo do dígito verificador da matrícula.
    private static String CalcularMatricula(String matricula) {
        try {
            int i = 6;
            int soma = 0;

            for (char item : matricula.toCharArray()) {
                soma = soma + (Integer.parseInt(String.valueOf(item)) * (--i));
            }
            int div = soma % 16;
            String hex = Integer.toHexString(div);
            return String.format("%s-%s", matricula, hex.toUpperCase());
        } catch (NumberFormatException e) {
            return "";
        }
    }

    //Método para validar entrada de uma matrícula.
    public static Boolean ValidarMatricula(String matricula) {
        String pattern = "^[0-9]{4}$";
        Pattern r = Pattern.compile(pattern);
        Matcher m = r.matcher(matricula);
        return m.matches();
    }

    //Método para gravar lista de matrícula em arquivo.
    private static int GravarEmArquivo(int opc, List<String> matriculas) {
        String name = "";
        if (opc == 1) {
            name = "matriculasComDV.txt";
        }

        if (opc == 2) {
            name = "matriculasVerificadas.txt";
        }

        try {
            try (BufferedWriter writer = new BufferedWriter(new FileWriter(new File(name)))) {
                for (String matricula : matriculas) {
                    writer.append(matricula);
                    writer.newLine();
                }
            }
            return 1;
        } catch (IOException ex) {
            Logger.getLogger(MatriculaTeste.class.getName()).log(Level.SEVERE, null, ex);
            return -1;
        }
    }
}
