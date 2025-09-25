using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Serializacion;

#pragma warning disable SYSLIB0011
var formatter = new BinaryFormatter();

Stream stream = new FileStream("datos.bin", FileMode.Create, FileAccess.Write, FileShare.None);

Persona objeto = new Persona("Juan", 30);

formatter.Serialize(stream, objeto);

stream.Close();

// Advertencias del compilador sobre obsolescencia
#pragma warning restore SYSLIB0011