using System;
using System.Collections.Generic;
using System.Linq;

namespace global
{
    public static class g_HandleStrings
    {
        public static List<char> proSpecialCharacters ()
        {
            //<summary>creates list of special characters.<summary/>
            //<params><params/>
            //<output>ProSpecialCharacters = list of characters which includes all specials<output/>
            #region declarations
            var lstOutputList = new List<char>();
            //create lists of ASCII DEC numbers for chars which are NOT special
            IEnumerable<int> lstLowerCaseLetter = Enumerable.Range(97, 26); 
            IEnumerable<int> lstUpperCaseLetter = Enumerable.Range(65, 26);
            IEnumerable<int> lstNumbers = Enumerable.Range(48, 10);
            #endregion

            #region validaton
            #endregion

            #region procedure
            try
            {
                for (int i = 0; i <= 255; i++)
                {
                    if (lstLowerCaseLetter.Contains(i))
                        continue;
                    else if (lstUpperCaseLetter.Contains(i))
                        continue;
                    else if (lstNumbers.Contains(i))
                        continue;
                    else
                    {
                        lstOutputList.Add(Convert.ToChar(i));
                    }
                }
            }
            catch (Exception ex) //provide user with generic message
            {
                if (ex.InnerException == null)
                {
                    Console.WriteLine(g_Exceptions.proCreateErrorMessage(ex.GetType().FullName, ex.Message));
                }
                else
                {
                    Console.WriteLine(g_Exceptions.proCreateErrorMessage(ex.GetType().FullName, ex.Message, ex.InnerException.GetType().FullName, ex.InnerException.Message));
                }
            }

            return lstOutputList;
            #endregion

        }
    }
}
