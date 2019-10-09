using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopTestesUnitariosSquad.Interfaces;

namespace WorkshopTestesUnitariosSquad
{
    public class FileReader : IFileReader
    {

        public string Read(string path)
        {
            var result = File.ReadAllText(path);
                     
            return result;
        }

    }
}
