using SingleResponsability;

internal class Program
{
    private static void Main(string[] args)
    {
        StudentRepository studentRepository = new();
        ExportHelperCSV exportHelper = new ExportHelperCSV();

        exportHelper.ExportStudents(studentRepository.GetAll());

        Console.WriteLine("Proceso Completado");
    }
}