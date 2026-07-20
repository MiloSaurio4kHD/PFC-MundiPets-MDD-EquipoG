using MundiPets_Evidencia_CodigoGeneradoVPP;

public class Usuario
{
    private int idUsuario;
    private string nombre;
    private string correo;
    private string telefono;
    private TipoUsuario tipo;

    public bool Registrar()
    {
        throw new System.NotImplementedException("Not implemented");
    }
    public bool ActualizarDatos(UsuarioDTO datos)
    {
        throw new System.NotImplementedException("Not implemented");
    }
    public Mascota ConsultarPerfil(int idMascota)
    {
        throw new System.NotImplementedException("Not implemented");
    }

    private Mascota[] tiene;

    private ValidacionMedica[] revisa;

}
