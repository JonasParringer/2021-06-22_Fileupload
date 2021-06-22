using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _2021_06_22_Fileupload.Models
{
    public interface IFromFile
    {
        string ContentType { get; }
        string ContentDispoition { get; }
        //IHeaderDirectory Headers { get; }
        long Length { get; }
        string Name { get; }
        string Filename { get; }
        Stream OpenReadStream();
        void CopyTo(Stream target);
        //Task CopyToAsync(Stream target, CancellationToken cancellationToken = null);

        

    }
}
