using System;

namespace Proyecto1.Entities
{
    public class SolicitudTramite
    {
        public int Id { get; set; }
        public string? NombreSolicitante { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? DireccionSolicitante { get; set; }
        public string? CorreoSolicitante { get; set; }
        public string? NombreTramite { get; set; }
        public byte[]? DocumentoPdf { get; set; }
        public byte[]? DescripcionProyectoPdf { get; set; }
        public byte[]? ListadoEspeciesExcel { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public string? Estado { get; set; }
        public string? NumeroSeguimiento { get; set; }
        public Predio? Predio { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}