using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SharedProject
{
    class MySharedCode
    {
        /// <summary>
        /// Implementa la funcionalidad para determinar la ruta de un archivo 
        /// dependiendo de la plataforma en la que se esté ejecutando la aplicación.
        /// </summary>
        /// <param name="fileName">Nombre del archivo.</param>
        /// <returns></returns>
        public string GetFilePath (string fileName)
        {
            var FilePath = string.Empty;
#if WINDOWS_UWP
            FilePath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, fileName);
#else
#if _ANDROID_
            string LibraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            FilePath = FilePath.Combine(LibraryPath, fileName);
#endif
#endif
            return FilePath;
        }
    }
}
