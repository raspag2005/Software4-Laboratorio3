import com.microsoft.sqlserver.jdbc.SQLServerException;
import database.Conexion;
import paqueteMedicamentos.ClsMedicamento;
import paqueteMedicamentos.OperacionesMedicamento;

import javax.swing.*;
import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.LinkedList;

public class Main {
    public static void main(String[] args) throws Exception {
        Conexion conexion = new Conexion();
        OperacionesMedicamento operaciones = new OperacionesMedicamento();
        JFileChooser fileChooser = new JFileChooser();
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        // Obtener los medicamentos como LinkedList
        LinkedList<ClsMedicamento> medicamentos;
        ClsMedicamento seleccionado;
        int opcion = 0, indexSeleccionado;
        String nombreComercial, nombreGenerico, nuevoNombreGenerico, nuevoNombreComercial;
        do {
            System.out.println("----------------------------------------------------------------------------------------");
            System.out.println("Bienvenido al sistema de gestión de medicamentos y farmacias");
            System.out.println("Seleccione una opción:");
            System.out.println("1. Medicamentos");
            System.out.println("2. Farmacias");
            System.out.println("3. Salir");
            System.out.print("Eleccion: ");
            try {
                opcion = Integer.parseInt(br.readLine());
                switch (opcion) {
                    case 1: // Menú Medicamentos
                        do {
                            System.out.println("----------------------------------------------------------------------------------------");
                            System.out.println("Menú de Medicamentos");
                            System.out.println("Seleccione una opción:");
                            System.out.println("1. Insertar"); //Masivamente por CSV y manualmente
                            System.out.println("2. Consultar"); //Consultar por parametrización
                            System.out.println("3. Modificar");
                            System.out.println("4. Eliminar");
                            System.out.println("5. Volver");
                            System.out.print("Eleccion: ");
                            try {
                                opcion = Integer.parseInt(br.readLine());
                                switch (opcion) {
                                    case 1:
                                        do {
                                            System.out.println("----------------------------------------------------------------------------------------");
                                            System.out.println("Submenú Insertar");
                                            System.out.println("Seleccione una opción de inserción:");
                                            System.out.println("1. Insertar desde CSV");
                                            System.out.println("2. Insertar manualmente");
                                            System.out.println("3. Volver");
                                            System.out.print("Eleccion: ");
                                            try {
                                                opcion = Integer.parseInt(br.readLine());
                                                switch (opcion) {
                                                    case 1: // Insertar desde CSV
                                                        try {
                                                            int resultado = fileChooser.showOpenDialog(null);
                                                            if (resultado == JFileChooser.APPROVE_OPTION) {
                                                                File archivo = fileChooser.getSelectedFile();
                                                                if (operaciones.insertarDesdeCSV(conexion, archivo)) {
                                                                    System.out.println("========================================");
                                                                    System.out.println("== Medicamentos insertados desde CSV. ==");
                                                                    System.out.println("========================================");
                                                                } else {
                                                                    System.out.println("Error al insertar...");
                                                                }
                                                            } else if (resultado == JFileChooser.CANCEL_OPTION) {
                                                                System.out.println("Inserción cancelada");
                                                            }
                                                        } catch (SQLServerException e) {
                                                            System.out.println("Error al insertar...\nAlgunos registros ya existen.\n" + e.getMessage());
                                                        }
                                                        break;
                                                    case 2: // Insertar manualmente
                                                        try {
                                                            System.out.println("----------------------------------------------------------------------------------------");
                                                            System.out.println("Inserción de registro manual: ");

                                                            boolean repetir = true;
                                                            while (repetir) {
                                                                System.out.print("Ingrese el nombre comercial: ");
                                                                nombreComercial = br.readLine();

                                                                if (nombreComercial == null || nombreComercial.trim().isEmpty()) {
                                                                    System.out.println("----------------------------------------------------------------------------------------");
                                                                    System.out.println("El nombre comercial no debe estar vacío.");
                                                                    continue; // vuelve a pedir nombre comercial
                                                                }

                                                                System.out.print("Ingrese el nombre genérico: ");
                                                                nombreGenerico = br.readLine();

                                                                if (nombreGenerico == null || nombreGenerico.trim().isEmpty()) {
                                                                    System.out.println("----------------------------------------------------------------------------------------");
                                                                    System.out.println("El nombre genérico no debe estar vacío.");
                                                                    continue; // vuelve a pedir ambos campos
                                                                }

                                                                try {
                                                                    operaciones.insertarMedicamento(conexion, nombreComercial, nombreGenerico);
                                                                    System.out.println("----------------------------------------------------------------------------------------");
                                                                    System.out.println("Medicamento insertado manualmente.");

                                                                    // Preguntar si desea insertar otro
                                                                    System.out.print("¿Desea insertar otro medicamento? (s/n): ");
                                                                    String respuesta = br.readLine();
                                                                    if (!respuesta.equalsIgnoreCase("s")) {
                                                                        repetir = false;
                                                                    }

                                                                } catch (SQLServerException e) {
                                                                    System.out.println("Error al insertar: '" + nombreComercial + "' ya registrado u otro problema.");
                                                                    System.out.println("Mensaje del servidor: " + e.getMessage());

                                                                    // Preguntar si desea intentar de nuevo
                                                                    System.out.print("¿Desea intentar de nuevo? (s/n): ");
                                                                    String respuesta = br.readLine();
                                                                    if (!respuesta.equalsIgnoreCase("s")) {
                                                                        repetir = false;
                                                                    }
                                                                }
                                                            }

                                                        } catch (IOException e) {
                                                            System.out.println("Error de entrada/salida: " + e.getMessage());
                                                        }
                                                        break;
                                                    case 3: // Volver
                                                        break;
                                                    default:
                                                        System.out.println("----------------------------------------------------------------------------------------");
                                                        System.out.println("Opción no válida. Intente de nuevo.");
                                                        break;
                                                }
                                            } catch (NumberFormatException e) {
                                                System.out.println("----------------------------------------------------------------------------------------");
                                                System.out.println("Ingrese un número válido");
                                            }
                                        } while (opcion != 3);
                                        break;
                                    case 2:
                                        do {
                                            System.out.println("----------------------------------------------------------------------------------------");
                                            System.out.println("Submenú Consulta");
                                            System.out.println("Seleccione una opción de consulta:");
                                            System.out.println("1. Consultar todos (procedimiento almacenado)");
                                            System.out.println("2. Consultar por ID o Nombre (procedimiento almacenado)");
                                            System.out.println("3. Volver");
                                            System.out.print("Eleccion: ");
                                            try {
                                                opcion = Integer.parseInt(br.readLine());
                                                switch (opcion) {
                                                    case 1:
                                                        for (ClsMedicamento m : operaciones.consultarTodos(conexion)) {
                                                            System.out.println("ID: " + m.getId()
                                                                    + ", Nombre Comercial: " + m.getNombreComercial()
                                                                    + ", Nombre Genérico: " + m.getNombreGenerico());
                                                        }
                                                        break;
                                                    case 2:
                                                        System.out.print("Ingrese ID, Nombre comercial o genérico a consultar:");
                                                        String nombreBuscar = br.readLine();
                                                        String resultadoConsulta = operaciones.consultarPorNombre(conexion, nombreBuscar);
                                                        System.out.println(resultadoConsulta);
                                                        break;
                                                    case 3:
                                                        break;
                                                    default:
                                                        System.out.println("Opción no válida. Intente de nuevo.");
                                                        break;
                                                }
                                            } catch (NumberFormatException e) {
                                                System.out.println("Ingrese un número válido");
                                            }
                                        } while (opcion != 3);
                                        break;
                                    //Opcion modificar    
                                    case 3:
                                        medicamentos = operaciones.consultarTodos(conexion);
                                        do {
                                            System.out.println("----------------------------------------------------------------------------------------");
                                            System.out.println("Seleccione un medicamento a modificar:");
                                            for (int i = 0; i < operaciones.consultarTodos(conexion).size(); i++) {
                                                System.out.println(i + 1 + ". " + operaciones.consultarTodos(conexion).get(i).getNombreComercial());
                                            }
                                            System.out.print("Eleccion: ");
                                            try {
                                                indexSeleccionado = Integer.parseInt(br.readLine()) - 1;
                                                seleccionado = medicamentos.get(indexSeleccionado);
                                                System.out.println("¿Está seguro que desea modificar el medicamento:\n" +
                                                        "ID: " + seleccionado.getId() + "\n" +
                                                        "Comercial: " + seleccionado.getNombreComercial() + "\n" +
                                                        "Genérico: " + seleccionado.getNombreGenerico());
                                                System.out.println("1. Si");
                                                System.out.println("2. No");
                                                opcion = Integer.parseInt(br.readLine());
                                                switch (opcion) {
                                                    case 1:
                                                        System.out.println("Ingrese Nuevo nombre comercial:");
                                                        nuevoNombreComercial = br.readLine();
                                                        if (nuevoNombreComercial != null && !nuevoNombreComercial.isEmpty() && !nuevoNombreComercial.equals("-1")) {
                                                            System.out.println("Ingrese Nuevo nombre genérico:");
                                                            nuevoNombreGenerico = br.readLine();
                                                            if (nuevoNombreGenerico != null && !nuevoNombreGenerico.isEmpty()) {
                                                                operaciones.modificar(conexion, seleccionado.getId(), nuevoNombreGenerico, nuevoNombreComercial);
                                                                System.out.println("Medicamento modificado.");
                                                                System.out.println("Id: " + seleccionado.getId() + "\nNuevo nombre comercial: " + seleccionado.getNombreComercial() + "\nNuevo nombre genérico: " + seleccionado.getNombreGenerico());
                                                                opcion = 2;
                                                            } else {
                                                                System.out.println("No debe dejar campos vacíos");
                                                            }
                                                        } else {
                                                            System.out.println("No debe dejar campos vacíos");
                                                        }
                                                        break;
                                                    case 2:
                                                        System.out.println("Modificación cancelada");
                                                    default:
                                                        System.out.println("Ingrese una opción válida. Intente de nuevo.");
                                                        break;
                                                }
                                            } catch (IndexOutOfBoundsException | NumberFormatException e) {
                                                System.out.println("ELija una opción correcta. Intente de nuevo. " + e.getMessage());
                                            }
                                        } while (opcion != 2);

                                        break;
                                    case 4: //Eliminar
                                        medicamentos = operaciones.consultarTodos(conexion);
                                        do {
                                            System.out.println("----------------------------------------------------------------------------------------");
                                            System.out.println("Seleccione un medicamento a eliminar:");
                                            for (int i = 0; i < medicamentos.size(); i++) {
                                                System.out.println(i + 1 + ". " + medicamentos.get(i).getNombreComercial());
                                            }
                                            System.out.print("Eleccion: ");
                                            try {
                                                indexSeleccionado = Integer.parseInt(br.readLine()) - 1;
                                                seleccionado = medicamentos.get(indexSeleccionado);
                                                System.out.println("¿Está seguro que desea eliminar el medicamento:\n" +
                                                        "ID: " + seleccionado.getId() + "\n" +
                                                        "Comercial: " + seleccionado.getNombreComercial() + "\n" +
                                                        "Genérico: " + seleccionado.getNombreGenerico());
                                                System.out.println("1. Si");
                                                System.out.println("2. No");
                                                opcion = Integer.parseInt(br.readLine());
                                                switch (opcion) {
                                                    case 1:
                                                        operaciones.eliminarMedicamento(conexion, seleccionado.getId());
                                                        System.out.println("Medicamento eliminado.");
                                                        break;
                                                    case 2:
                                                        System.out.println("Eliminación cancelada");
                                                        break;
                                                    default:
                                                        System.out.println("Elija una opción correcta. Intente de nuevo.");
                                                }
                                            } catch (IndexOutOfBoundsException | NumberFormatException e) {
                                                System.out.println("ELija una opción correcta. Intente de nuevo. " + e.getMessage());
                                            }
                                        } while (opcion != 1 && opcion != 2);
                                        break;
                                    case 5:
                                        break;
                                    default:
                                        System.out.println("Opción no válida. Intente de nuevo.");
                                        break;
                                }
                            } catch (NumberFormatException e) {
                                System.out.println("Ingrese un número válido");
                            }

                        } while (opcion != 5);
                        break;
                    case 2: // Farmacias
                        do {
                            System.out.println("----------------------------------------------------------------------------------------");
                            System.out.println("Menú farmacias ---En construcción---");
                            System.out.println("1. Insertar");
                            System.out.println("2. Consultar");
                            System.out.println("3. Modificar");
                            System.out.println("4. Eliminar");
                            System.out.println("5. Volver");
                            System.out.print("Eleccion: ");
                            try {
                                opcion = Integer.parseInt(br.readLine());
                                switch (opcion) {
                                    case 1, 2,3,4:
                                        System.out.println("Opción en construcción");
                                        break;
                                    case 5:
                                        break;
                                    default:
                                        System.out.println("Elija una opción correcta!");
                                        break;
                                }
                            } catch (NumberFormatException e) {
                                System.out.println("Debe elegir un número válido " + e.getMessage());
                            }
                        } while (opcion != 5);
                        break;
                    case 3: // Salir
                        System.out.println("----------------------------------------------------------------------------------------");
                        System.out.println("Saliendo del sistema...");
                        break;
                    default:
                        System.out.println("----------------------------------------------------------------------------------------");
                        System.out.println("Opción no válida. Intente de nuevo.");
                        break;
                }
            } catch (NumberFormatException e) {
                System.out.println("----------------------------------------------------------------------------------------");
                System.out.println("Ingrese un número válido");
            }
        } while (opcion != 3);
    }
}