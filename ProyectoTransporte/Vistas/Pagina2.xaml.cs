namespace ProyectoTransporte.Vistas;

public partial class Pagina2 : ContentPage
{
    
    public Pagina2()
	{
		InitializeComponent();
	}


    private async void AdjuntarArchivo_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Abrir el selector de archivos
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Seleccione un archivo",
            });

            if (result == null)
            {
                // Si no se selecciona una imagen, intentar seleccionar un PDF
                result = await FilePicker.PickAsync(new PickOptions
                {
                    FileTypes = FilePickerFileType.Pdf,
                    PickerTitle = "Seleccione un archivo PDF",
                });
            }

            if (result != null)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = result.FullPath;

            }
        }
        catch (Exception ex)
        {
            // Manejar cualquier excepción que pueda ocurrir durante la selección de archivos
            Console.WriteLine($"Error al seleccionar el archivo: {ex.Message}");
        }
    }


    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}