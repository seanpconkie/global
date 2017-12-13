using System;
using System.Text;

namespace global
{
    public static class g_Exceptions
    {
        public static string proCreateErrorMessage(string strExType, string strExMessage = "",string strExInnerType = "", string strExInnerMessage = "")
        {
            //<summary>provide exception details to return string message for user display.<summary/>
            //<params>strExType = exception .GetType().FullName value
            //strExMessage = exception .Message value
            //strExType = exception .InnerException.GetType().FullName value
            //strExInnerMessage = exception .InnerException.Message value - can be passed NULL or empty<params/>
            //<output>proCreateErrorMessage = string containing error message<output/>
            #region declarations
            var strOutputBuilder = new StringBuilder();
            #endregion

            #region validaton
            if (string.IsNullOrWhiteSpace(strExType))//minimum param is strExType
            {
                throw new System.ArgumentNullException();
            }
            #endregion

            #region procedure
            strOutputBuilder.Append("An error has occured!\n");
            //add error type
            strOutputBuilder.Append("Exception Type: " + strExType + "\n");
            //add message type
            if (!string.IsNullOrWhiteSpace(strExMessage)) 
            {
                strOutputBuilder.Append("Exception Message: " + strExMessage + "\n");
            }
            //add inner exception details
            if (!string.IsNullOrWhiteSpace(strExInnerType))
            {
                strOutputBuilder.Append("[" + strExInnerType + ": ");
            }
            //add inner exception message

            if (string.IsNullOrWhiteSpace(strExInnerType) && !string.IsNullOrWhiteSpace(strExInnerMessage))
            {
                strOutputBuilder.Append("[");
            }
            if (!string.IsNullOrWhiteSpace(strExInnerMessage))
            {
                strOutputBuilder.Append(strExInnerMessage);
            }
            if (!string.IsNullOrWhiteSpace(strExInnerMessage) && !string.IsNullOrWhiteSpace(strExInnerType))
            {
                strOutputBuilder.Append("]");
            }
            #endregion

            return strOutputBuilder.ToString();
            
        }
    }
}
