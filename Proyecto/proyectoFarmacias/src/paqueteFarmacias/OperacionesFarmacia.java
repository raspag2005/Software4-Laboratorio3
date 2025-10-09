package paqueteFarmacias;

import com.itextpdf.text.Document;
import com.itextpdf.text.FontFactory;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.pdf.PdfWriter;
import database.Conexion;

import java.io.FileOutputStream;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.text.DecimalFormat;
import java.util.LinkedList;

public class OperacionesFarmacia {

    public LinkedList<String> consultarBarrios(Conexion obj) throws Exception {
        LinkedList<String> lista = new LinkedList<>();

        Connection cnn = obj.establecer_conexion();
        CallableStatement cstmt = cnn.prepareCall("{call sp_ConsultarBarrios}");
        ResultSet rs = cstmt.executeQuery();

        while (rs.next()) {
            lista.add(rs.getString("barrio"));
        }

        rs.close();
        cstmt.close();
        cnn.close();

        return lista;
    }

    public LinkedList<ClsFarmacia> consultarFarmaciasPorBarrio(Conexion obj, String barrio) throws Exception {
        LinkedList<ClsFarmacia> lista = new LinkedList<>();
        Connection cnn = obj.establecer_conexion();
        CallableStatement cstmt = cnn.prepareCall("{call sp_FarmaciasCercanasPorBarrio(?)}");
        cstmt.setString(1, barrio);
        ResultSet rs = cstmt.executeQuery();


        while (rs.next()) {
            String nombre = rs.getString("NombreFarmacia");
            String direccion = rs.getString("direccion");
            String medicamento = rs.getString("Medicamento");
            double precio = rs.getDouble("precio");
            lista.add(new ClsFarmacia(nombre, barrio, direccion, precio, medicamento));
        }

        rs.close();
        cstmt.close();
        cnn.close();
        return lista;
    }

    public void generarPDF(LinkedList<ClsFarmacia> farmacias, String rutaArchivo) throws Exception {
        Document documento = new Document();
        PdfWriter.getInstance(documento, new FileOutputStream(rutaArchivo));
        documento.open();
        DecimalFormat formatoPrecio = new DecimalFormat("#0.00");
        String identificador;
        String tempIdentificador;
        LinkedList<String> farmaciasProcesadas = new LinkedList<>();
        documento.add(new Paragraph("Farmacias Cercanas a: " + farmacias.get(0).getBarrio().toUpperCase(), FontFactory.getFont(FontFactory.HELVETICA_BOLD, 16)));
        documento.add(new Paragraph(" ")); // Espacio


        for (int i = 0; i < farmacias.size(); i++) {
            ClsFarmacia f = farmacias.get(i);
            identificador = f.getNombre() + "|" + f.getDireccion();

            if (!farmaciasProcesadas.contains(identificador)) {
                farmaciasProcesadas.add(identificador);

                documento.add(new Paragraph("Nombre: " + f.getNombre()));
                documento.add(new Paragraph("Barrio: " + f.getBarrio().toUpperCase()));
                documento.add(new Paragraph("Dirección: " + f.getDireccion()));
                documento.add(new Paragraph("Medicamentos:", FontFactory.getFont(FontFactory.HELVETICA_BOLD, 12)));

                for (int j = 0; j < farmacias.size(); j++) {
                    tempIdentificador = farmacias.get(j).getNombre() + "|" + farmacias.get(j).getDireccion();
                    if (tempIdentificador.equals(identificador)) {
                        documento.add(new Paragraph("- " + farmacias.get(j).getMedicamento() + " ($" + formatoPrecio.format(farmacias.get(j).getPrecio()) + ")"));
                    }
                }

                documento.add(new Paragraph(" ")); // Espacio entre farmacias
            }
        }

        documento.close();
    }


}
