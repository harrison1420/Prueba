namespace Proyecto1.DTOs
{
    public class SolicitudTramiteDTO
    {
        public string? NombreSolicitante { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? DireccionSolicitante { get; set; }
        public string? CorreoSolicitante { get; set; }
        public string? NombreTramite { get; set; }
        public byte[]? DocumentoPdf { get; set; }
        public byte[]? DescripcionProyectoPdf { get; set; }
        public byte[]? ListadoEspeciesExcel { get; set; }
        public string? NombrePredio { get; set; }
        public string? DireccionPredio { get; set; }
        public string? DepartamentoPredio { get; set; }
        public string? MunicipioPredio { get; set; }
    }
}