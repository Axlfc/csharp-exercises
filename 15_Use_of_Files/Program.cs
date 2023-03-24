// Leer, crear archivos TXT y realizar operaciones

using System.IO;
using System.Net;

string text;

try {
    StreamReader sr = new StreamReader("myFile.txt");
    var line = sr.ReadLine();
    while (line != null) {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close();
} catch (Exception ex) {
    Console.WriteLine($"An exception has occurred: {ex.Message}");
}

// Crear archivo

try {
    StreamWriter sw = new StreamWriter("myNewFile.txt");
    sw.WriteLine("I'm writing in myNewFile.txt");
    sw.Close();
} catch (Exception ex) {
    Console.WriteLine($"An exception has occurred: {ex.Message}");
} finally {
    Console.WriteLine("Program has finished");
}

/* Operaciones con archivos:
    -- Crear archivo
    -- Leer -> Sin modificar
    -- Escribir -> Sí modifica y borra lo anterior
    -- Append -> Añadir contenido al final del archivo
*/

// Read json API 

HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://cat-fact.herokuapp.com/facts");
HttpWebResponse response = (HttpWebResponse)request.GetResponse();

Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);

var json = reader.ReadToEnd();
Console.WriteLine(json);