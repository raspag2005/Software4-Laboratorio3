package database;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Conexion {

    private final String url;

    private Connection cnn; //objeto que permite la conexión a la BD

    public Conexion() {
        this.url = "jdbc:sqlserver://LAPTOP-2TN70U4O:1433;databaseName=FarmaciasDB;encrypt=false;trustServerCertificate=true;";
    }

    // Método de conexion
    public Connection establecer_conexion() throws Exception {
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            cnn = DriverManager.getConnection(url, "A", "12345");
            return cnn;
        } catch (ClassNotFoundException e) {
            throw new Exception("\nPara el programador: " + e +
                    "\n\nPara el usuario: Error...No se pudo cargar el driver puente Jdbc_Odbc");
        } catch (SQLException e) {
            throw new Exception("\nPara el programador: " + e +
                    "\n\nPara el usuario: Error... No se pudo establecer la conexion");
        }
    }
}