import database.Conexion;
import paqueteFarmacias.ClsFarmacia;
import paqueteFarmacias.OperacionesFarmacia;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.text.DecimalFormat;
import java.util.LinkedList;

public class Main {
    public static void main(String[] args) {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Conexion conexion = new Conexion();
        OperacionesFarmacia opFarm = new OperacionesFarmacia();
        LinkedList<ClsFarmacia> farmacias;
        LinkedList<String> farmaciasProcesadas = new LinkedList<>();
        LinkedList<String> barrios;
        DecimalFormat formatoPrecio = new DecimalFormat("#0.00");
        ClsFarmacia seleccionado;
        int opcion, indexSeleccionado;
        String respuesta;
        while (true) {
            try {
                System.out.println("\n--- MENÚ PRINCIPAL ---");
                System.out.println("1. Mostrar/Generar PDF de farmacias cercanas");
                System.out.println("2. Mostrar top 10 medicamentos más consultados");
                System.out.println("3. Salir");
                System.out.print("Eleccion: ");
                opcion = Integer.parseInt(br.readLine());

                switch (opcion) {
                    case 1:

                        barrios = opFarm.consultarBarrios(conexion);
                        do {
                            System.out.println("----------------------------------------------------------------------------------------");
                            System.out.println("Seleccione su barrio:");

                            for (int i = 0; i < barrios.size(); i++) {
                                System.out.println((i + 1) + ". " + barrios.get(i));
                            }

                            try {
                                System.out.print("Elección: ");
                                indexSeleccionado = Integer.parseInt(br.readLine()) - 1;
                                String barrioSeleccionado = barrios.get(indexSeleccionado);

                                farmacias = opFarm.consultarFarmaciasPorBarrio(conexion, barrioSeleccionado);

                                if (farmacias.isEmpty()) {
                                    System.out.println("No se encontraron farmacias en ese barrio.");
                                } else {
                                    System.out.println("¿Qué desea hacer?");
                                    System.out.println("1. Generar PDF");
                                    System.out.println("2. Mostrar en pantalla");
                                    System.out.print("Opción: ");
                                    opcion = Integer.parseInt(br.readLine());

                                    switch (opcion) {
                                        case 1:
                                            opFarm.generarPDF(farmacias, "FarmaciasCercanas.pdf");
                                            System.out.println("PDF generado exitosamente.");
                                            break;

                                        case 2:
                                            for (int i = 0; i < farmacias.size(); i++) {
                                                ClsFarmacia f = farmacias.get(i);
                                                String identificador = f.getNombre() + "|" + f.getDireccion();

                                                if (!farmaciasProcesadas.contains(identificador)) {
                                                    farmaciasProcesadas.add(identificador);

                                                    System.out.println("--------------------------------------------------");
                                                    System.out.println("Nombre: " + f.getNombre());
                                                    System.out.println("Barrio: " + f.getBarrio().toUpperCase());
                                                    System.out.println("Dirección: " + f.getDireccion());
                                                    System.out.println("Medicamentos:");

                                                    for (int j = 0; j < farmacias.size(); j++) {
                                                        ClsFarmacia temp = farmacias.get(j);
                                                        String tempIdentificador = temp.getNombre() + "|" + temp.getDireccion();

                                                        if (tempIdentificador.equals(identificador)) {
                                                            System.out.println("- " + temp.getMedicamento() + " ($" + formatoPrecio.format(temp.getPrecio()) + ")");
                                                        }
                                                    }
                                                }
                                            }
                                            break;

                                        default:
                                            System.out.println("Opción no válida.");
                                            break;
                                    }
                                }

                            } catch (IndexOutOfBoundsException | NumberFormatException e) {
                                System.out.println("Elija una opción correcta. Intente de nuevo. " + e.getMessage());
                            }
                            break;

                        } while (true);

                        break;
                    case 2:
                        Connection cnn = conexion.establecer_conexion();
                        CallableStatement cstmt = cnn.prepareCall("{call sp_Top10MedicamentosMasConsultados}");
                        ResultSet rs = cstmt.executeQuery();
                        System.out.println("\nTop 10 medicamentos más consultados:");
                        while (rs.next()) {
                            System.out.println("ID: " + rs.getInt("id_medicamento") +
                                    ", Nombre: " + rs.getString("nombre_comercial") +
                                    ", Consultas: " + rs.getInt("total_consultas"));
                        }
                        rs.close();
                        cstmt.close();
                        cnn.close();
                        break;

                    case 3:
                        System.out.println("¡Hasta luego!");
                        return;

                    default:
                        System.out.println("Opción inválida.");
                }
            } catch (NumberFormatException e) {
                System.out.println("Error: Debe ingresar un número válido");
            } catch (Exception e) {
                System.out.println("Error: " + e.getMessage());
            }
        }
    }
}


