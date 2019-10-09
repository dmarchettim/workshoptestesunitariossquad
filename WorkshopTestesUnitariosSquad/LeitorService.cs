using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopTestesUnitariosSquad.Interfaces;

namespace WorkshopTestesUnitariosSquad
{
    public class LeitorService
    {
        public IFileReader _fileReader { get; }


        public LeitorService(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public string LerArquivoCompleto(string arquivo)
        {
            if (arquivo == null) throw new Exception("arquivo vazio");
            return _fileReader.Read(arquivo);
        }

    }
}
