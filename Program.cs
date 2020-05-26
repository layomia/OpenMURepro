using MUnique.OpenMU.DataModel.Configuration;
using System;
using System.Reflection;
using System.Text.Json;

namespace Munique.OpenMU
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializer.Serialize(new MUnique.OpenMU.Persistence.BasicModel.ConnectServerDefinition());
        }
    }
}
