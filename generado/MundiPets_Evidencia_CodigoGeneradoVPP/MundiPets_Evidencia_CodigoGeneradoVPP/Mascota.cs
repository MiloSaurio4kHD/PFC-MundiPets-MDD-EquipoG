using MundiPets_Evidencia_CodigoGeneradoVPP;
using System;

public class Mascota
{
    private int idMascota;
    private string nombre;
    private string especie;
    private string raza;
    private DateTime fechaNacimiento;
    private char sexo;
    private bool visibilidadPerfil;

    public bool RegistrarMascota(MascotaDTO datos)
    {
        throw new System.NotImplementedException("Not implemented");
    }
    public void ConfigurarPrivacidad(bool visible)
    {
        throw new System.NotImplementedException("Not implemented");
    }
    public bool ActualizarDatos(MascotaDTO datos)
    {
        throw new System.NotImplementedException("Not implemented");
    }

    private HistorialMedico guarda;
    private DocumentoVeterinario[] tiene;
    private AntecedenteGenetico[] posee;
    private ValidacionMedica[] pasa;

}
