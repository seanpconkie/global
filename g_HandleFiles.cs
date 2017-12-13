using System;
using System.IO;
namespace global
{
    public static class g_HandleFiles
    {
        public static string proReadFile(string strFilePath)
        {
            //<summary>reads content of file selected in arguments and returns string of contents.<summary/>
            //<params>strFilePath = full path of file incl extension and directory<params/>
            //<output>proReadFile = string containing contents of file<output/>
            #region declarations
            //
            #endregion

            #region validaton

            if (string.IsNullOrWhiteSpace(strFilePath))//check path supplied
            {
                throw new System.ArgumentNullException("strFilePath","No file path provided.");
            }
            else if (!File.Exists(strFilePath))
            {
                throw new System.IO.FileNotFoundException("Unable to find specified file - \'" + strFilePath + "\'.");
            }
            #endregion

            #region procedure
            return File.ReadAllText(strFilePath);
            #endregion

        }
    }
}
