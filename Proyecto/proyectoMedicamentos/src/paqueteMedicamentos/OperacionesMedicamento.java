package paqueteMedicamentos;

import database.Conexion;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.LinkedList;

public class OperacionesMedicamento {

    public void insertarMedicamento(Conexion obj, String nombreComercial, String nombreGenerico) throws Exception {
        Connection cnn = obj.establecer_conexion();
        String sql = "INSERT INTO Medicamentos (nombre_comercial, nombre_generico) VALUES (?, ?)";
        PreparedStatement pstmt = cnn.prepareStatement(sql);
        pstmt.setString(1, nombreComercial);
        pstmt.setString(2, nombreGenerico);
        pstmt.executeUpdate();
        cnn.close();
    }

    public Boolean insertarDesdeCSV(Conexion obj, File archivoCSV) throws Exception {
        Connection cnn = obj.establecer_conexion();
        BufferedReader br = new BufferedReader(new FileReader(archivoCSV));
        String linea;
        boolean insertado = false;
        while ((linea = br.readLine()) != null) {
            String[] datos = linea.split(";");
            if (datos.length >= 2) {
                String nombreComercial = datos[0].trim();
                String nombreGenerico = datos[1].trim();
                String sql = "INSERT INTO Medicamentos (nombre_comercial, nombre_generico) VALUES (?, ?)";
                PreparedStatement pstmt = cnn.prepareStatement(sql);
                pstmt.setString(1, nombreComercial);
                pstmt.setString(2, nombreGenerico);
                pstmt.executeUpdate();
                insertado = true;
            }
        }
        br.close();
        cnn.close();
        return insertado;
    }

    public LinkedList<ClsMedicamento> consultarTodos(Conexion obj) throws Exception {
        LinkedList<ClsMedicamento> lista = new LinkedList<>();

        Connection cnn = obj.establecer_conexion();
        CallableStatement cstmt = cnn.prepareCall("{call sp_ConsultarTodosMedicamentos}");
        ResultSet rs = cstmt.executeQuery();

        while (rs.next()) {
            ClsMedicamento med = new ClsMedicamento(rs.getInt("id_medicamento"), rs.getString("nombre_comercial"), rs.getString("nombre_generico"));
            lista.add(med);
        }

        rs.close();
        cstmt.close();
        cnn.close();

        return lista;
    }


    public String consultarPorNombre(Conexion obj, String nombre) throws Exception {
        Connection cnn = obj.establecer_conexion();
        CallableStatement cstmt = cnn.prepareCall("{call sp_ConsultarMedicamentoPorNombre(?)}");
        cstmt.setString(1, nombre);
        ResultSet rs = cstmt.executeQuery();
        String resultado = "";
        while (rs.next()) {
            resultado += "ID: " + rs.getInt("id_medicamento")
                    + ", Comercial: " + rs.getString("nombre_comercial")
                    + ", Genérico: " + rs.getString("nombre_generico") + "\n";
        }
        if (resultado.isEmpty()) {
            resultado = "No existe el medicamento con el nombre o ID: " + nombre;
        }
        cnn.close();
        return resultado;
    }


    public void eliminarMedicamento(Conexion obj, int id) throws Exception {
        Connection cnn = obj.establecer_conexion();
        String sql = "DELETE FROM Medicamentos WHERE id_medicamento = ?";
        PreparedStatement pstmt = cnn.prepareStatement(sql);
        pstmt.setInt(1, id);
        pstmt.executeUpdate();
        cnn.close();
    }


    public void modificar(Conexion obj, int id, String nuevoNombreGenerico, String nuevoNombreComercial) throws Exception {
        Connection cnn = obj.establecer_conexion();
        String sql = "UPDATE Medicamentos SET nombre_generico = ?, nombre_comercial = ? WHERE id_medicamento = ?";
        PreparedStatement pstmt = cnn.prepareStatement(sql);
        pstmt.setString(1, nuevoNombreGenerico);
        pstmt.setString(2, nuevoNombreComercial);
        pstmt.setInt(3, id);
        pstmt.executeUpdate();
        cnn.close();
    }

}
