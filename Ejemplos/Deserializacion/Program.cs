
#pragma warning disable SYSLIB0011
using Deserializacion;
using System.Runtime.Serialization.Formatters.Binary;

var formatter = new BinaryFormatter();

Stream stream = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);

Persona objeto  = formatter.Deserialize(stream) as Persona;

Console.WriteLine(objeto);

stream.Close();

// Advertencias del compilador sobre obsolescencia
#pragma warning restore SYSLIB0011