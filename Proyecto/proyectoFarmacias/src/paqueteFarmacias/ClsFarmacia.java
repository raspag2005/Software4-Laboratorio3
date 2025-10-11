package paqueteFarmacias;

public class ClsFarmacia {
    private String nombre;
    private String barrio;
    private String direccion;
    private double precio;
    private String medicamento;

    public ClsFarmacia(String nombre, String barrio, String direccion, double precio, String medicamento) {
        this.nombre = nombre;
        this.barrio = barrio;
        this.direccion = direccion;
        this.precio = precio;
        this.medicamento = medicamento;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getBarrio() {
        return barrio;
    }

    public void setBarrio(String barrio) {
        this.barrio = barrio;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public String getMedicamento() {
        return medicamento;
    }

    public void setMedicamento(String medicamento) {
        this.medicamento = medicamento;
    }
}
