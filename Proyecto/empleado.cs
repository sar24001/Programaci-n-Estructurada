class Empleado
{
    public string Nombre { get; set; }
    public double SalarioBase { get; set; }
    public double Deducciones { get; set; }

    public double CalcularSalarioNeto()
    {
        return SalarioBase - Deducciones;
    }
}
